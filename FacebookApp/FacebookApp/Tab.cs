using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public class Tab
    {
        public eTab TabType { get; private set; }
        const string k_Posts = "userPostsList";
        const string k_AboutUser = "tabAboutUser";
        public Tab()
        {
            TabType = eTab.None;
        }

        public enum eTab
        {
            Posts = 0,
            AboutUser,
            FriendsList,
            UserPhotos,
            None
        }

        public void ConvertStringToEnum(string i_TabName)
        {
            switch (i_TabName)
            {
                case k_Posts:
                    TabType = eTab.Posts;
                    break;
                case k_AboutUser:
                    TabType = eTab.AboutUser;
                    break;
            }
        }
    }
}
