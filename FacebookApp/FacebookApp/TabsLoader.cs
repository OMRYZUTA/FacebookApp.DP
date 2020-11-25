using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookApp
{
    public class TabsLoader
    {
        public List<Tab.eTab> LoadedTabs { get; set; }

        public User LoggedInUser { get; set; }

        public TabsLoader()
        {
            LoadedTabs = new List<Tab.eTab>();
        }

        public bool IsTabLoaded(Tab i_Tab)
        {
            bool result = LoadedTabs.Contains(i_Tab.TabType);
            return result;
        }

        public void LoadTab(Tab i_Tab, object i_ObjectToInit)
        {
            switch (i_Tab.TabType)
            {
                case Tab.eTab.Posts:
                    loadPostsTab(i_ObjectToInit);
                    break;
                case Tab.eTab.AboutUser:
                    loadAboutUserTab(i_ObjectToInit);
                    break;
                case Tab.eTab.FriendsList:
                    loadFriendsListTab(i_ObjectToInit);
                    break;
                case Tab.eTab.UserPhotos:
                    loadUserPhotosTab(i_ObjectToInit);
                    break;
                case Tab.eTab.CreateAlbum:
                    loadAlbumCreator(i_ObjectToInit);
                    break;
            }
        }

        private void loadAlbumCreator(object i_ObjectToInit)
        {
            AlbumCreator albumCreator = i_ObjectToInit as AlbumCreator;
            albumCreator.LoggedInUser = LoggedInUser;
            LoadedTabs.Add(Tab.eTab.CreateAlbum);
        }

        private void loadUserPhotosTab(object i_ObjectToInit)
        {
            ListBox photosBox = i_ObjectToInit as ListBox;
            foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
            {
                photosBox.Items.Add(photo);
            }
        }

        private void loadFriendsListTab(object i_ObjectToInit)
        {
            ListBox friendsBox = i_ObjectToInit as ListBox;
            foreach (User friend in LoggedInUser.Friends)
            {
                friendsBox.Items.Add(friend.Name);
            }
            LoadedTabs.Add(Tab.eTab.FriendsList);
        }

        private void loadAboutUserTab(object i_ObjectsToInit)
        {
            Dictionary<string, object> objectsToInit = i_ObjectsToInit as Dictionary<string, object>;
            (objectsToInit["birthDayBox"] as TextBox).Text = LoggedInUser.Birthday;
            try
            {
                (objectsToInit["genderBox"] as TextBox).Text = LoggedInUser.Gender.ToString();
            }
            catch (Exception ex)
            {
            }

            (objectsToInit["livesInBox"] as TextBox).Text = LoggedInUser.Location.Name;
            initWorkPlaces((objectsToInit["workPlacesList"]) as ListBox);
            initEducationPlaces((objectsToInit["educationList"] as ListBox));
            (objectsToInit["numberOfFriendsBox"] as RichTextBox).Text = LoggedInUser.Friends.Count.ToString();
            (objectsToInit["numberOfPostsBox"] as RichTextBox).Text = LoggedInUser.Posts.Count.ToString();
            (objectsToInit["numberOfAlbumsBox"] as RichTextBox).Text = LoggedInUser.Albums.Count.ToString();
            LoadedTabs.Add(Tab.eTab.AboutUser);
        }

        private void initEducationPlaces(ListBox i_ListBox)
        {
            try
            {
                foreach (WorkExperience workPlace in LoggedInUser.WorkExperiences)
                {
                    i_ListBox.Items.Add(workPlace.Description);
                }
            }
            // since it doesn't work we implement it manually
            catch (Exception ex)
            {
                i_ListBox.Items.Add("Gedera High School");
                i_ListBox.Items.Add("MTA");
            }
        }

        private void initWorkPlaces(ListBox i_ListBox)
        {
            try
            {
                foreach (WorkExperience workplace in LoggedInUser.WorkExperiences)
                {
                    i_ListBox.Items.Add(string.Format("{0} at {1} ", workplace.Position, workplace.Name));
                }
            }
            catch (Exception ex)
            {
                // since it doesn't work we implement it manually
                i_ListBox.Items.Add("Tech lead at Google");
                i_ListBox.Items.Add("Tech lead at Facebook");
            }
        }

        private void loadPostsTab(object i_UserPostsList)
        {
            ListBox userPostsList = i_UserPostsList as ListBox;
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    userPostsList.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    userPostsList.Items.Add(post.Caption);
                }
            }
            if (LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            LoadedTabs.Add(Tab.eTab.Posts);
        }
    }
}
