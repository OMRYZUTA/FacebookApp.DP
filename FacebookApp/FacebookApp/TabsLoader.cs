using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public class TabsLoader
    {
        public List<Tab.eTab> LoadedTabs { get; set; }
        private BreaksManager m_BreaksManager;
        private AlbumCreator albumCreator;


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
            }
        }

        private void loadUserPhotosTab(object i_ObjectToInit)
        {
            ListBox PhotosBox = i_ObjectToInit as ListBox;
            foreach(Photo photo in LoggedInUser.PhotosTaggedIn)
            {
                PhotosBox.Items.Add(photo);
            }
        }

        private void loadFriendsListTab(object i_ObjectToInit)
        {
            ListBox friendsBox = i_ObjectToInit as ListBox;
            foreach(User friend in LoggedInUser.Friends)
            {
                friendsBox.Items.Add(friend.Name);
            }
            LoadedTabs.Add(Tab.eTab.FriendsList);
        }

        private void loadAboutUserTab(object i_ObjectsToInit)
        {
            Dictionary<string, object> objectsToInit = i_ObjectsToInit as Dictionary<string, object>;
            (objectsToInit["birthDayBox"] as TextBox).Text = LoggedInUser.Birthday;
            (objectsToInit["statusBox"] as TextBox).Text = "Single"; //LoggedInUser.Statuses[0].ToString() isn't working so we replace it with our own status
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
            // since it doesn't work we implement it manually
            i_ListBox.Items.Add("Gedera High School");
            i_ListBox.Items.Add("MTA");
        }

        private void initWorkPlaces(ListBox i_ListBox)
        {    // since it doesn't work we implement it manually
             //foreach(WorkExperience workplace in LoggedInUser.WorkExperiences)
             //{
             //    i_ListBox.Items.Add(string.Format("{0} at {1} ",workplace.Position, workplace.Name));
             //}
            i_ListBox.Items.Add("Tech lead at Google");
            i_ListBox.Items.Add("Tech lead at Facebook");
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
