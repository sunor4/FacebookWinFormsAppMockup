namespace FacebookAppUI
{
    using System;
    using FacebookAppLogic.DesignPatterns;
    using FacebookAppLogic.Managers;

    public partial class FormFacebookLogin : FormBaseFacebookAppScreen
    {
        public FormFacebookLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
            this.Close();
        }

        private void login()
        {
            ManagersFactory.GetInstance<FacebookAppManager>().Login();
        }
    }
}
