
namespace Warehouse
{
    partial class AddFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuUserControl = new Bunifu.UI.WinForms.BunifuUserControl();
            this.SuspendLayout();
            // 
            // bunifuUserControl
            // 
            this.bunifuUserControl.AllowAnimations = false;
            this.bunifuUserControl.AllowBorderColorChanges = false;
            this.bunifuUserControl.AllowMouseEffects = false;
            this.bunifuUserControl.AnimationSpeed = 200;
            this.bunifuUserControl.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.bunifuUserControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuUserControl.BorderRadius = 2;
            this.bunifuUserControl.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl.BorderThickness = 1;
            this.bunifuUserControl.ColorContrastOnClick = 30;
            this.bunifuUserControl.ColorContrastOnHover = 30;
            this.bunifuUserControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuUserControl.Image = null;
            this.bunifuUserControl.ImageMargin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bunifuUserControl.Location = new System.Drawing.Point(0, 0);
            this.bunifuUserControl.Name = "bunifuUserControl";
            this.bunifuUserControl.ShowBorders = true;
            this.bunifuUserControl.Size = new System.Drawing.Size(800, 450);
            this.bunifuUserControl.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl.TabIndex = 0;
            // 
            // AddFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFileForm";
            this.Text = "Add Data";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl;
    }
}