using System.Drawing;

namespace FacebookAppUI
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using FacebookAppUI.Controls;

    public partial class FormMainMenu : FormBaseFacebookAppScreen
    {
        private const string k_UserInfoFormString = "UserInfo";
        private const string k_AlbumsScreenFormString = "Albums";
        private const string k_EventerScreenFormString = "Events";
        private const string k_StatusScreenFormString = "Status";
        private const string k_MusicPlayerFormString = "MusicPlayer";
        public event Action LoginInitiated;
        private Form m_ActiveSubForm;
        private readonly List<Form> r_SubForms = new List<Form>();
        private readonly Dictionary<string, Form> r_SubFormsDictionary = new Dictionary<string, Form>();
        private readonly FormFacebookLogin r_FormLogin = new FormFacebookLogin();

        public FormMainMenu()
        {
            InitializeComponent();
            panelToolbar.SendToBack();
            initLogin();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void initLogin()
        {
            subscribeToLoginEvents();
            changeActiveForm(r_FormLogin);
        }

        private void subscribeToLoginEvents()
        {
            r_FormLogin.FormClosing += FormLogin_FormClosing;
            this.LoginInitiated += createSubForms;
            this.LoginInitiated += subscribeSubFormsToEvents;
            this.LoginInitiated += subscribeLabelsAndButtonsToEvents;
            this.LoginInitiated += changeGreetingsMessage;
            this.LoginInitiated += initProfileSection;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is FormFacebookLogin closedForm)
            {
                this.OnLogin();
            }
        }

        private void OnLogin()
        {
            if (this.LoginInitiated != null)
            {
                this.LoginInitiated.Invoke();
            }
        }

        private void subscribeSubFormsToEvents()
        {
            for (int i = 0; i < panelSideMenu.Controls.Count; i++)
            {
                Control currentControl = panelSideMenu.Controls[i];
                if (currentControl is SubmenuButton subformbutton)
                {
                    // subscribe to click event
                    subformbutton.Click += SideButtonClick;
                }
            }
        }

        private void SideButtonClick(object i_Sender, EventArgs i_EventArgs)
        {
            if (i_Sender is SubmenuButton menuButton)
            {
                changeActiveForm(r_SubFormsDictionary[menuButton.ParentFormType]);
            }
        }

        // This is going to be called once after login is done and is supposed to greet the user with a nice welcome message.
        private void changeGreetingsMessage()
        {
            const string k_WelcomeMessageFormat = "Good {0}, {1}! It's good to have you back :)";
            string dayGreetingText = AppManager.GetGreetingByTimeOfDay();
            labelGreeting.Text = string.Format(k_WelcomeMessageFormat, dayGreetingText, AppManager.LoggedInUser);
        }

        // Create all forms in composition
        private void createSubForms()
        {
            addSubFormToCollection(k_UserInfoFormString, new FormUserInfoScreen());
            addSubFormToCollection(k_EventerScreenFormString, new FormEventerScreen());
            addSubFormToCollection(k_StatusScreenFormString, new FormStatusScreen());
            addSubFormToCollection(k_AlbumsScreenFormString, new FormAlbumsScreen());
            addSubFormToCollection(k_MusicPlayerFormString, new FormMusicPlayer());
        }

        private void addSubFormToCollection(string i_FormDescription, Form i_FormToAdd)
        {
            r_SubForms.Add(i_FormToAdd);
            r_SubFormsDictionary.Add(i_FormDescription, i_FormToAdd);
        }

        // Overload for event registration purposes
        private void subscribeLabelsAndButtonsToEvents()
        {
            subscribeLabelsAndButtonsToEvents(this);
        }

        private void subscribeLabelsAndButtonsToEvents(Control i_ControlsContainer)
        {
            foreach (Control i_Control in i_ControlsContainer.Controls)
            {
                if (i_Control.Controls.Count > 0)
                {
                    subscribeLabelsAndButtonsToEvents(i_Control);
                }
                else if (i_Control is Button || i_Control is Label)
                {
                    this.LoginInitiated += i_Control.Show;
                    i_Control.Visible = true;
                }
            }
        }

        // Initilalizes the profile section of the app (top left)
        private void initProfileSection()
        { 
            labelProfileName.Text = AppManager.LoggedInUser.Name;
            pictureBoxProfile.LoadAsync(AppManager.LoggedInUser.PictureNormalURL);
            pictureBoxProfile.BringToFront();
        }

        // Receive a form to set into the main-form panel. If the received form is null - do nothing.
        private void changeActiveForm(Form i_NewForm)
        {
            if (m_ActiveSubForm == null || i_NewForm.GetType() != m_ActiveSubForm.GetType())
            {
                if (m_ActiveSubForm != null)
                {
                    m_ActiveSubForm.Hide();
                }

                // Handles case of null form (avoids crashing).
                if (i_NewForm != null)
                {
                    m_ActiveSubForm = i_NewForm;
                    prepareCurrentFormAndShow();
                }
            }
        }

        private void prepareCurrentFormAndShow()
        {
            // Change form style to show in the main panel exactly as we want.
            m_ActiveSubForm.TopLevel = false;
            m_ActiveSubForm.FormBorderStyle = FormBorderStyle.None;
            m_ActiveSubForm.Size = panelMainForm.Size;
            m_ActiveSubForm.Dock = DockStyle.Fill;

            // Add form to panel controls:
            panelMainForm.Controls.Add(m_ActiveSubForm);
            panelMainForm.Tag = m_ActiveSubForm;

            // Finally, bring the current form to the front and show it.
            m_ActiveSubForm.BringToFront();
            m_ActiveSubForm.Activate();
            m_ActiveSubForm.Show();
        }
    }
}
