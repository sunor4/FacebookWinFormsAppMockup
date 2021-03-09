namespace FacebookAppUI
{
    using System;
    using FacebookWrapper.ObjectModel;

    public partial class FormUserInfoScreen : FormBaseFacebookAppScreen
    {
        public FormUserInfoScreen() 
        {
            InitializeComponent();
            this.Text = $@"Profile Page: {AppManager.LoggedInUser.Name}";
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            populateUserInfo();
        }

        private void populateUserInfo()
        {
            labelUserName.Text = AppManager.LoggedInUser.Name;
            pictureBoxProfile.LoadAsync(AppManager.LoggedInUser.PictureNormalURL);
            textBoxBirthday.Text = AppManager.LoggedInUser.Birthday.ToString();
            textBoxFrom.Text = AppManager.LoggedInUser.Location.ToString().Replace("(location: )", "");
            textBoxGender.Text = AppManager.LoggedInUser.Gender.ToString();

            var allFriends = AppManager.LoggedInUser.Friends;

            if (!listBoxFriends.InvokeRequired)
            {
                userBindingSource.DataSource = allFriends;
            }
            else
            {
                listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }
        }
    }
}
