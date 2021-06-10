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
    public partial class ChangePlace : Form
    {
        public string[] card;
        public ChangePlace()
        {
            InitializeComponent();

            listPlaces.Items.AddRange(NameList());

            pictureWithoutCard.Visible = true;
            pictureWithoutCard.Image = Properties.Resources.castle;
        }
        
        private void ChangePlace_Click(object sender, EventArgs e)
        { 
            card = AllCard();

            File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places] + @"\" + listPlaces.SelectedItem.ToString());
            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places] + @"\" + textBoxPlaceName.Text))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places] + @"\" + textBoxPlaceName.Text + ".txt", card);
                MessageBox.Show("Карточка места изменена!", "Изменение", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Место с именем " + textBoxPlaceName.Text + " уже существует! Придумайте что-нибудь другоею.", "Уже существует!", MessageBoxButtons.OK);
            
            RefreshList();

            textBoxPlaceName.Text = "";
            textBoxPlace.Text = "";
            
            pictureWithoutCard.Visible = true;
        }

        public void RefreshList()
        {
            listPlaces.Items.Clear();
            listPlaces.Items.AddRange(NameList());
        }

        public string[] AllCard()
        {
            List<string> s = new List<string>();
            s.Add(textBoxPlaceName.Text);
            foreach(var e in textBoxPlace.Lines)
            {
                s.Add(e);
            }
            return s.ToArray();
        }

        private void CancelChangePlace_Click(object sender, EventArgs e)
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

        private void listPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureWithoutCard.Visible = false;
            if (listPlaces.SelectedItem != null)
            {
                card = File.ReadAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + listPlaces.SelectedItem.ToString());

                pictureWithoutCard.Visible = false;

                textBoxPlaceName.Text = card[0];
                textBoxPlace.Text = card[1];
            }
        }
    }
}
