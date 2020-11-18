using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class FormMainFacebookApp : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private TabsManager m_TabsManager;

        public FormMainFacebookApp()
        {
            m_TabsManager = new TabsManager();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
        }

        private void loginAndInit()
        {
            if (m_LoginResult == null)
            {
                /// Owner: design.patterns
                ///EAAUm6cZC4eUEBALVbi9bZAb5VFs1ebDkmva0uhzXkgRRlMY8YVVBEjoJRw5e6fdxnbrHezOCBpqybBCglBWxpyaFlqSu98nqSpp3yXhgcDl6YoRH6zSKMIZA3em1D6LidH0mCgXzCjZBXW5HuZBTLVvUDNqDtd6HElosgjevktks5e09iRU0X
                /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
                /// You can then save the result.AccessToken for future auto-connect to this user:
                m_LoginResult = FacebookService.Login("361826995145957", /// (desig patter's "Design Patterns Course App 2.4" app)

                    "public_profile",
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
                    "user_hometown"
                    );
                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    m_TabsManager.LoggedInUser = m_LoggedInUser;
                    fetchUserBasicInfo();
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage);
                }

            }
        }
        private void fetchUserBasicInfo()
        {
            fetchUserProfilePhoto();
            fetchUserCoverPhoto();
            fetchUserName();
            fetchUserPosts();
        }

        // since Cover property is broken we are using PhotosTaggedIn
        private void fetchUserCoverPhoto()
        {
            try
            {
                if (m_LoggedInUser.PhotosTaggedIn != null)
                {
                    if (m_LoggedInUser.PhotosTaggedIn[1] != null)
                    {
                        coverPhoto.LoadAsync(m_LoggedInUser.PhotosTaggedIn[1].PictureNormalURL);
                    }
                }
            }
            finally
            {
                // delete later 
            }
        }

        private void fetchUserPosts()
        {
            m_TabsManager.LoadTab(userPostsList.Name, userPostsList);
        }

        private void fetchUserName()
        {
            StringBuilder userName = new StringBuilder();
            userName.Append(m_LoggedInUser.FirstName);
            userName.Append(" ");
            userName.Append(m_LoggedInUser.LastName);
            userNamePresentation.Text = userName.ToString();
        }

        private void fetchUserProfilePhoto()
        {
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private Dictionary<string, object> loadObjectsToinit(string i_TabName)
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(i_TabName);
            Dictionary<string, object> objectsToInit= getObjectsByTab(tab);
            return objectsToInit;
        }

        private Dictionary<string, object> getObjectsByTab(Tab i_Tab)
        {
            Dictionary<string, object> objectsToinit = new Dictionary<string, object>();
            switch(i_Tab.TabType)
            {
                case Tab.eTab.AboutUser:
                    objectsToinit = buildDictionaryForAboutTab();
                    break;
            }
            return objectsToinit;
        }

        private Dictionary <string, object> buildDictionaryForAboutTab()
        {
            Dictionary<string, object> objectsToInit = new Dictionary<string, object>();
            objectsToInit.Add(birthDayBox.Name, birthDayBox);
            objectsToInit.Add(statusBox.Name, statusBox);
            objectsToInit.Add(livesInBox.Name, livesInBox);
            objectsToInit.Add(workPlacesList.Name, workPlacesList);
            objectsToInit.Add(educationList.Name, educationList);
            objectsToInit.Add(numberOfFriendsBox.Name, numberOfFriendsBox);
            objectsToInit.Add(numberOfPostsBox.Name, numberOfPostsBox);
            objectsToInit.Add(numberOfAlbumsBox.Name, numberOfAlbumsBox);
            return objectsToInit;
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            Dictionary<string, object> objectsToInit = loadObjectsToinit( e.TabPage.Name);
            m_TabsManager.LoadTab(e.TabPage.Name, objectsToInit);
        }
    }
}
