using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Net;

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
            m_HomeFolder.Text = "Albums Home";
            treeViewFiles.Nodes.Add(m_HomeFolder);
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                Folder newAlbum = AlbumCreator.GetAlbumWith(textBoxSelectedFriend.Text);
                m_HomeFolder.Nodes.Add(newAlbum);
                treeViewFiles.SelectedNode = m_HomeFolder;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeViewFiles_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                (e.Node as IFile).Selected = e.Node.Checked;
                if (e.Node.Nodes.Count > 0)
                {
                    CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                (node as IFile).Selected = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void selectAllChildren(string i_FileName, bool i_NodeChecked)
        {
            foreach (TreeNode node in m_HomeFolder.Files)
            {
                if (node.Text == i_FileName)
                {
                    node.Checked = i_NodeChecked;
                }
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = fbd.SelectedPath;
                m_HomeFolder.DownloadMe(selectedPath);
            }
            MessageBox.Show("Download completed");
        }

        private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node is PhotoProxy)
            {
                pictureBoxCreateAlbum.LoadAsync((e.Node as PhotoProxy).Photo.PictureNormalURL);
                createdTimeDateTimePicker.Value = (System.DateTime)(e.Node as PhotoProxy).Photo.CreatedTime;
            }
            else
            {
                pictureBoxCreateAlbum.Image = Properties.Resources.folderIcon;
            }
        }
    }
}
