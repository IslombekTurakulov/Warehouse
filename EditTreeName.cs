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
    public partial class EditTreeName : Form
    {
        public EditTreeName()
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
                if (nameTxtBox.Text == String.Empty) 
                    throw new InvalidOperationException(@"Incorrect name. The name can't be empty!");
               
                Program.CallBackMy.AddTreeViewEventHandler(nameTxtBox.Text, true);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
