using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FormMainFacebookApp : Form
    {
        private readonly TabsLoader r_TabsLoader;
        private readonly AlbumCreator r_AlbumCreator;
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private BreaksManager m_BreakManager;

        public FormMainFacebookApp()
        {
            r_TabsLoader = new TabsLoader();
            r_AlbumCreator = new AlbumCreator();
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            m_BreakManager = new BreaksManager();
        }

        private void loginAndInit()
        {
            if (m_LoginResult == null)
            {
                /// Owner: design.patterns
                ///EAAUm6cZC4eUEBALVbi9bZAb5VFs1ebDkmva0uhzXkgRRlMY8YVVBEjoJRw5e6fdxnbrHezOCBpqybBCglBWxpyaFlqSu98nqSpp3yXhgcDl6YoRH6zSKMIZA3em1D6LidH0mCgXzCjZBXW5HuZBTLVvUDNqDtd6HElosgjevktks5e09iRU0X
                /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
                /// You can then save the result.AccessToken for future auto-connect to this user:
                m_LoginResult = FacebookService.Login("361826995145957",
                    /// (desig patter's "Design Patterns Course App 2.4" app)

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
                    "user_hometown");
                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    r_TabsLoader.LoggedInUser = m_LoggedInUser;
                    fetchUserBasicInfo();
                    breakManagerTimer.Start();
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
                        case eTab.Posts:
                            loadPostsTab();
                            break;
                        case eTab.AboutUser:
                            loadAboutUserTab();
                            break;
                        case eTab.FriendsList:
                            loadFriendsListTab();
                            break;
                        case eTab.UserPhotos:
                            loadUserPhotosTab();
                            break;
                        case eTab.CreateAlbum:
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
            try
            {
                r_TabsLoader.LoadTab(tab, userPostsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void displaySelectedPicture(ListBox i_PhotosList, PictureBox i_PictureBoxSelected)
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
            try
            { 
                r_AlbumCreator.CreateAlbumWith(textBoxSelectedFriend.Text, listBoxAlbumWithFriend);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxAlbumWithFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPicture(listBoxAlbumWithFriend, pictureBoxFriend);
        }

        private void saveBreakManagerSettingsButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Checked == true)
                    {
                        setNewBreaksManager(listObject);
                    }
                }
            }

            if(noBreaksButton.Checked == true)
            {
                disableBreaksPrompts();
            }
            else
            {
                startNewBreakCount();
            }
        }

        private void startNewBreakCount()
        {
            m_BreakManager.InitMinutes();
            breakManagerTimer.Start();
        }

        private void disableBreaksPrompts()
        {
            breakManagerTimer.Stop();
            m_BreakManager.InitMinutes();
            m_BreakManager.InitSeconds();
            showTimer();
        }

        private void setNewBreaksManager(object listObject)
        {
            BreaksManager i_breakManager = new BreaksManager();
            i_breakManager.m_Stopper = i_breakManager.CalculateTime((listObject as RadioButton).Name);
            m_BreakManager = i_breakManager;
        }

        private void noBreaksButton_Click(object sender, EventArgs e)
        {
            foreach (object listObject in breakManagerFeature.Controls)
            {
                if (listObject is RadioButton)
                {
                    if ((listObject as RadioButton).Font.Bold)
                    {
                        if (listObject != noBreaksButton)
                        {
                            (listObject as RadioButton).Font =
                                new Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular);
                        }
                    }
                }
            }

            if (noBreaksButton.Checked)
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

            if (fiveMinutesButton.Checked)
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

        private void breakManagerTimer_Tick(object sender, EventArgs e)
        {
            m_BreakManager.m_Seconds += 1;
            if (m_BreakManager.m_Seconds % 60 == 0)
            {
                addMinuteToTimer();
            }

            showTimer();
            if (m_BreakManager.m_Minutes == m_BreakManager.m_Stopper)
            {
                popUpTakeAbreakMessage();
            }
        }

        private void popUpTakeAbreakMessage()
        {
            breakManagerTimer.Stop();
            m_BreakManager.InitMinutes();
            MessageBox.Show("Take a break!");
            breakManagerTimer.Start();
        }

        private void addMinuteToTimer()
        {
            m_BreakManager.m_Seconds = 0;
            m_BreakManager.m_Minutes += 1;
        }

        private void showTimer()
        {
            string minutes;
            string seconds;

            if (m_BreakManager.m_Minutes < 10)
            {
                minutes = 0 + m_BreakManager.m_Minutes.ToString();
            }
            else
            {
                minutes = m_BreakManager.m_Minutes.ToString();
            }

            if (m_BreakManager.m_Seconds < 10)
            {
                seconds = 0 + m_BreakManager.m_Seconds.ToString();
            }
            else
            {
                seconds = m_BreakManager.m_Seconds.ToString();
            }

            timerPresentation.Text = minutes + ":" + seconds;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            r_AlbumCreator.DownloadPhotos(listBoxAlbumWithFriend);
        }
    }
}
