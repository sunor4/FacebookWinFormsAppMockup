namespace FacebookAppUI
{
    partial class FormMusicPlayer
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
            this.buttonBrowseMusic = new System.Windows.Forms.Button();
            this.textBoxNowPlaying = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelNowPlaying = new System.Windows.Forms.Label();
            this.panelLinks = new System.Windows.Forms.Panel();
            this.pictureBoxYoutubeLogo = new System.Windows.Forms.PictureBox();
            this.buttonPlayVideo = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelEnterLink = new System.Windows.Forms.Label();
            this.panelWebBrowser = new System.Windows.Forms.Panel();
            this.webBrowserYoutube = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panelLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutubeLogo)).BeginInit();
            this.panelWebBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowseMusic
            // 
            this.buttonBrowseMusic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBrowseMusic.Location = new System.Drawing.Point(12, 340);
            this.buttonBrowseMusic.Name = "buttonBrowseMusic";
            this.buttonBrowseMusic.Size = new System.Drawing.Size(84, 31);
            this.buttonBrowseMusic.TabIndex = 23;
            this.buttonBrowseMusic.Text = "Browse Music";
            this.buttonBrowseMusic.UseVisualStyleBackColor = false;
            this.buttonBrowseMusic.Click += new System.EventHandler(this.buttonBrowseMusic_Click);
            // 
            // textBoxNowPlaying
            // 
            this.textBoxNowPlaying.Location = new System.Drawing.Point(102, 346);
            this.textBoxNowPlaying.Name = "textBoxNowPlaying";
            this.textBoxNowPlaying.ReadOnly = true;
            this.textBoxNowPlaying.Size = new System.Drawing.Size(207, 20);
            this.textBoxNowPlaying.TabIndex = 24;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlay.Location = new System.Drawing.Point(320, 388);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(84, 27);
            this.buttonPlay.TabIndex = 25;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPause.Location = new System.Drawing.Point(230, 388);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(84, 27);
            this.buttonPause.TabIndex = 26;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarVolume.Location = new System.Drawing.Point(10, 391);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(213, 45);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 27;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(10, 375);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 13);
            this.labelVolume.TabIndex = 28;
            this.labelVolume.Text = "Volume";
            // 
            // labelNowPlaying
            // 
            this.labelNowPlaying.AutoSize = true;
            this.labelNowPlaying.Location = new System.Drawing.Point(99, 330);
            this.labelNowPlaying.Name = "labelNowPlaying";
            this.labelNowPlaying.Size = new System.Drawing.Size(66, 13);
            this.labelNowPlaying.TabIndex = 29;
            this.labelNowPlaying.Text = "Now Playing";
            // 
            // panelLinks
            // 
            this.panelLinks.Controls.Add(this.pictureBoxYoutubeLogo);
            this.panelLinks.Controls.Add(this.buttonPlayVideo);
            this.panelLinks.Controls.Add(this.textBoxLink);
            this.panelLinks.Controls.Add(this.labelError);
            this.panelLinks.Controls.Add(this.labelEnterLink);
            this.panelLinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLinks.Location = new System.Drawing.Point(0, 0);
            this.panelLinks.Name = "panelLinks";
            this.panelLinks.Size = new System.Drawing.Size(630, 71);
            this.panelLinks.TabIndex = 30;
            // 
            // pictureBoxYoutubeLogo
            // 
            this.pictureBoxYoutubeLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYoutubeLogo.BackgroundImage = global::FacebookAppUI.Properties.Resources.youtube_logo;
            this.pictureBoxYoutubeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxYoutubeLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxYoutubeLogo.Location = new System.Drawing.Point(8, 36);
            this.pictureBoxYoutubeLogo.Name = "pictureBoxYoutubeLogo";
            this.pictureBoxYoutubeLogo.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxYoutubeLogo.TabIndex = 4;
            this.pictureBoxYoutubeLogo.TabStop = false;
            // 
            // buttonPlayVideo
            // 
            this.buttonPlayVideo.BackColor = System.Drawing.Color.Red;
            this.buttonPlayVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayVideo.FlatAppearance.BorderSize = 0;
            this.buttonPlayVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayVideo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayVideo.ForeColor = System.Drawing.Color.White;
            this.buttonPlayVideo.Location = new System.Drawing.Point(562, 8);
            this.buttonPlayVideo.Name = "buttonPlayVideo";
            this.buttonPlayVideo.Size = new System.Drawing.Size(66, 30);
            this.buttonPlayVideo.TabIndex = 3;
            this.buttonPlayVideo.Text = "Play";
            this.buttonPlayVideo.UseVisualStyleBackColor = false;
            this.buttonPlayVideo.Click += new System.EventHandler(this.buttonPlayVideo_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.Location = new System.Drawing.Point(93, 8);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(463, 30);
            this.textBoxLink.TabIndex = 2;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(188, 47);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(181, 16);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "Error! Invalid Youtube link.";
            this.labelError.Visible = false;
            // 
            // labelEnterLink
            // 
            this.labelEnterLink.AutoSize = true;
            this.labelEnterLink.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterLink.Location = new System.Drawing.Point(4, 14);
            this.labelEnterLink.Name = "labelEnterLink";
            this.labelEnterLink.Size = new System.Drawing.Size(86, 19);
            this.labelEnterLink.TabIndex = 0;
            this.labelEnterLink.Text = "Enter Link:";
            // 
            // panelWebBrowser
            // 
            this.panelWebBrowser.BackColor = System.Drawing.Color.Transparent;
            this.panelWebBrowser.Controls.Add(this.webBrowserYoutube);
            this.panelWebBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWebBrowser.Location = new System.Drawing.Point(0, 71);
            this.panelWebBrowser.Name = "panelWebBrowser";
            this.panelWebBrowser.Size = new System.Drawing.Size(630, 256);
            this.panelWebBrowser.TabIndex = 31;
            // 
            // webBrowserYoutube
            // 
            this.webBrowserYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserYoutube.Location = new System.Drawing.Point(0, 0);
            this.webBrowserYoutube.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserYoutube.Name = "webBrowserYoutube";
            this.webBrowserYoutube.Size = new System.Drawing.Size(630, 256);
            this.webBrowserYoutube.TabIndex = 0;
            // 
            // FormMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 419);
            this.Controls.Add(this.panelWebBrowser);
            this.Controls.Add(this.panelLinks);
            this.Controls.Add(this.labelNowPlaying);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxNowPlaying);
            this.Controls.Add(this.buttonBrowseMusic);
            this.Name = "FormMusicPlayer";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panelLinks.ResumeLayout(false);
            this.panelLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutubeLogo)).EndInit();
            this.panelWebBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowseMusic;
        private System.Windows.Forms.TextBox textBoxNowPlaying;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelNowPlaying;
        private System.Windows.Forms.Panel panelLinks;
        private System.Windows.Forms.Button buttonPlayVideo;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelEnterLink;
        private System.Windows.Forms.PictureBox pictureBoxYoutubeLogo;
        private System.Windows.Forms.Panel panelWebBrowser;
        private System.Windows.Forms.WebBrowser webBrowserYoutube;
    }
}