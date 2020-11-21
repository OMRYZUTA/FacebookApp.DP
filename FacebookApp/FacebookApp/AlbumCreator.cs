using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookApp
{
    public class AlbumCreator
    {
        List<Album> createdAlbums;
        User m_LoggedInUser;
        public AlbumCreator()
        {

        }

        public void CreateAlbumWith(string i_FriendName)
        {
            bool isFriendInList = isFriendInLoggedInUserList(i_FriendName);
            if (isFriendInList)
            {
                bool isAlbumExist = isAlbumCreated(i_FriendName);
                if (!isAlbumExist)
                {
                    generateNewAlbum(i_FriendName);
                }
            }
        }

        private bool isAlbumCreated(string i_FriendName)
        {
            bool result = false;
            foreach (Album album in createdAlbums)
            {
                if (album.Name == i_FriendName)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void generateNewAlbum(string i_FriendName)
        {
            throw new NotImplementedException();
        }

        private bool isFriendInLoggedInUserList(string i_FriendName)
        {
           bool result = false;
            foreach(User friend in m_LoggedInUser.Friends)
            {
                if(friend.Name == i_FriendName)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}