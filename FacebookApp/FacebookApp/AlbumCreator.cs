using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class AlbumCreator
    {
        private const string FileName = "Photo.jpg";
        private List<User> m_FriendsWithAlbums;
        private Folder m_MainFolder = new Folder();
        public User LoggedInUser { get; set; }

        public AlbumCreator()
        {
            m_MainFolder = new Folder();
            m_FriendsWithAlbums = new List<User>();
        }


        public Folder GetAlbumWith(string i_FriendName)
        {
            Folder newAlbum = new Folder();
            if (isFriendInCollection(i_FriendName, LoggedInUser.Friends))
            {
                if (isFriendInCollection(i_FriendName, m_FriendsWithAlbums))
                {
                    throw new Exception("Friend's Album is already exists. please try another friend name");
                }
                else
                {
                    newAlbum =generateNewAlbum(i_FriendName);
                }
            }
            else
            {
                throw new Exception("Friend doesn't exist. please type correctly the friend name");
            }
            return newAlbum;
        }

        private Folder generateNewAlbum(string i_FriendName)
        {
            Folder newAlbum = new Folder();

            // since it doesn't work we implement it manually
            try
            {
                foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
                {
                    if (photo.Tags != null)
                    {
                        newAlbum = new Folder();
                        newAlbum.Name = string.Format("{0}'s Album", i_FriendName);
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            if (tag.User.Name == i_FriendName)
                            {
                                newAlbum.AddChild(new PhotoProxy(photo));
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Tags property returned null");
                    }
                }
            }
            catch (Exception ex)
            {
                newAlbum = new Folder();
                newAlbum.Name = string.Format("{0}'s Album", i_FriendName);
                for (int i = 0; i < 10; i++)
                {
                    newAlbum.AddChild(new PhotoProxy(LoggedInUser.PhotosTaggedIn[i]));
                }
            }
            return newAlbum;
        }

        private bool isFriendInCollection(string i_FriendName, IEnumerable<User> i_Collection)
        {
            bool result = false;

            foreach (User friend in i_Collection)
            {
                if (friend.Name == i_FriendName)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }


        public void DownloadPhotos(ListBox i_PhotosList)
        {
            using (WebClient client = new WebClient())
            {
                int i = 1;
                StringBuilder sb_fileName = new StringBuilder();

                foreach (object item in i_PhotosList.Items)
                {
                    Photo photo = (item as Photo);
                    string imageURL = photo.PictureNormalURL;
                    sb_fileName.Append(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
                    sb_fileName.Append(i.ToString());
                    sb_fileName.Append(FileName);
                    client.DownloadFile(imageURL, sb_fileName.ToString());
                    sb_fileName.Clear();
                }
            }
        }
    }
}