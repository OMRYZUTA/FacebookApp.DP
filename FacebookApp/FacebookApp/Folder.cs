using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public class Folder : TreeNode, IFile, IEnumerable<IFile>
    {
        public List<IFile> Files { get; set; }
        private bool m_IsSelected;

        public Folder()
        {
            Files = new List<IFile>();
            m_IsSelected = false;
        }
        public bool Selected
        {
            get
            {
                return m_IsSelected;
            }
            set
            {
                m_IsSelected = true;
                if (value)
                {
                    if (Files.Count > 0)
                    {
                        foreach (IFile file in Files)
                        {
                            file.Selected = true;
                        }
                    }
                }
            }
        }
        public void DownloadMe(string i_Path)
        {
            string path = i_Path;
            // need to create here new folder
            if (Checked)
            {
                path = i_Path +string.Format("\\{0}",Text);
                Directory.CreateDirectory(path);
            }
            foreach (TreeNode file in Nodes)
            {
                if (file.Checked)
                {
                    (file as IFile).DownloadMe(path);
                }
            }
        }
        public void AddChild(IFile i_file)
        {
            Files.Add(i_file);
        }

        public IEnumerator<IFile> GetEnumerator()
        {
            return Files.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Files.GetEnumerator();
        }
    }
}
