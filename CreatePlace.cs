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
    public partial class CreatePlace : Form
    {
        public string[] placeCard;
        public CreatePlace()
        {
            InitializeComponent();
        }

        private void CreatePlace_Click(object sender, EventArgs e)
        {
            placeCard = AllCard();

            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places] + @"\" + textBoxPlaceName.Text + ".txt"))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Places] + @"\" + textBoxPlaceName.Text + ".txt", placeCard);
                MessageBox.Show("Карточка места добавлена!", "Создание", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Место с названием " + textBoxPlaceName.Text + " уже существует! Придумйте что-нибудь другое.", "Уже было!", MessageBoxButtons.OK);
            }
            textBoxPlaceName.Text = ""; textBoxPlace.Text = "";
        }

        public string[] AllCard()
        {
            List<string> s = new List<string>();
            s.Add(textBoxPlaceName.Text);
            foreach (var e in textBoxPlace.Lines)
            {
                s.Add(e);
            }
            return s.ToArray();
        }

        private void CancelCreatePlace_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
