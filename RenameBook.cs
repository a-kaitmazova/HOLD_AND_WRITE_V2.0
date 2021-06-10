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
    public partial class RenameBook : Form
    {
        public RenameBook()
        {
            InitializeComponent();

            SetListBox();
        }

        private void RenameBook_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books] + @"\" + textRenameBookName.Text);
            Directory.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books] + @"\" + listBooks.Items[listBooks.SelectedIndex].ToString());
            listBooks.Items.Clear();
            SetListBox();
        }

        private void CancelBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetListBox()
        {
            foreach(var e in Directory.GetDirectories(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]))
            {
                listBooks.Items.Add(e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books].Length + 1));
            }   
        }

        private void SelectedBookName(object sender, EventArgs e)
        {
            textRenameBookName.Text = listBooks.Items[listBooks.SelectedIndex].ToString();
        }
    }
}
