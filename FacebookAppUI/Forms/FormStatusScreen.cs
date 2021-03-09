using System.Collections;

namespace FacebookAppUI
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;
    using FacebookAppLogic.DesignPatterns;
    using FacebookAppLogic.ExtensionMethods;

    public partial class FormStatusScreen : FormBaseFacebookAppScreen
    {
        private readonly PostedItemsOrderer r_PostedItemsOrderer;

        public FormStatusScreen()
        {
            InitializeComponent();
            r_PostedItemsOrderer = new PostedItemsOrderer();
            orderPostsComboBox.SelectedIndex = 0;
        }

        private void buttonPostNewStatus_Click(object sender, EventArgs e)
        {
            postStatus();
            //List<string> birthdayElements = AppManager.LoggedInUser.Birthday.Split('/').ToList();

            //foreach (string birthdayElement in birthdayElements)
            //{
            //    int.TryParse(birthdayElement, out int b);
            //    Console.WriteLine(b);
            //}
        }

        private void postStatus()
        {
            string message = textBoxStatusText.Text;
            string taggedFriendId = null;

            if (listBoxFriends.SelectedItems.Count == 1 &&
                listBoxFriends.SelectedItem is User taggedFriend)
            {
                taggedFriendId = taggedFriend.Id;
            }

            if (!string.IsNullOrEmpty(message))
            {
                textBoxStatusText.Text = string.Empty;
                listBoxFriends.Items.Clear();
                pictureBoxFriendProfile.Visible = false;
                AppManager.LoggedInUser.PostStatus(message, i_TaggedFriendIDs: taggedFriendId);
            }
            else
            {
                textBoxStatusText.BackColor = Color.LightPink;
            }
        }

        private void textBoxStatusText_TextChanged(object sender, EventArgs e)
        {
            resetTextBoxBackColor(textBoxStatusText);
        }

        private void buttonTagFriend_Click(object sender, EventArgs e)
        {
            PopulateListBoxOfType(AppManager.LoggedInUser.Friends, listBoxFriends);
        }

        private void buttonViewPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {

            IEnumerable<Post> orderedPosts = r_PostedItemsOrderer.Order(AppManager.LoggedInUser.Posts).Cast<Post>();

            PopulateListBoxOfType(orderedPosts, listBoxPosts);

            if (isTodayBirthDay())
            {
                handleBirthday();
            }
        }

        //protected override IEnumerable<PostedItem> Order(IEnumerable<PostedItem> i_Items)
        //{
        //    return r_PostedItemsOrderer.Order(i_Items);
        //}

        private bool isTodayBirthDay()
        {
            return AppManager.LoggedInUser.Birthday.BirthdayToDateTime() == DateTime.Today;
        }

        private void handleBirthday()
        {
            buttonAutoReplyBirthday.Visible = true;
            buttonSeeBirthdayPosts.Visible = true;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItems.Count == 1 &&
                listBoxPosts.SelectedItem is Post selectPost)
            {
                showPostDetails(selectPost);
            }
        }

        private void showPostDetails(Post i_Post)
        {
            textBoxPostedStatusMessage.Text = i_Post.Message;
            PopulateListBoxOfType(i_Post.TaggedUsers, listBoxTagged);
            PopulateListBoxOfType(i_Post.Comments, listBoxComments);

            if (!string.IsNullOrEmpty(i_Post.PictureURL))
            {
                pictureBoxPostPhoto.Visible = true;
                pictureBoxPostPhoto.LoadAsync(i_Post.PictureURL);
            }
            else
            {
                pictureBoxPostPhoto.Visible = false;
            }

            textBoxComment.Visible = true;
            buttonLikePost.Visible = true;
            buttonCommentOnPost.Visible = true;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count == 1 &&
                listBoxFriends.SelectedItem is User selectFriend)
            {
                pictureBoxFriendProfile.LoadAsync(selectFriend.PictureNormalURL);
                pictureBoxFriendProfile.Visible = true;
            }
        }

        private void buttonCommentOnPost_Click(object sender, EventArgs e)
        {
            commentOnPost();
        }

        private void commentOnPost()
        {
            if (listBoxPosts.SelectedItems.Count == 1 &&
                listBoxPosts.SelectedItem is Post selectPost)
            {
                if (!string.IsNullOrEmpty(textBoxComment.Text))
                {
                    buttonCommentOnPost.Visible = false;
                    textBoxComment.Visible = false;
                    buttonLikePost.Visible = false;
                    selectPost.Comment(textBoxComment.Text);
                }
                else
                {
                    textBoxComment.BackColor = Color.LightPink;
                }
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            resetTextBoxBackColor(textBoxComment);
        }

        private void resetTextBoxBackColor(TextBox i_TextBox)
        {
            if (i_TextBox.BackColor != Color.White)
            {
                i_TextBox.BackColor = Color.White;
            }
        }

        private void buttonSeeBirthdayPosts_Click(object sender, EventArgs e)
        {
            showOnlyBirthdayRelatedPosts();
        }

        private void showOnlyBirthdayRelatedPosts()
        {
            List<Post> birthdayPosts = new List<Post>();

            Regex hebrewBirthdayMessageRegex = new Regex("מזל טוב");
            Regex englishBirthdayMessageRegex = new Regex("[Bb][Ii][rR][tT][hH][dD][aA][yY]");
            foreach (object item in listBoxPosts.Items)
            {
                if (item is Post post)
                {
                    if (!string.IsNullOrEmpty(post.Message) &&
                        post.CreatedTime.Value.ToShortDateString().Equals(DateTime.Today.ToShortDateString()) &&
                        (hebrewBirthdayMessageRegex.IsMatch(post.Message) || englishBirthdayMessageRegex.IsMatch(post.Message)))
                    {
                        birthdayPosts.Add(post);
                    }
                }
            }

            PopulateListBoxOfType(birthdayPosts, listBoxPosts);
        }

        private void buttonAutoReplyBirthday_Click(object sender, EventArgs e)
        {
            showOnlyBirthdayRelatedPosts();
            autoReplyToBirthdayPosts();
        }

        private void autoReplyToBirthdayPosts()
        {
            foreach (object item in listBoxPosts.Items)
            {
                if (item is Post birthdayPost)
                {
                    string replyMessage = AppManager.GenerateAutoComment(birthdayPost);
                    birthdayPost.Comment(replyMessage);
                    //Console.WriteLine(replyMessage);
                }
            }
        }

        private void buttonLikePost_Click(object sender, EventArgs e)
        {
            likePost();
        }

        private void likePost()
        {
            if (listBoxPosts.SelectedItems.Count == 1 &&
                listBoxPosts.SelectedItem is Post selectPost)
            {
                selectPost.Like();
            }
        }

        private void orderPostsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setOrderStrategy((eOrderStrategyType)orderPostsComboBox.SelectedIndex);
        }

        private void setOrderStrategy(eOrderStrategyType i_Strategy)
        {
            r_PostedItemsOrderer.SetOrderStrategy((eOrderStrategyType)orderPostsComboBox.SelectedIndex);
        }
    }
}
