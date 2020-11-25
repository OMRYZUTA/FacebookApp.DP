using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookApp
{
    public partial class FormMainFacebookApp : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private readonly TabsLoader r_TabsLoader;
        private readonly AlbumCreator r_AlbumCreator;

        public FormMainFacebookApp()
        {
            r_TabsLoader = new TabsLoader();
            r_AlbumCreator = new AlbumCreator();
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
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
                    r_TabsLoader.LoggedInUser = m_LoggedInUser;
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
            loadPostsTab();
        }

        // since Cover property is broken we are using PhotosTaggedIn
        private void fetchUserCoverPhoto()
        {
            if (m_LoggedInUser.PhotosTaggedIn?[1] != null)
            {
                coverPhoto.LoadAsync(m_LoggedInUser.PhotosTaggedIn[1].PictureNormalURL);
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

        private void buttonLogin_Click(object i_Sender, EventArgs i_EventArgs)
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

        private void tabControlMain_Selected(object i_Sender, TabControlEventArgs i_EventArgs)
        {
            if (m_LoggedInUser != null)
            {
                Tab tab = new Tab();
                tab.ConvertStringToEnum(i_EventArgs.TabPage.Name);
                if (!r_TabsLoader.IsTabLoaded(tab))
                {
                    switch (tab.TabType)
                    {
                        case Tab.eTab.Posts:
                            loadPostsTab();
                            break;
                        case Tab.eTab.AboutUser:
                            loadAboutUserTab();
                            break;
                        case Tab.eTab.FriendsList:
                            loadFriendsListTab();
                            break;
                        case Tab.eTab.UserPhotos:
                            loadUserPhotosTab();
                            break;
                        case Tab.eTab.CreateAlbum:
                            loadCreateAlbumTab();
                            break;
                    }
                }
            }
        }

        private void loadCreateAlbumTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(createAlbumFeature.Name);
            r_TabsLoader.LoadTab(tab, r_AlbumCreator);
        }

        private void loadUserPhotosTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabUserPhotos.Name);
            r_TabsLoader.LoadTab(tab, photosListBox);
        }

        private void loadFriendsListTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabFriendsList.Name);
            r_TabsLoader.LoadTab(tab, friendsListBox);
        }

        private void loadPostsTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabUserPosts.Name);
            r_TabsLoader.LoadTab(tab, userPostsList);
        }

        private void loadAboutUserTab()
        {
            Tab tab = new Tab();
            tab.ConvertStringToEnum(tabAboutUser.Name);
            Dictionary<string, object> objectsToInit = buildDictionaryForAboutTab();
            r_TabsLoader.LoadTab(tab, objectsToInit);
        }

        private void photosListBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            displaySelectedPicture(photosListBox, pictureBoxSelected);
        }

        private void displaySelectedPicture(ListBox i_PhotosList , PictureBox i_PictureBoxSelected)
        {
            if (i_PhotosList.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = i_PhotosList.SelectedItem as Photo;
                if (selectedPhoto != null && selectedPhoto.PictureAlbumURL != null)
                {
                    i_PictureBoxSelected.LoadAsync(selectedPhoto.PictureNormalURL);
                }
            }
        }

        private void buttonSelectedFriend_Click(object i_Sender, EventArgs i_EventArgs)
        {
            r_AlbumCreator.CreateAlbumWith(textBoxSelectedFriend.Text, listBoxAlbumWithFriend);
        }

        private void listBoxAlbumWithFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPicture(listBoxAlbumWithFriend, pictureBoxFriend);
        }

        private void saveBreakManagerSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void noBreaksButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Font.Bold == true)
                    {
                        if (listObject != noBreaksButton)
                        {
                            (listObject as RadioButton).Font =
                                new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular);
                        }
                    }
                }
            }
            if (noBreaksButton.Checked == true)
            {
                Font newBoldFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
                noBreaksButton.Font = newBoldFont;
            }
        }

        private void fiveMinutesButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Font.Bold == true)
                    {
                        if (listObject != fiveMinutesButton)
                        {
                            (listObject as RadioButton).Font =
                                new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular);
                        }
                    }
                }
            }
            if (fiveMinutesButton.Checked == true)
            {
                Font newBoldFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
                fiveMinutesButton.Font = newBoldFont;
            }
        }

        private void tenMinutesButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Font.Bold == true)
                    {
                        if (listObject != tenMinutesButton)
                        {
                            (listObject as RadioButton).Font =
                                new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular);
                        }
                    }
                }
            }
            if (tenMinutesButton.Checked == true)
            {
                Font newBoldFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
                tenMinutesButton.Font = newBoldFont;
            }
        }

        private void fifteenMinutesButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Font.Bold == true)
                    {
                        if (listObject != fifteenMinutesButton)
                        {
                            (listObject as RadioButton).Font =
                                new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular);
                        }
                    }
                }
            }
            if (fifteenMinutesButton.Checked == true)
            {
                Font newBoldFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
                fifteenMinutesButton.Font = newBoldFont;
            }
        }

        private void oneHourButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Font.Bold == true)
                    {
                        if (listObject != oneHourButton)
                        {
                            (listObject as RadioButton).Font =
                                new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular);
                        }
                    }
                }
            }
            if (oneHourButton.Checked == true)
            {
                Font newBoldFont = new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Bold);
                oneHourButton.Font = newBoldFont;
            }
        }
    }
}
