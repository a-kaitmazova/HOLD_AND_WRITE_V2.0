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
    public partial class ChangeItem : Form
    {
        public string[] card;
        public ChangeItem()
        {
            InitializeComponent();

            listItems.Items.AddRange(NameList());

            pictureWithoutCard.Visible = true;
            pictureWithoutCard.Image = Properties.Resources.sword;
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

        public void RefreshList()
        {
            listItems.Items.Clear();
            listItems.Items.AddRange(NameList());
        }

        public string[] AllCard()
        {
            List<string> s = new List<string>();
            s.Add(textBoxItemName.Text);
            foreach (var e in textBoxItem.Lines)
            {
                s.Add(e);
            }
            return s.ToArray();
        }

        private void buttonChangeItem_Click(object sender, EventArgs e)
        {
            card = AllCard();

            File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + listItems.SelectedItem.ToString());
            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + textBoxItemName.Text))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + textBoxItemName.Text + ".txt", card);
                MessageBox.Show("Карточка предмета изменена!", "Изменение", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Предмет с именем " + textBoxItemName.Text + " уже существует! Придумайте что-нибудь другоею.", "Уже существует!", MessageBoxButtons.OK);
            RefreshList();

            textBoxItemName.Text = "";
            textBoxItem.Text = "";

            pictureWithoutCard.Visible = true;
        }

        private void buttonCancelChangeItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
