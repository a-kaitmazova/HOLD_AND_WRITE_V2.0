﻿using System;
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
    public partial class HoldAndWrite : Form
    {
        public static ImageList images = new ImageList();

        public static string[] foldersNames = { "Книги", "Места", "Персонажи", "Предметы"};
        public static string[] foldersKeys = { "book", "place", "charscter", "item" };
        public static string directory = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().IndexOf("bin")) + "Hold&Write";

        public static string[] textNote;
        public static string[] textSyn;

        public enum MainFolders
        {
            Books, Places, Characters, Items
        }

        public HoldAndWrite()
        {
            InitializeComponent();

            SetImageList();
            TreeView.ImageList = images;

            SetFolderSystem();
            SetTreeView();

            TreeView.ExpandAll();

            Notepad.Font = new Font("Segoe UI", 14);
        }

        //-------------------------------------------------------------------------------------

        public void OpenFile(object sender, TreeViewEventArgs e)
        {
            if (TreeView.SelectedNode.Text.Contains(".txt"))//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            {
                Notepad.LoadFile(TreeView.SelectedNode.Name, RichTextBoxStreamType.PlainText);
                Synopsis.Text = File.ReadAllText(TreeView.SelectedNode.Name.Replace(TreeView.SelectedNode.Text, "@_" + TreeView.SelectedNode.Text));
            }
        }

        //-------------------------------------------------------------------------------------
        public void SetFolderSystem()
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                foreach (var e in foldersNames)
                {
                    Directory.CreateDirectory(directory + @"\" + e);
                }
            }
            else
            {
                foreach (var e in foldersNames)
                {
                    if (!Directory.Exists(directory + @"\" + e))
                        Directory.CreateDirectory(directory + @"\" + e);
                }
            }
        }

        public void SetTreeView()
        {
            TreeView.BeginUpdate();

            TreeView.Nodes.Add(GetNode(foldersKeys[(int)MainFolders.Books], foldersNames[(int)MainFolders.Books]));
            TreeView.Nodes.Add(GetNode(foldersKeys[(int)MainFolders.Places], foldersNames[(int)MainFolders.Places]));
            TreeView.Nodes.Add(GetNode(foldersKeys[(int)MainFolders.Characters], foldersNames[(int)MainFolders.Characters]));
            TreeView.Nodes.Add(GetNode(foldersKeys[(int)MainFolders.Items], foldersNames[(int)MainFolders.Items]));

            TreeView.Sort();
            
            TreeView.EndUpdate();
        }

        public TreeNode GetNode(string key, string mainFolderName)
        {
            TreeNode motherNode = new TreeNode();
            if (Directory.GetDirectories(directory + @"\" + mainFolderName).Length > 0)
            {
                foreach (var e in Directory.GetDirectories(directory + @"\" + mainFolderName))
                {
                    motherNode.Nodes.Add(GetFileNodes(directory + @"\" + mainFolderName, 
                                                              e.Substring(e.IndexOf(mainFolderName) + mainFolderName.Length + 1)));
                }
            }
            motherNode.Text = mainFolderName;
            motherNode.Name = directory + @"\" + mainFolderName;
            switch(mainFolderName)
            {
                case "Персонажи": motherNode.SelectedImageIndex = motherNode.ImageIndex = 6; break;
                case "Места": motherNode.SelectedImageIndex = motherNode.ImageIndex = 4; break;
                case "Предметы": motherNode.SelectedImageIndex = motherNode.ImageIndex = 5; break;
                default: motherNode.ImageIndex = 0; break;            
            }
            return motherNode;
        }

        public TreeNode GetFileNodes(string path, string folderName)
        {
            TreeNode node = new TreeNode();
            if (Directory.GetFiles(path + @"\" + folderName).Length > 0)
            {
                foreach (var e in Directory.GetFiles(path + @"\" + folderName))
                {
                    if (e.IndexOf("@_") < 0)
                    {
                        TreeNode temp = new TreeNode();
                        temp.Text = e.Substring(e.IndexOf(folderName) + folderName.Length + 1);
                        temp.Name = e;
                        temp.ImageIndex = 2;
                        temp.SelectedImageIndex = 2;
                        node.Nodes.Add(temp);
                    }
                }
            }
            node.Text = folderName;
            node.Name = path + @"\" + folderName;
            if (path.Contains("Книги"))
            {
                node.ImageIndex = 3;
                node.SelectedImageIndex = 3;
            }
            else
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
            return node;
        }

        public void SetImageList()
        {
            images.Images.Add(Properties.Resources.main_folder); //0
            images.Images.Add(Properties.Resources.char_folder); //1
            images.Images.Add(Properties.Resources.list);        //2
            images.Images.Add(Properties.Resources.book);        //3
            images.Images.Add(Properties.Resources.castle);      //4
            images.Images.Add(Properties.Resources.sword);       //5
            images.Images.Add(Properties.Resources._char);       //6
            

        }

        //------------------------------------------------------------------------

        private void CreateBook(object sender, EventArgs e)
        {
            AddBook newBook = new AddBook();
            newBook.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();
        }

        private void RenameBook(object sender, EventArgs e)
        {
            RenameBook renameBook = new RenameBook();
            renameBook.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();
        }

        private void DeleteBook(object sender, EventArgs e)
        {
            DeleteBook delBook = new DeleteBook();
            delBook.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();
        }

        //-----------------------------------------------------------------------------

        private void CreateFile(object sender, EventArgs e)
        {
            CreateFile newFile = new CreateFile();
            newFile.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();

        }

        private void RenameFile(object sender, EventArgs e)
        {
            RenameFilecs renFile = new RenameFilecs();
            renFile.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();
        }

        private void DeleteFile(object sender, EventArgs e)
        {
            DeleteFile delFile = new DeleteFile();
            delFile.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            textNote = Notepad.Lines;
            textSyn = Synopsis.Lines;

            SaveFile sFile = new SaveFile();
            sFile.ShowDialog();

            TreeView.Nodes.Clear();

            SetTreeView();

            TreeView.ExpandAll();

        }

        //-------------------------------------------------------------------------------------

        private void CreateChar(object sender, EventArgs e)
        {

        }

        private void ChangeChar(object sender, EventArgs e)
        {

        }

        private void DeleteChar(object sender, EventArgs e)
        {

        }
    }
}
