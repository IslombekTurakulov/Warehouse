using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
            bunifuFormDock.SubscribeControlToDragEvents(logoPanel);
        }

        private void topBarPanel_MouseDown(object sender, MouseEventArgs e) => Cursor = Cursors.SizeAll;

        private void topBarPanel_MouseUp(object sender, MouseEventArgs e) => Cursor = Cursors.Default;

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void windowButton_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
            controlPage.SetPage(dashboardPage);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
            controlPage.SetPage(filePage);
        }

        private void exploreButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
            controlPage.SetPage(explorePage);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
            controlPage.SetPage(settingsPage);
        }
    }
}
