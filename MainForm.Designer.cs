using Bunifu.Framework.UI;

namespace Warehouse
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exitPanel = new System.Windows.Forms.Panel();
            this.minimizeWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.windowButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.fileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.exploreButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.settingsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sideBarPanel.Controls.Add(this.settingsButton);
            this.sideBarPanel.Controls.Add(this.exploreButton);
            this.sideBarPanel.Controls.Add(this.fileButton);
            this.sideBarPanel.Controls.Add(this.menuButton);
            this.sideBarPanel.Controls.Add(this.bunifuImageButton1);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideBarPanel.Location = new System.Drawing.Point(751, 27);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(49, 485);
            this.sideBarPanel.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.CadetBlue;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(49, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.exitPanel;
            this.bunifuDragControl.Vertical = true;
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.exitPanel.Controls.Add(this.minimizeWindow);
            this.exitPanel.Controls.Add(this.windowButton);
            this.exitPanel.Controls.Add(this.exitButton);
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitPanel.Location = new System.Drawing.Point(0, 0);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(800, 27);
            this.exitPanel.TabIndex = 7;
            this.exitPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarPanel_MouseDown);
            this.exitPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBarPanel_MouseUp);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("minimizeWindow.Image")));
            this.minimizeWindow.ImageActive = null;
            this.minimizeWindow.Location = new System.Drawing.Point(51, 3);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(25, 21);
            this.minimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeWindow.TabIndex = 8;
            this.minimizeWindow.TabStop = false;
            this.minimizeWindow.Zoom = 2;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // windowButton
            // 
            this.windowButton.BackColor = System.Drawing.Color.Transparent;
            this.windowButton.Image = ((System.Drawing.Image)(resources.GetObject("windowButton.Image")));
            this.windowButton.ImageActive = null;
            this.windowButton.Location = new System.Drawing.Point(26, 3);
            this.windowButton.Name = "windowButton";
            this.windowButton.Size = new System.Drawing.Size(28, 21);
            this.windowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.windowButton.TabIndex = 7;
            this.windowButton.TabStop = false;
            this.windowButton.Zoom = 2;
            this.windowButton.Click += new System.EventHandler(this.windowButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 21);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitButton.TabIndex = 6;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 2;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 30;
            this.bunifuElipse.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 40;
            this.bunifuElipse3.TargetControl = this;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.color = System.Drawing.Color.Transparent;
            this.menuButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImagePosition = 10;
            this.menuButton.ImageZoom = 50;
            this.menuButton.LabelPosition = 0;
            this.menuButton.LabelText = "";
            this.menuButton.Location = new System.Drawing.Point(0, 50);
            this.menuButton.Margin = new System.Windows.Forms.Padding(6);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(49, 46);
            this.menuButton.TabIndex = 1;
            this.menuButton.Click += new System.EventHandler(this.mainMenuBunifu_Click);
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.Transparent;
            this.fileButton.color = System.Drawing.Color.Transparent;
            this.fileButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.fileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.fileButton.ForeColor = System.Drawing.Color.White;
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.ImagePosition = 10;
            this.fileButton.ImageZoom = 50;
            this.fileButton.LabelPosition = 0;
            this.fileButton.LabelText = "";
            this.fileButton.Location = new System.Drawing.Point(0, 96);
            this.fileButton.Margin = new System.Windows.Forms.Padding(6);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(49, 46);
            this.fileButton.TabIndex = 2;
            this.fileButton.Click += new System.EventHandler(this.file_Click);
            // 
            // exploreButton
            // 
            this.exploreButton.BackColor = System.Drawing.Color.Transparent;
            this.exploreButton.color = System.Drawing.Color.Transparent;
            this.exploreButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.exploreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploreButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exploreButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.exploreButton.ForeColor = System.Drawing.Color.White;
            this.exploreButton.Image = ((System.Drawing.Image)(resources.GetObject("exploreButton.Image")));
            this.exploreButton.ImagePosition = 10;
            this.exploreButton.ImageZoom = 50;
            this.exploreButton.LabelPosition = 0;
            this.exploreButton.LabelText = "";
            this.exploreButton.Location = new System.Drawing.Point(0, 142);
            this.exploreButton.Margin = new System.Windows.Forms.Padding(6);
            this.exploreButton.Name = "exploreButton";
            this.exploreButton.Size = new System.Drawing.Size(49, 46);
            this.exploreButton.TabIndex = 3;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.color = System.Drawing.Color.Transparent;
            this.settingsButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImagePosition = 10;
            this.settingsButton.ImageZoom = 50;
            this.settingsButton.LabelPosition = 0;
            this.settingsButton.LabelText = "";
            this.settingsButton.Location = new System.Drawing.Point(0, 188);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(6);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(49, 46);
            this.settingsButton.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 27);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(751, 485);
            this.panelDesktop.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.exitPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.exitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private BunifuDragControl bunifuDragControl;
        private BunifuElipse bunifuElipse;
        private BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel exitPanel;
        private BunifuImageButton minimizeWindow;
        private BunifuImageButton windowButton;
        private BunifuImageButton exitButton;
        private BunifuElipse bunifuElipse1;
        private BunifuElipse bunifuElipse2;
        private BunifuElipse bunifuElipse3;
        private BunifuTileButton fileButton;
        private BunifuTileButton menuButton;
        private BunifuTileButton settingsButton;
        private BunifuTileButton exploreButton;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

