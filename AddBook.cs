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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books] + @"\" + textBoxBookName.Text))
                Directory.CreateDirectory(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books] + @"\" + textBoxBookName.Text);
            else
                MessageBox.Show("Книга с таким именем уже существует. Придумайте что-нибудь другое.", "Уже есть!", MessageBoxButtons.OK);
            this.Close();
        }

        private void CancelBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
