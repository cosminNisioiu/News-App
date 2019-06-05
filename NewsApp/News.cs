using Microsoft.Win32;
using News.Models;
using NewsApp.Data;
using NewsApp.Data.Implementation;
using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace NewsApp
{
    public partial class News : Form
    {
        System.Timers.Timer timer;
        private string URL = string.Empty;
        private string Title = string.Empty;
        private DateTime LastNewsDate;
        private readonly ISettings _settings;
        private readonly NewsData _newsData;
        private SettingsModel SettingsModel;

        private const int Interval = 5 * 60 * 1000; //5 minutes interval

        // The path to the key where Windows looks for startup applications
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public News(ISettings settings)
        {
            _settings = settings;
            _newsData = new NewsData(_settings);

            SetTimer();
            HideForm();
            InitializeComponent();
        }

        #region Events

        private void QuitApp(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void Show_Click(object sender, EventArgs e)
        {
            SettingsModel = _settings.Load();
            LoadCategories();
            LoadCountries();
            LoadLanguages();
            chkStartup.Checked = SettingsModel?.IsStartup ?? false;
            txtSearch.Text = SettingsModel.SearchText ?? string.Empty;
            ShowForm();
        }

        private void News_Load(object sender, EventArgs e)
        {
            InitializeNotificationArea();
            _newsData.BuildUrl();
            NewsModel news = _newsData.GetNews();

            if (news.Articles.Length != 0 && LastNewsDate != news.Articles[0].PublishedAt)
            {
                ShowArticle(news.Articles[0]);
            }

            timer.Interval = Interval;
            timer.Start();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Process.Start(URL);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlsAreValid)
            {
                lblError.Visible = true;
                return;
            }

            SettingsModel settingsModel = new SettingsModel
            {
                Category = cmbCategory.SelectedItem.ToString(),
                Country = cmbCountry.SelectedItem.ToString(),
                Language = cmbLanguage.SelectedItem.ToString(),
                SearchText = txtSearch.Text,
                LastNewsDate = LastNewsDate,
                IsStartup = chkStartup.Checked
            };

            _settings.Save(settingsModel);

            lblSaveNotification.Text = "Settings have been saved!";
            lblSaveNotification.Show();

            if (chkStartup.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("NewsApp", Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("NewsApp", false);
            }

            timer.Interval = Interval;
            timer.Start();
        }

        private void News_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }

            e.Cancel = true;
            HideForm();
        }

        #endregion

        #region Properties

        private bool ControlsAreValid
        {
            get
            {
                if (cmbCategory.SelectedItem == null)
                {
                    lblError.Text = "Category is required!";
                    return false;
                }
                if (cmbCountry.SelectedItem == null)
                {
                    lblError.Text = "Country is required!";
                    return false;
                }
                if (cmbLanguage.SelectedItem == null)
                {
                    lblError.Text = "Language is required!";
                    return false;
                }

                lblError.Visible = false;

                return true;
            }
        }

        #endregion

        #region Methods

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("General");
            cmbCategory.Items.Add("Business");
            cmbCategory.Items.Add("Entertainment");
            cmbCategory.Items.Add("Health");
            cmbCategory.Items.Add("Science");
            cmbCategory.Items.Add("Sports");
            cmbCategory.Items.Add("Technology");

            cmbCategory.SelectedItem = SettingsModel?.Category;
        }

        private void LoadCountries()
        {
            cmbCountry.Items.Clear();

            cmbCountry.Items.Add("Romania");
            cmbCountry.Items.Add("England");

            cmbCountry.SelectedItem = SettingsModel?.Country;
        }

        private void LoadLanguages()
        {
            cmbLanguage.Items.Clear();

            cmbLanguage.Items.Add("Italian");
            cmbLanguage.Items.Add("English");

            cmbLanguage.SelectedItem = SettingsModel?.Language;
        }

        private void SetTimer()
        {
            timer = new System.Timers.Timer
            {
                //When autoreset is True there are reentrancy problems 
                AutoReset = false
            };

            timer.Elapsed += new System.Timers.ElapsedEventHandler(News_Load);
        }

        private void ShowForm()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;

            lblSaveNotification.Text = string.Empty;
        }

        private void HideForm()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void InitializeNotificationArea()
        {
            //notification icon
            var cm = new ContextMenu();
            var quit = new MenuItem("Quit");
            var breakItem = new MenuItem("-");
            var breakItem2 = new MenuItem("-");
            var show = new MenuItem("Show");
            cm.MenuItems.Add(show);
            cm.MenuItems.Add(breakItem2);
            cm.MenuItems.Add(breakItem);
            cm.MenuItems.Add(quit);
            notifyIcon1.ContextMenu = cm;

            show.Click += Show_Click;
            quit.Click += QuitApp;
        }

        private void ShowArticle(ArticleModel article)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = article.Title;
            notifyIcon1.BalloonTipText = article.Description ?? "(No description)";
            notifyIcon1.BalloonTipClicked -= new EventHandler(notifyIcon1_Click); //remove first event (multiple events firing bug)
            notifyIcon1.BalloonTipClicked += new EventHandler(notifyIcon1_Click);
            notifyIcon1.ShowBalloonTip(10000);

            lblLink.Click -= new EventHandler(notifyIcon1_Click);
            lblLink.Click += new EventHandler(notifyIcon1_Click);

            URL = article.Url;
            LastNewsDate = article.PublishedAt;
        }

        #endregion
    }
}
