using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FileSystem : UserControl
    {
        public AlbumCreator AlbumCreator { get; set; }
        private Folder m_HomeFolder;
        public FileSystem()
        {
            InitializeComponent();
            m_HomeFolder = new Folder();
            m_HomeFolder.Name = "Albums Home";
            treeViewFiles.Nodes.Add(m_HomeFolder.Name);
        }


        private void listBoxAlbumWithFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaySelectedPicture(listBoxAlbumWithFriend, pictureBoxFriend);
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                Folder newAlbum = AlbumCreator.GetAlbumWith(textBoxSelectedFriend.Text);
                m_HomeFolder.AddChild(newAlbum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
