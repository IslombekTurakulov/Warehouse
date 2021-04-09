using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
