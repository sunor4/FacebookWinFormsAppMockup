namespace FacebookAppUI
{
    partial class FormStatusScreen
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
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.textBoxStatusText = new System.Windows.Forms.TextBox();
            this.buttonTagFriend = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelStatusMessage = new System.Windows.Forms.Label();
            this.buttonViewPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxPostedStatusMessage = new System.Windows.Forms.TextBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTagged = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPostPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.buttonCommentOnPost = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonAutoReplyBirthday = new System.Windows.Forms.Button();
            this.buttonSeeBirthdayPosts = new System.Windows.Forms.Button();
            this.buttonLikePost = new System.Windows.Forms.Button();
            this.orderPostsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPostNewStatus.Location = new System.Drawing.Point(289, 12);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(84, 43);
            this.buttonPostNewStatus.TabIndex = 15;
            this.buttonPostNewStatus.Text = "Post Status";
            this.buttonPostNewStatus.UseVisualStyleBackColor = false;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonPostNewStatus_Click);
            // 
            // textBoxStatusText
            // 
            this.textBoxStatusText.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStatusText.Location = new System.Drawing.Point(379, 12);
            this.textBoxStatusText.Multiline = true;
            this.textBoxStatusText.Name = "textBoxStatusText";
            this.textBoxStatusText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatusText.Size = new System.Drawing.Size(236, 176);
            this.textBoxStatusText.TabIndex = 16;
            this.textBoxStatusText.TextChanged += new System.EventHandler(this.textBoxStatusText_TextChanged);
            // 
            // buttonTagFriend
            // 
            this.buttonTagFriend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTagFriend.Location = new System.Drawing.Point(513, 295);
            this.buttonTagFriend.Name = "buttonTagFriend";
            this.buttonTagFriend.Size = new System.Drawing.Size(84, 43);
            this.buttonTagFriend.TabIndex = 17;
            this.buttonTagFriend.Text = "Tag a Friend";
            this.buttonTagFriend.UseVisualStyleBackColor = false;
            this.buttonTagFriend.Click += new System.EventHandler(this.buttonTagFriend_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.Location = new System.Drawing.Point(495, 194);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 95);
            this.listBoxFriends.TabIndex = 18;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelStatusMessage
            // 
            this.labelStatusMessage.AutoSize = true;
            this.labelStatusMessage.Location = new System.Drawing.Point(382, 175);
            this.labelStatusMessage.Name = "labelStatusMessage";
            this.labelStatusMessage.Size = new System.Drawing.Size(50, 13);
            this.labelStatusMessage.TabIndex = 19;
            this.labelStatusMessage.Text = "Message";
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewPosts.Location = new System.Drawing.Point(12, 12);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(84, 43);
            this.buttonViewPosts.TabIndex = 20;
            this.buttonViewPosts.Text = "View Posts";
            this.buttonViewPosts.UseVisualStyleBackColor = false;
            this.buttonViewPosts.Click += new System.EventHandler(this.buttonViewPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.Location = new System.Drawing.Point(114, 12);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(169, 134);
            this.listBoxPosts.TabIndex = 21;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // textBoxPostedStatusMessage
            // 
            this.textBoxPostedStatusMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPostedStatusMessage.Location = new System.Drawing.Point(12, 161);
            this.textBoxPostedStatusMessage.Multiline = true;
            this.textBoxPostedStatusMessage.Name = "textBoxPostedStatusMessage";
            this.textBoxPostedStatusMessage.ReadOnly = true;
            this.textBoxPostedStatusMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPostedStatusMessage.Size = new System.Drawing.Size(205, 135);
            this.textBoxPostedStatusMessage.TabIndex = 22;
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.HorizontalScrollbar = true;
            this.listBoxComments.Location = new System.Drawing.Point(138, 316);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(120, 95);
            this.listBoxComments.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Comments";
            // 
            // listBoxTagged
            // 
            this.listBoxTagged.FormattingEnabled = true;
            this.listBoxTagged.HorizontalScrollbar = true;
            this.listBoxTagged.Location = new System.Drawing.Point(12, 317);
            this.listBoxTagged.Name = "listBoxTagged";
            this.listBoxTagged.Size = new System.Drawing.Size(120, 95);
            this.listBoxTagged.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tagged";
            // 
            // pictureBoxPostPhoto
            // 
            this.pictureBoxPostPhoto.Location = new System.Drawing.Point(223, 161);
            this.pictureBoxPostPhoto.Name = "pictureBoxPostPhoto";
            this.pictureBoxPostPhoto.Size = new System.Drawing.Size(91, 87);
            this.pictureBoxPostPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPhoto.TabIndex = 28;
            this.pictureBoxPostPhoto.TabStop = false;
            this.pictureBoxPostPhoto.Visible = false;
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(379, 194);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(91, 87);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfile.TabIndex = 29;
            this.pictureBoxFriendProfile.TabStop = false;
            this.pictureBoxFriendProfile.Visible = false;
            // 
            // buttonCommentOnPost
            // 
            this.buttonCommentOnPost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCommentOnPost.Location = new System.Drawing.Point(284, 353);
            this.buttonCommentOnPost.Name = "buttonCommentOnPost";
            this.buttonCommentOnPost.Size = new System.Drawing.Size(78, 43);
            this.buttonCommentOnPost.TabIndex = 30;
            this.buttonCommentOnPost.Text = "Post Comment";
            this.buttonCommentOnPost.UseVisualStyleBackColor = false;
            this.buttonCommentOnPost.Visible = false;
            this.buttonCommentOnPost.Click += new System.EventHandler(this.buttonCommentOnPost_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxComment.Location = new System.Drawing.Point(284, 317);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComment.Size = new System.Drawing.Size(159, 30);
            this.textBoxComment.TabIndex = 31;
            this.textBoxComment.Visible = false;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // buttonAutoReplyBirthday
            // 
            this.buttonAutoReplyBirthday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAutoReplyBirthday.Location = new System.Drawing.Point(12, 99);
            this.buttonAutoReplyBirthday.Name = "buttonAutoReplyBirthday";
            this.buttonAutoReplyBirthday.Size = new System.Drawing.Size(84, 47);
            this.buttonAutoReplyBirthday.TabIndex = 32;
            this.buttonAutoReplyBirthday.Text = "Auto Reply to Birthday Posts";
            this.buttonAutoReplyBirthday.UseVisualStyleBackColor = false;
            this.buttonAutoReplyBirthday.Visible = false;
            this.buttonAutoReplyBirthday.Click += new System.EventHandler(this.buttonAutoReplyBirthday_Click);
            // 
            // buttonSeeBirthdayPosts
            // 
            this.buttonSeeBirthdayPosts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSeeBirthdayPosts.Location = new System.Drawing.Point(12, 55);
            this.buttonSeeBirthdayPosts.Name = "buttonSeeBirthdayPosts";
            this.buttonSeeBirthdayPosts.Size = new System.Drawing.Size(84, 43);
            this.buttonSeeBirthdayPosts.TabIndex = 33;
            this.buttonSeeBirthdayPosts.Text = "See Birthday Related Posts";
            this.buttonSeeBirthdayPosts.UseVisualStyleBackColor = false;
            this.buttonSeeBirthdayPosts.Visible = false;
            this.buttonSeeBirthdayPosts.Click += new System.EventHandler(this.buttonSeeBirthdayPosts_Click);
            // 
            // buttonLikePost
            // 
            this.buttonLikePost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLikePost.Location = new System.Drawing.Point(365, 353);
            this.buttonLikePost.Name = "buttonLikePost";
            this.buttonLikePost.Size = new System.Drawing.Size(78, 43);
            this.buttonLikePost.TabIndex = 34;
            this.buttonLikePost.Text = "Like Post";
            this.buttonLikePost.UseVisualStyleBackColor = false;
            this.buttonLikePost.Visible = false;
            this.buttonLikePost.Click += new System.EventHandler(this.buttonLikePost_Click);
            // 
            // orderPostsComboBox
            // 
            this.orderPostsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderPostsComboBox.FormattingEnabled = true;
            this.orderPostsComboBox.Items.AddRange(new object[] {
            "Date",
            "Text"});
            this.orderPostsComboBox.Location = new System.Drawing.Point(289, 61);
            this.orderPostsComboBox.Name = "orderPostsComboBox";
            this.orderPostsComboBox.Size = new System.Drawing.Size(84, 21);
            this.orderPostsComboBox.TabIndex = 36;
            this.orderPostsComboBox.SelectedIndexChanged += new System.EventHandler(this.orderPostsComboBox_SelectedIndexChanged);
            // 
            // FormStatusScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 432);
            this.Controls.Add(this.orderPostsComboBox);
            this.Controls.Add(this.buttonLikePost);
            this.Controls.Add(this.buttonSeeBirthdayPosts);
            this.Controls.Add(this.buttonAutoReplyBirthday);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonCommentOnPost);
            this.Controls.Add(this.pictureBoxFriendProfile);
            this.Controls.Add(this.pictureBoxPostPhoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTagged);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.textBoxPostedStatusMessage);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonViewPosts);
            this.Controls.Add(this.labelStatusMessage);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonTagFriend);
            this.Controls.Add(this.textBoxStatusText);
            this.Controls.Add(this.buttonPostNewStatus);
            this.Name = "FormStatusScreen";
            this.Text = "FormStatusScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPostNewStatus;
        private System.Windows.Forms.TextBox textBoxStatusText;
        private System.Windows.Forms.Button buttonTagFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelStatusMessage;
        private System.Windows.Forms.Button buttonViewPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxPostedStatusMessage;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTagged;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPostPhoto;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.Button buttonCommentOnPost;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonAutoReplyBirthday;
        private System.Windows.Forms.Button buttonSeeBirthdayPosts;
        private System.Windows.Forms.Button buttonLikePost;
        private System.Windows.Forms.ComboBox orderPostsComboBox;
    }
}