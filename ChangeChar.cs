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
    public partial class ChangeChar : Form
    {
        public string[] curCard;
        public static string curGender;
        public static string curRole;
        public string[] card;
        public string[] temp;
        public ChangeChar()
        {
            InitializeComponent();
            listCharacters.Items.AddRange(NameList());

            pictureWithoutCard.Visible = true;
            pictureWithoutCard.Image = Properties.Resources._char;
        }

        private void ChangeChar_Click(object sender, EventArgs e)
        {
            temp = new []{ textBoxName.Text, curGender, textBoxAge.Text, curRole };
            card = AllCard();

            File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + listCharacters.SelectedItem.ToString());
            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text + ".txt", card);
                MessageBox.Show("Карточка персонажа изменена!", "Изменение", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Персонаж с именем " + textBoxName.Text + " уже существует! Придумайте что-нибудь другоею.", "Уже существует!", MessageBoxButtons.OK);
            RefreshList();
            CleanCard();
            pictureWithoutCard.Visible = true;
        }

        public string[] AllCard()
        {
            List<string> s = new List<string>();
            foreach (var e in temp)
            {
                s.Add(e);
            }
            foreach (var i in textBoxAbout.Lines)
            {
                s.Add(i);
            }
            return s.ToArray();
        }

        private void CancelChangeChar_Click(object sender, EventArgs e)
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

        private void listCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureWithoutCard.Visible = false;
            if (listCharacters.SelectedItem != null)
            {
                card = File.ReadAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + listCharacters.SelectedItem.ToString());

                pictureWithoutCard.Visible = false;

                textBoxName.Text = card[0];
                switch (curCard[1])
                {
                    case "female": radioGenFem.Checked = true; curGender = "female"; break;
                    case "male": radioGenMale.Checked = true; curGender = "male"; break;
                    case "other": radioOther.Checked = true; curGender = "other"; break;
                }
                textBoxAge.Text = card[2];
                switch (curCard[3])
                {
                    case "main": radioMain.Checked = true; curRole = "main"; break;
                    case "sec": radioSecond.Checked = true; curRole = "sec"; break;
                    case "cameo": radioCameo.Checked = true; curRole = "cameo"; break;
                    case "ment": radioMent.Checked = true; curRole = "ment"; break;
                }
                textBoxAbout.Lines = CardText(card, 4);
            }
        }

        public string[] CardText(string[] source, int n)
        {
            List<string> temp = new List<string>();
            int i = 0;
            foreach(var e in source)
            {
                if (i >= n)
                {
                    temp.Add(e); 
                }
                i++;
            }
            return temp.ToArray();
        }

        public void RefreshList()
        {
            listCharacters.Items.Clear();
            listCharacters.Items.AddRange(NameList());
        }

        private void radioGenMale_CheckedChanged(object sender, EventArgs e)
        {
            curGender = "male";
        }

        private void radioGenFem_CheckedChanged(object sender, EventArgs e)
        {
            curGender = "female";
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            curGender = "other";
        }

        private void radioMain_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "main";
        }

        private void radioSecond_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "sec";
        }

        private void radioCameo_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "cameo";
        }

        private void radioMent_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "ment";
        }

        public void UncheckRadio()
        {
            radioGenMale.Checked = false;
            radioGenFem.Checked = false;
            radioOther.Checked = false;

            radioMain.Checked = false;
            radioSecond.Checked = false;
            radioCameo.Checked = false;
            radioMent.Checked = false;
        }

        public void CleanCard()
        {
            textBoxName.Text = "";
            curGender = "non";
            textBoxAge.Text = "";
            textBoxAbout.Text = "";
            curRole = "non";
            UncheckRadio();
        }
    }
}
