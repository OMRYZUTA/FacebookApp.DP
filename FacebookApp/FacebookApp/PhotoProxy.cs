using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public class PhotoProxy : IFile
    {
        public PhotoProxy(Photo i_photo)
        {
            Photo = i_photo;
            Name = i_photo.Name;
            Selected = false;
        }
        public string Name { get; set; }
        public Photo Photo { get; set; }
        public bool Selected { get; set; }
        public void DownloadMe()
        {

        }
    }
}
