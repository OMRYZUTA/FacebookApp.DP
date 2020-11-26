namespace FacebookApp
{
    public class Tab
    {
        public TabsEnum.eTab TabType { get; private set; }
        const string k_Posts = "tabUserPosts";
        const string k_AboutUser = "tabAboutUser";
        const string k_FriendsList = "tabFriendsList";
        const string k_UserPhotos = "tabUserPhotos";
        const string k_CreateAlbum = "createAlbumFeature";

        public Tab()
        {
            TabType = TabsEnum.eTab.None;
        }



        public void ConvertStringToEnum(string i_TabName)
        {
            switch (i_TabName)
            {
                case k_Posts:
                    TabType = TabsEnum.eTab.Posts;
                    break;
                case k_AboutUser:
                    TabType = TabsEnum.eTab.AboutUser;
                    break;
                case k_FriendsList:
                    TabType = TabsEnum.eTab.FriendsList;
                    break;
                case k_UserPhotos:
                    TabType = TabsEnum.eTab.UserPhotos;
                    break;
                case k_CreateAlbum:
                    TabType = TabsEnum.eTab.CreateAlbum;
                    break;
            }
        }
    }
}
