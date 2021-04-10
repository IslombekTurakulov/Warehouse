using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Warehouse
{
    public partial class AddFileForm : Form
    {
        private Random rnd = new Random();
        public AddFileForm()
        {
            InitializeComponent();
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure want to exit?",
                "Program exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if(dialog == DialogResult.Yes) {
                this.Close();
                // Сохранение.

            }
        }

        private void randomUcnButton_Click(object sender, EventArgs e)
        {
            string rest = $"{(char)rnd.Next(65,91)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{rnd.Next(700, 1000)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65,91)}" +
                          $"{rnd.Next(80, 1000)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{rnd.Next(1, 1000)}" +
                          $"{(char) rnd.Next(97, 123)}" +
                          $"{(char)rnd.Next(65,91)}" +
                          $"{(char) rnd.Next(97, 123)}";
            ucnTxtBox.Text = rest;
        }

        private void nameTxtBox_TextChange(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == String.Empty) 
                return;
            if (!Regex.IsMatch(nameTxtBox.Text, @"^[a-zA-Z]+$"))
                MessageBox.Show(@"Incorrect name. The string must contain only latin letters!");
        }

        private void codeTxtBox_TextChange(object sender, EventArgs e)
        {
            if (codeTxtBox.Text == String.Empty) 
                return;
            if (!Regex.IsMatch(codeTxtBox.Text, @"^[0-9-]+$"))
                MessageBox.Show(@"Incorrect code. The string must contain only digits!");
        }

        private void ucnTxtBox_TextChange(object sender, EventArgs e)
        {
            if (codeTxtBox.Text == String.Empty) 
                return;
            if (!Regex.IsMatch(ucnTxtBox.Text, @"^[a-zA-Z0-9]+$"))
                MessageBox.Show(@"Incorrect UCN. The string must contain only words and digits!");
        }

        private void amountTxtBox_TextChange(object sender, EventArgs e)
        {
            if (amountTxtBox.Text == String.Empty) 
                return;
            if (!double.TryParse(amountTxtBox.Text, out double res) || res <= 0)
                MessageBox.Show(@"Incorrect amount. The amount is less than value!");
            if (!double.TryParse(amountTxtBox.Text, out double newRes) || newRes >= Double.MaxValue)
                MessageBox.Show(@"Incorrect amount. The amount is greater than value!");
            if (!Regex.IsMatch(amountTxtBox.Text, @"^[0-9-]+$"))
                MessageBox.Show(@"Incorrect amount. The string must contain only digits!");
        }

        private void urlTxtBox_TextChange(object sender, EventArgs e)
        {
            if (codeTxtBox.Text == String.Empty) 
                return;
            if (!Regex.IsMatch(ucnTxtBox.Text, @"^[a-zA-Z0-9]+$"))
                MessageBox.Show(@"Incorrect URL. The string must contain only words and digits!");
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "PNG files(*.png)|*.png|JPEG files(*.jpeg)|*.jpeg|JPG files(*.jpg)|*.jpg"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            imageFileBox.Image = Image.FromFile($@"{openFileDialog1.FileName}");
        }

        private void mainFuncButton_Click(object sender, EventArgs e)
        {
            controlPage.SetPage(mainFunc);
        }

        private void extraFuncButton_Click(object sender, EventArgs e)
        {
            controlPage.SetPage(extraFunc);
        }
    }
}
