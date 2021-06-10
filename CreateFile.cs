using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HOLD_AND_WRITE
{
    public partial class CreateFile : Form
    {
        public CreateFile()
        {
            InitializeComponent();

            treeViewFiles.ImageList = HoldAndWrite.images;

            SetTreeView();

            treeViewFiles.ExpandAll();
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            if (treeViewFiles.SelectedNode.ImageIndex == 1 || treeViewFiles.SelectedNode.SelectedImageIndex == 1)
            {
                if (!Directory.Exists(treeViewFiles.SelectedNode.Name + @"\" + textBoxFileName.Text))
                {
                    File.Create(treeViewFiles.SelectedNode.Name + @"\" + textBoxFileName.Text + ".txt");
                    File.Create(treeViewFiles.SelectedNode.Name + @"\" + "@_" + textBoxFileName.Text + ".txt");

                    treeViewFiles.Nodes.Clear();
                    SetTreeView();
                    treeViewFiles.ExpandAll();
                    textBoxFileName.Text = "";
                }
                else
                    MessageBox.Show("Файл с таким именем уже существует! Придумайте что-нибудь другое.", "Уже есть!", MessageBoxButtons.OK);
            }
        }
    

        private void CancelFileCreate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetTreeView()
        {
            treeViewFiles.BeginUpdate();

            treeViewFiles.Nodes.Add(GetBookNodeName(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]));

            treeViewFiles.EndUpdate();
        }

        public TreeNode GetBookNodeName(string directory)
        {
            TreeNode motherNode = new TreeNode();
            if (Directory.GetDirectories(directory).Length > 0)
            {
                foreach (var e in Directory.GetDirectories(directory))
                {
                    if (Directory.GetFiles(e).Length > 0)
                    {
                        motherNode.Nodes.Add(GetFileNames(e, e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books].Length + 1)));
                    }
                    else
                    {
                        TreeNode node = new TreeNode();
                        node.Text = e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books].Length + 1);
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                        node.Name = e;
                        motherNode.Nodes.Add(node);
                    }
                }
            }

            motherNode.ImageIndex = 0;
            motherNode.SelectedImageIndex = 0;
            motherNode.Text = "Книги";

            return motherNode;
        }

        public TreeNode GetFileNames(string path, string folderName)
        {
            TreeNode node = new TreeNode();
            foreach (var e in Directory.GetFiles(path))
            {
                if (e.IndexOf("@_") < 0)
                {
                    TreeNode temp = new TreeNode();
                    temp.Text = e.Substring(e.IndexOf(folderName) + folderName.Length + 1);
                    temp.Name = e;
                    temp.ImageIndex = 2;
                    temp.SelectedImageIndex = 2;
                    temp.Name = e;
                    node.Nodes.Add(temp);
                }
            }

            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            node.Text = folderName;
            node.Name = path;

            return node;
        }

        private void SelectFile(object sender, TreeViewEventArgs e)
        {
            if (treeViewFiles.SelectedNode.ImageIndex == 2 || treeViewFiles.SelectedNode.SelectedImageIndex == 2)
                textBoxFileName.Text = treeViewFiles.SelectedNode.Text;
        }
    }
}
