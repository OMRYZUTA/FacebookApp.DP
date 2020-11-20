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
            requestTabManagerToLoadPostsTab();
        }

        // since Cover property is broken we are using PhotosTaggedIn
        private void fetchUserCoverPhoto()
        {
            if (m_LoggedInUser.PhotosTaggedIn != null)
            {
                if (m_LoggedInUser.PhotosTaggedIn[1] != null)
                {
                    coverPhoto.LoadAsync(m_LoggedInUser.PhotosTaggedIn[1].PictureNormalURL);
                }
            }
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





        private Dictionary<string, object> buildDictionaryForAboutTab()
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
            if (m_LoggedInUser != null)
            {
                Tab tab = new Tab();
                tab.ConvertStringToEnum(e.TabPage.Name);
                if (!m_TabsManager.IsTabLoaded(tab))
                {
                    switch (tab.TabType)
                    {
                        case Tab.eTab.Posts:
                            requestTabManagerToLoadAboutUserTab();
                            break;
                        case Tab.eTab.AboutUser:
                            requestTabManagerToLoadAboutUserTab();
                            break;
                        case Tab.eTab.FriendsList:
                            requestTabManagerToLoadFriendsListTab();
                            break;
                        case Tab.eTab.UserPhotos:
                            requestTabManagerToLoadUserPhotosTab();
                            break;
                    }
                }
            }
        }

        private void requestTabManagerToLoadUserPhotosTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabUserPhotos.Name);
            m_TabsManager.LoadTab(tab, photosListBox);
        }

        private void requestTabManagerToLoadFriendsListTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabFriendsList.Name);
            m_TabsManager.LoadTab(tab, friendsListBox);
        }

        private void requestTabManagerToLoadPostsTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabUserPosts.Name);
            m_TabsManager.LoadTab(tab, userPostsList);
        }

        private void requestTabManagerToLoadAboutUserTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabAboutUser.Name);
            Dictionary<string, object> objectsToInit = buildDictionaryForAboutTab();
            m_TabsManager.LoadTab(tab, objectsToInit);
        }

        private void photosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPicture();
        }

        private void displaySelectedPicture()
        {
            if (photosListBox.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = photosListBox.SelectedItem as Photo;
                if (selectedPhoto.PictureAlbumURL != null)
                {
                    pictureBoxSelected.LoadAsync(selectedPhoto.PictureNormalURL);
                }
            }
        }
    }
}
