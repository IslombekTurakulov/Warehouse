using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class CSVSort : Form
    {
        public bool IsClosed;
        public int Amount;
        public int Cost;
        public CSVSort()
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
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (amountTxtBox.Text == string.Empty) 
                    throw new ArgumentException(@"Incorrect amount. The amount is empty!");
                if (!Regex.IsMatch(amountTxtBox.Text, @"^[0-9]+$"))
                    throw new ArgumentException(@"Incorrect amount. The amount must contain only digits!");
                if (costTxtBox.Text == string.Empty) 
                    throw new ArgumentException(@"Incorrect cost. The cost is empty!");
                if (!Regex.IsMatch(costTxtBox.Text, @"^[0-9]+$"))
                    throw new ArgumentException(@"Incorrect cost. The cost must contain only digits!");
                if (!int.TryParse(amountTxtBox.Text, out Amount) && Amount < 0 || Amount >= Int32.MaxValue)
                    throw new ArgumentException("Incorrect amount. Amount is less than 0 or greater than max value!");
                if (!int.TryParse(costTxtBox.Text, out Cost) && Cost < 0 || Cost >= Int32.MaxValue)
                    throw new ArgumentException("Incorrect cost. Cost is less than 0 or greater than max value!");
                IsClosed = true;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
