using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public class PhotoAdapter :  TreeNode, IFile
    {
        public PhotoAdapter(Photo i_photo)
        {
            Photo = i_photo;
            Name = i_photo.Name;
            Selected = false;
        }
        public Photo Photo { get; set; }
        public bool Selected { get; set; }
        private const string FileName = "Photo.jpg";
        public void DownloadMe(string i_Path)
        {
            using (WebClient client = new WebClient())
            {
                int i = 1;
                StringBuilder sb_fileName = new StringBuilder();

                string imageURL = Photo.PictureNormalURL;
                sb_fileName.Append(i_Path);
                sb_fileName.Append("\\");
                sb_fileName.Append(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
                sb_fileName.Append(i.ToString());
                sb_fileName.Append(Photo.Id);
                sb_fileName.Append(FileName);
                client.DownloadFile(imageURL, sb_fileName.ToString());
                sb_fileName.Clear();
            }
        }
    }
}
