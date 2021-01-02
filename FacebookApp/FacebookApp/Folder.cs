using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    public class Folder : IFile
    {
        public List<IFile> Files { get; set;}
        public string Name { get; set; }

        public Folder()
        {
            Files = new List<IFile>();
        }
        public bool Selected { get; set; }
        public void DownloadMe()
        {
            foreach (IFile file in Files)
            {
                file.DownloadMe();
            }
        }
        public void AddChild(IFile i_file)
        {
            Files.Add(i_file);
        }
    }
}
