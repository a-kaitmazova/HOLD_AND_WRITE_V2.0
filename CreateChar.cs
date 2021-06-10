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
    public partial class CreateChar : Form
    {
        public static string curGender = "non";
        public static string curRole = "non";
        public static string[] temp;
        public static string[] card;
        public CreateChar()
        {
            InitializeComponent();
        }

        private void SaveChar_Click(object sender, EventArgs e)
        {
            temp = new[] { textBoxName.Text, curGender, textBoxAge.Text, curRole };
            card = AllCard(textBoxAbout.Lines);

            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text + ".txt", card);
                MessageBox.Show("Карточка персонажа добавлена!", "Создание", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Персонаж с именем " + textBoxName.Text + " уже существует! Придумайте что-нибудь другоею.", "Уже существует!", MessageBoxButtons.OK);
            CleanCard();
        }

        public string[] AllCard(string[] textBox)
        {
            List<string> s = new List<string>();
            foreach(var e in temp)
            {
                s.Add(e);
            }
            foreach(var i in textBox)
            {
                s.Add(i);
            }
            return s.ToArray();
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

        private void CancelSaveChar_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
