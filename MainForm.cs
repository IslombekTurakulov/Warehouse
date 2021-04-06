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
    public partial class MainForm : Form
    {
        private Form _activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open child form in panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="btnSender"></param>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            // Setting up child form.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pictureBox1.Visible = false;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            // Setting up child form.
            childForm.BringToFront();
            childForm.Show();
        }

        private void topBarPanel_MouseDown(object sender, MouseEventArgs e) => Cursor = Cursors.SizeAll;

        private void topBarPanel_MouseUp(object sender, MouseEventArgs e) => Cursor = Cursors.Default;

        private void mainMenuBunifu_Click(object sender, EventArgs e)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
                pictureBox1.Visible = true;
            }
        }

        private void file_Click(object sender, EventArgs e) => OpenChildForm(new FileForm(), this);

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void windowButton_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
