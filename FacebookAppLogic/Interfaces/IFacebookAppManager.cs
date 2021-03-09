using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic.Interfaces
{
    internal interface IFacebookAppManager
    {
        void Login();
        void Logout();
        bool IsUserLoggedIn();
        User LoggedInUser { get; }

    }
}
