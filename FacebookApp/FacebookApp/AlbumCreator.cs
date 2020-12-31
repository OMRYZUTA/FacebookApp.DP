using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class AlbumCreator
    {
        private const string FileName = "Photo.jpg";


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
                throw new Exception("Friend doesn't exist. please type correctly the friend name");
            }
        }

        private void generateNewAlbum(string i_FriendName, object i_ObjectToInit)
        {
            ListBox photosBox = i_ObjectToInit as ListBox;

            // since it doesn't work we implement it manually
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
                                if (photosBox != null)
                                {
                                    photosBox.Items.Add(photo);
                                }
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
                for (int i = 0; i < 10; i++)
                {
                    photosBox?.Items.Add(this.LoggedInUser.PhotosTaggedIn[i]);
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