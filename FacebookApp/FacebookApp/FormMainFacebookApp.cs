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
            ListBox k;
        }

        private void fetchUserProfilePhoto()
        {
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void tabAboutUser_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, object> objectsToInit = new Dictionary<string, object>();
            loadObjectsToinit(objectsToInit);
            m_TabsManager.LoadTab(tabAboutUser.Name, objectsToInit);
        }

        private void loadObjectsToinit(Dictionary<string, object> i_ObjectsToInit)
        {
            i_ObjectsToInit.Add(birthDayBox.Name, birthDayBox);
            i_ObjectsToInit.Add(statusBox.Name, statusBox);
            i_ObjectsToInit.Add(livesIn.Name, livesIn);
            i_ObjectsToInit.Add(workPlacesList.Name, workPlacesList);
            i_ObjectsToInit.Add(educationList.Name, educationList);
            i_ObjectsToInit.Add(numberOfFriendsBox.Name, numberOfFriendsBox);
            i_ObjectsToInit.Add(numberOfPostsBox.Name, numberOfPostsBox);
            i_ObjectsToInit.Add(numberOfPhotosBox.Name, numberOfPhotosBox);
        }
    }
}
