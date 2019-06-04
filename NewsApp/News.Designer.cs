namespace NewsApp
{
    partial class News
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSaveNotification = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "News Application";
            this.notifyIcon1.Visible = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(120, 33);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(155, 21);
            this.cmbCategory.TabIndex = 0;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(50, 36);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(49, 13);
            this.category.TabIndex = 1;
            this.category.Text = "Category";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(56, 84);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(43, 13);
            this.country.TabIndex = 2;
            this.country.Text = "Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(120, 81);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(155, 21);
            this.cmbCountry.TabIndex = 3;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(58, 183);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(41, 13);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 176);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 56);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSaveNotification
            // 
            this.lblSaveNotification.AutoSize = true;
            this.lblSaveNotification.Location = new System.Drawing.Point(331, 311);
            this.lblSaveNotification.Name = "lblSaveNotification";
            this.lblSaveNotification.Size = new System.Drawing.Size(0, 13);
            this.lblSaveNotification.TabIndex = 7;
            this.lblSaveNotification.Visible = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(120, 131);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(155, 21);
            this.cmbLanguage.TabIndex = 8;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(44, 134);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 9;
            this.lblLanguage.Text = "Language";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(479, 88);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(77, 13);
            this.lblLink.TabIndex = 10;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "View last news";
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(482, 134);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(204, 17);
            this.chkStartup.TabIndex = 11;
            this.chkStartup.Text = "Run application when Windows starts";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(61, 276);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 12;
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblSaveNotification);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.country);
            this.Controls.Add(this.category);
            this.Controls.Add(this.cmbCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "News";
            this.ShowInTaskbar = false;
            this.Text = "News Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.News_FormClosing);
            this.Load += new System.EventHandler(this.News_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSaveNotification;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.Label lblError;
    }
}

