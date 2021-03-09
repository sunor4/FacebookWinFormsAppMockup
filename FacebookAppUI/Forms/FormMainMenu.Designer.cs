
using FacebookAppUI.Controls;

namespace FacebookAppUI
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonPlayMusic = new FacebookAppUI.Controls.SubmenuButton();
            this.buttonProfile = new FacebookAppUI.Controls.SubmenuButton();
            this.buttonEvents = new FacebookAppUI.Controls.SubmenuButton();
            this.buttonAlbums = new FacebookAppUI.Controls.SubmenuButton();
            this.buttonFeed = new FacebookAppUI.Controls.SubmenuButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panelSideMenu.Controls.Add(this.buttonPlayMusic);
            this.panelSideMenu.Controls.Add(this.buttonProfile);
            this.panelSideMenu.Controls.Add(this.buttonEvents);
            this.panelSideMenu.Controls.Add(this.buttonAlbums);
            this.panelSideMenu.Controls.Add(this.buttonFeed);
            this.panelSideMenu.Controls.Add(this.panelProfile);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(180, 554);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonPlayMusic
            // 
            this.buttonPlayMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayMusic.FlatAppearance.BorderSize = 0;
            this.buttonPlayMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.buttonPlayMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.buttonPlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayMusic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPlayMusic.ForeColor = System.Drawing.Color.White;
            this.buttonPlayMusic.Location = new System.Drawing.Point(0, 260);
            this.buttonPlayMusic.Name = "buttonPlayMusic";
            this.buttonPlayMusic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPlayMusic.ParentFormType = "MusicPlayer";
            this.buttonPlayMusic.Size = new System.Drawing.Size(180, 40);
            this.buttonPlayMusic.TabIndex = 7;
            this.buttonPlayMusic.Text = "Play Music";
            this.buttonPlayMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayMusic.UseVisualStyleBackColor = false;
            this.buttonPlayMusic.Visible = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProfile.Location = new System.Drawing.Point(0, 220);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonProfile.ParentFormType = "UserInfo";
            this.buttonProfile.Size = new System.Drawing.Size(180, 40);
            this.buttonProfile.TabIndex = 6;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Visible = false;
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.buttonEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.buttonEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEvents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEvents.Location = new System.Drawing.Point(0, 180);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonEvents.ParentFormType = "Events";
            this.buttonEvents.Size = new System.Drawing.Size(180, 40);
            this.buttonEvents.TabIndex = 4;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Visible = false;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.buttonAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.buttonAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbums.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAlbums.Location = new System.Drawing.Point(0, 140);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAlbums.ParentFormType = "Albums";
            this.buttonAlbums.Size = new System.Drawing.Size(180, 40);
            this.buttonAlbums.TabIndex = 3;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Visible = false;
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.buttonFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFeed.FlatAppearance.BorderSize = 0;
            this.buttonFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.buttonFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.buttonFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFeed.Location = new System.Drawing.Point(0, 100);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFeed.ParentFormType = "Status";
            this.buttonFeed.Size = new System.Drawing.Size(180, 40);
            this.buttonFeed.TabIndex = 2;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Visible = false;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.labelProfileName);
            this.panelProfile.Controls.Add(this.pictureBoxProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(180, 100);
            this.panelProfile.TabIndex = 1;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelProfileName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelProfileName.Location = new System.Drawing.Point(81, 7);
            this.labelProfileName.MaximumSize = new System.Drawing.Size(90, 0);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(90, 18);
            this.labelProfileName.TabIndex = 1;
            this.labelProfileName.Text = "Profile Name";
            this.labelProfileName.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(70, 80);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // panelMainForm
            // 
            this.panelMainForm.Location = new System.Drawing.Point(180, 40);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(754, 514);
            this.panelMainForm.TabIndex = 2;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.panelToolbar.Controls.Add(this.labelGreeting);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(934, 40);
            this.panelToolbar.TabIndex = 1;
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(16)))), ((int)(((byte)(192)))));
            this.labelGreeting.Location = new System.Drawing.Point(202, 9);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(88, 19);
            this.labelGreeting.TabIndex = 0;
            this.labelGreeting.Text = "Greetings";
            this.labelGreeting.Visible = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 554);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelToolbar);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.Text = "Welcome To Facebook";
            this.panelSideMenu.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private SubmenuButton buttonFeed;
        private System.Windows.Forms.Panel panelProfile;
        private SubmenuButton buttonProfile;
        private SubmenuButton buttonEvents;
        private SubmenuButton buttonAlbums;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Panel panelMainForm;
        private SubmenuButton buttonPlayMusic;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label labelGreeting;
    }
}