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

        private List<User> m_FriendsWithAlbums;
        public User LoggedInUser { get; set; }

        public AlbumCreator()
        {
            m_FriendsWithAlbums = new List<User>();
        }


        public Folder GetAlbumWith(string i_FriendName)
        {
            Folder newAlbum = new Folder();
            User friend = getFriendFromUser(i_FriendName);
            if (friend !=null)
            {
                if (isFriendInCollection(i_FriendName, m_FriendsWithAlbums))
                {
                    throw new Exception("Friend's Album is already exists. please try another friend name");
                }
                else
                {
                    
                    newAlbum =generateNewAlbum(friend);
                }
            }
            else
            {
                throw new Exception("Friend doesn't exist. please type correctly the friend name");
            }
            return newAlbum;
        }

        private User getFriendFromUser(string i_FriendName)
        {
            User userFriend = null;

            foreach (User friend in LoggedInUser.Friends)
            {
                if (friend.Name == i_FriendName)
                {
                    userFriend = friend;
                    break;
                }
            }
            return userFriend;
        }

        private Folder generateNewAlbum(User Friend)
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
                        newAlbum.Name = string.Format("{0}'s Album", Friend.Name);
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            if (tag.User.Name == Friend.Name)
                            {
                                newAlbum.AddChild(new PhotoAdapter(photo));
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
                newAlbum.Text = string.Format("{0}'s Album", Friend.Name);
                for (int i = 0; i < 10; i++)
                {
                    PhotoAdapter photo = new PhotoAdapter(LoggedInUser.PhotosTaggedIn[i]);
                    if (string.IsNullOrEmpty(photo.Name))
                    {
                        photo.Text=photo.Photo.From.Name;
                    }
                    else
                    {
                        photo.Text = photo.Photo.Name;
                    }
                    newAlbum.Nodes.Add(photo);
                }
              
                m_FriendsWithAlbums.Add(Friend);
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
    }
}