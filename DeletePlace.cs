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
    public partial class DeletePlace : Form
    {
        public DeletePlace()
        {
            InitializeComponent();

            listPlaces.Items.AddRange(NameList());
        }

        private void buttonDeletePlace_Click(object sender, EventArgs e)
        {
            if (listPlaces.SelectedItem != null)
            {
                File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places] + @"\" + listPlaces.SelectedItem.ToString());
                MessageBox.Show("Карточка места " + listPlaces.SelectedItem.ToString() + " удалена!", "Удаление", MessageBoxButtons.OK);
                listPlaces.Items.Clear();
                listPlaces.Items.AddRange(NameList());
            }
        }

        private void buttonCancelDeletePlace_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] NameList()
        {
            List<string> namesList = new List<string>();
            foreach (var e in Directory.GetFiles(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places]))
            {
                namesList.Add(e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places].Length + 1));
            }
            return namesList.ToArray();
        }
    }
}
