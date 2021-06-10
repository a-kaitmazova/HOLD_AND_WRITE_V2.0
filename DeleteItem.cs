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
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();

            listItems.Items.AddRange(NameList());
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItem != null)
            {
                File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + listItems.SelectedItem.ToString());
                MessageBox.Show("Карточка предмета " + listItems.SelectedItem.ToString() + " удалена!", "Удаление", MessageBoxButtons.OK);
                listItems.Items.Clear();
                listItems.Items.AddRange(NameList());
            }
        }

        private void buttonCanselDeleteUtem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] NameList()
        {
            List<string> namesList = new List<string>();
            foreach (var e in Directory.GetFiles(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items]))
            {
                namesList.Add(e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items].Length + 1));
            }
            return namesList.ToArray();
        }
    }
}
