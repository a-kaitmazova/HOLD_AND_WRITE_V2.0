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
    public partial class DeleteChar : Form
    {
        public DeleteChar()
        {
            InitializeComponent();
            listCharacters.Items.AddRange(NameList());
        }

        private void DeletChar_Click(object sender, EventArgs e)
        {
            if (listCharacters.SelectedItem != null)
            {
                File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + listCharacters.SelectedItem.ToString());
                MessageBox.Show("Карточка персонажа " + listCharacters.SelectedItem.ToString() + " удалена!", "Удаление", MessageBoxButtons.OK);
                listCharacters.Items.Clear();
                listCharacters.Items.AddRange(NameList());
            }
        }

        private void CancelDeleteChar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] NameList()
        {
            List<string> namesList = new List<string>();
            foreach (var e in Directory.GetFiles(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters]))
            {
                namesList.Add(e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters].Length + 1));
            }
            return namesList.ToArray();
        }
    }
}
