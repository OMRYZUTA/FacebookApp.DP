using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public class TabsManager
    {
        public List<eTab> LoadedTabs { get; set; }
        private BreaksManager m_BreaksManager = null;
        private AlbumCreator albumCreator = null;

        const string k_Posts = "userPostsList";
        const string k_AboutUser = "tabAboutUser";
        public User LoggedInUser { get; set; }

        public enum eTab
        {
            Posts = 0,
            AboutUser,
            FriendsList,
            UserPhotos,
            None
        }

        public TabsManager()
        {
            LoadedTabs = new List<eTab>();
        }

        private bool isTabLoaded(string i_Tab)
        {
            eTab tabName = decipherTabName(i_Tab);
            bool result = LoadedTabs.Contains(tabName);
            return result;
        }

        private eTab decipherTabName(string i_Tab)
        {
            eTab tabName = eTab.None;
            switch (i_Tab)
            {
                case k_Posts:
                    tabName = eTab.Posts;
                    break;
            }
            return tabName;
        }

        public void LoadTab(string i_Tab, object i_ObjectToInit)
        {
            if (!isTabLoaded(i_Tab))
            {
                switch (i_Tab)
                {
                    case k_Posts:
                        loadPostsTab(i_ObjectToInit);
                        break;
                    case k_AboutUser:
                        loadAboutUserTab(i_ObjectToInit);
                        break;
                }
            }
        }

        private void loadAboutUserTab(object i_ObjectsToInit)
        {
            Dictionary<string, object> objectsToInit =i_ObjectsToInit as Dictionary<string, object>;
            (objectsToInit["birthDayBox"]as TextBox).Text = LoggedInUser.Birthday;
           //( objectsToInit["statusBox"] as TextBox).Text = LoggedInUser.Statuses.;
        }

        private void loadPostsTab(object i_UserPostsList)
        {
            LoadedTabs.Add(eTab.Posts);
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
        }
    }
}
