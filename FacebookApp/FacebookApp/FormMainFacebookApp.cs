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
        private TabsLoader m_TabsLoader;
        private AlbumCreator m_AlbumCreator;

        public FormMainFacebookApp()
        {
            m_TabsLoader = new TabsLoader();
            m_AlbumCreator = new AlbumCreator();
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
                    m_TabsLoader.LoggedInUser = m_LoggedInUser;
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
            LoadPostsTab();
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
            objectsToInit.Add(genderBox.Name, genderBox);
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
                if (!m_TabsLoader.IsTabLoaded(tab))
                {
                    switch (tab.TabType)
                    {
                        case Tab.eTab.Posts:
                            LoadPostsTab();
                            break;
                        case Tab.eTab.AboutUser:
                            LoadAboutUserTab();
                            break;
                        case Tab.eTab.FriendsList:
                            LoadFriendsListTab();
                            break;
                        case Tab.eTab.UserPhotos:
                            LoadUserPhotosTab();
                            break;
                        case Tab.eTab.CreateAlbum:
                            LoadCreateAlbumTab();
                            break;
                    }
                }
            }
        }

        private void LoadCreateAlbumTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(createAlbumFeature.Name);
            m_TabsLoader.LoadTab(tab, m_AlbumCreator);
        }

        private void LoadUserPhotosTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabUserPhotos.Name);
            m_TabsLoader.LoadTab(tab, photosListBox);
        }

        private void LoadFriendsListTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabFriendsList.Name);
            m_TabsLoader.LoadTab(tab, friendsListBox);
        }

        private void LoadPostsTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabUserPosts.Name);
            m_TabsLoader.LoadTab(tab, userPostsList);
        }

        private void LoadAboutUserTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabAboutUser.Name);
            Dictionary<string, object> objectsToInit = buildDictionaryForAboutTab();
            m_TabsLoader.LoadTab(tab, objectsToInit);
        }

        private void photosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPicture(photosListBox, pictureBoxSelected);
        }

        private void displaySelectedPicture(ListBox i_PhotosList , PictureBox i_PictureBoxSelected)
        {
            if (i_PhotosList.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = i_PhotosList.SelectedItem as Photo;
                if (selectedPhoto.PictureAlbumURL != null)
                {
                    i_PictureBoxSelected.LoadAsync(selectedPhoto.PictureNormalURL);
                }
            }
        }

        private void buttonSelectedFriend_Click(object sender, EventArgs e)
        {
            m_AlbumCreator.CreateAlbumWith(textBoxSelectedFriend.Text, listBoxAlbumWithFriend);
        }

        private void listBoxAlbumWithFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPicture(listBoxAlbumWithFriend, pictureBoxFriend);
        }
    }
}
