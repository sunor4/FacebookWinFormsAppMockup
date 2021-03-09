using FacebookAppLogic.DesignPatterns;
using FacebookAppLogic.Interfaces;
using FacebookAppLogic.ObjectClasses;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic.Managers
{
    public class FacebookAppManager : Manager, IFacebookAppManager
    {
        private const string k_AppId = "741973033079119";
        private string[] m_Permissions = {"public_profile",
                    "email",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown" };

        private readonly CommentGenerator r_CommentGenerator;
        private readonly TimeOfDayGreeter r_TimeOfDayGreeter;
        private LoginResult m_UserLoginResult;
        private volatile User m_LoggedInUser;

        protected FacebookAppManager()
        {
            r_CommentGenerator = new CommentGenerator();
            r_TimeOfDayGreeter = new TimeOfDayGreeter();
        }

        public User LoggedInUser
        {
            get 
            {
                if (m_LoggedInUser == null)
                {
                    lock(Lock)
                    {
                        Login();
                    }
                }

                return m_LoggedInUser;
            }
        }

        private string AppId => k_AppId;
        private string[] AppPermissions => m_Permissions;

        public string GetGreetingByTimeOfDay() => r_TimeOfDayGreeter.GetGreetingByTimeOfDay();
        public string GenerateAutoComment(Post i_PostToBeCommented) => r_CommentGenerator.GenerateAutoComment(i_PostToBeCommented);

        public void Login()
        {
            lock (Lock)
            {
                //If this is the first time the user attempts to log in.
                if (!IsUserLoggedIn())
                {

                    m_UserLoginResult = FacebookService.Login(AppId, AppPermissions);
                    if (!string.IsNullOrEmpty(m_UserLoginResult.AccessToken))
                    {
                        m_LoggedInUser = m_UserLoginResult.LoggedInUser;
                    }
                }
            }
        }

        public void Logout()
        {
            lock (Lock)
            {
                FacebookService.Logout(null);
            }
        }

        public bool IsUserLoggedIn()
        {
            return m_LoggedInUser != null;
        }
    }
}
