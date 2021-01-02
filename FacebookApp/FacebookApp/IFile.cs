using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public interface IFile
    {
        bool Selected { get; set; }
        void DownloadMe();
        string Name { get; set; }
    }
}
