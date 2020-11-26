using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookApp
{
    public class AlbumCreator
    {
        public User LoggedInUser { get; set; }

        public void CreateAlbumWith(string i_FriendName, object i_ObjectToInit)
        {
            bool isFriendInList = isFriendInLoggedInUserList(i_FriendName);

            if (isFriendInList)
            {
                generateNewAlbum(i_FriendName, i_ObjectToInit);
            }
            else
            {
                MessageBox.Show("Friend doesn't exist please type correctly the friend name");
            }
        }

        private void generateNewAlbum(string i_FriendName, object i_ObjectToInit)
        {
            ListBox photosBox = i_ObjectToInit as ListBox;

            try
            {
                foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
                {
                    if (photo.Tags != null)
                    {
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            if (tag.User.Name == i_FriendName)
                            {
                                photosBox.Items.Add(photo);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Tags property returned null");
                    }
                }
            }
            // since it doesn't work we implement it manually
            catch (Exception ex)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (photosBox != null)
                    {
                        photosBox.Items.Add(LoggedInUser.PhotosTaggedIn[i]);
                    }
                }
            }
        }

        private bool isFriendInLoggedInUserList(string i_FriendName)
        {
            bool result = false;

            foreach (User friend in LoggedInUser.Friends)
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