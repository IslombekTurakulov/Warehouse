

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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidebarPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.controlPage = new Bunifu.UI.WinForms.BunifuPages();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.filePage = new System.Windows.Forms.TabPage();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.explorePage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.settingsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exploreButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.fileButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.logoPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.topbarPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.hideButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dashboardLabelIntro = new Bunifu.UI.WinForms.BunifuLabel();
            this.fileLabelIntro = new Bunifu.UI.WinForms.BunifuLabel();
            this.exploreLabelIntro = new Bunifu.UI.WinForms.BunifuLabel();
            this.settingsLabelIntro = new Bunifu.UI.WinForms.BunifuLabel();
            this.sidebarPanel.SuspendLayout();
            this.controlPage.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            this.filePage.SuspendLayout();
            this.explorePage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.topbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.Transparent;
            this.sidebarPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.sidebarPanel.BorderRadius = 1;
            this.sidebarPanel.BorderThickness = 1;
            this.sidebarPanel.Controls.Add(this.indicator);
            this.sidebarPanel.Controls.Add(this.settingsButton);
            this.sidebarPanel.Controls.Add(this.exploreButton);
            this.sidebarPanel.Controls.Add(this.fileButton);
            this.sidebarPanel.Controls.Add(this.menuButton);
            this.sidebarPanel.Controls.Add(this.bunifuSeparator1);
            this.sidebarPanel.Controls.Add(this.logoPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Gradient;
            this.sidebarPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 27);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.sidebarPanel.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.sidebarPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.sidebarPanel.ShadowDept = 2;
            this.sidebarPanel.ShadowDepth = 2;
            this.sidebarPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.sidebarPanel.ShadowTopLeftVisible = false;
            this.sidebarPanel.Size = new System.Drawing.Size(190, 545);
            this.sidebarPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.sidebarPanel.TabIndex = 0;
            // 
            // controlPage
            // 
            this.controlPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.controlPage.AllowTransitions = true;
            this.controlPage.Controls.Add(this.dashboardPage);
            this.controlPage.Controls.Add(this.filePage);
            this.controlPage.Controls.Add(this.explorePage);
            this.controlPage.Controls.Add(this.settingsPage);
            this.controlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPage.Location = new System.Drawing.Point(190, 27);
            this.controlPage.Multiline = true;
            this.controlPage.Name = "controlPage";
            this.controlPage.Page = this.settingsPage;
            this.controlPage.PageIndex = 3;
            this.controlPage.PageName = "settingsPage";
            this.controlPage.PageTitle = "Settings";
            this.controlPage.SelectedIndex = 0;
            this.controlPage.Size = new System.Drawing.Size(831, 545);
            this.controlPage.TabIndex = 2;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.controlPage.Transition = animation1;
            this.controlPage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Controls.Add(this.dashboardLabelIntro);
            this.dashboardPage.Location = new System.Drawing.Point(4, 4);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardPage.Size = new System.Drawing.Size(823, 519);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // filePage
            // 
            this.filePage.Controls.Add(this.fileLabelIntro);
            this.filePage.Location = new System.Drawing.Point(4, 4);
            this.filePage.Name = "filePage";
            this.filePage.Padding = new System.Windows.Forms.Padding(3);
            this.filePage.Size = new System.Drawing.Size(823, 519);
            this.filePage.TabIndex = 1;
            this.filePage.Text = "File";
            this.filePage.UseVisualStyleBackColor = true;
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = true;
            this.bunifuFormDock.AllowHidingBottomRegion = true;
            this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock.ContainerControl = this;
            this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock.DockingOptions.DockAll = true;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock.DockingOptions.DockLeft = true;
            this.bunifuFormDock.DockingOptions.DockRight = true;
            this.bunifuFormDock.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock.DockingOptions.DockTopRight = true;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // explorePage
            // 
            this.explorePage.Controls.Add(this.exploreLabelIntro);
            this.explorePage.Location = new System.Drawing.Point(4, 4);
            this.explorePage.Name = "explorePage";
            this.explorePage.Padding = new System.Windows.Forms.Padding(3);
            this.explorePage.Size = new System.Drawing.Size(823, 519);
            this.explorePage.TabIndex = 2;
            this.explorePage.Text = "Explore";
            this.explorePage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.settingsLabelIntro);
            this.settingsPage.Location = new System.Drawing.Point(4, 4);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(823, 519);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.LightSalmon;
            this.indicator.Location = new System.Drawing.Point(3, 87);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(4, 57);
            this.indicator.TabIndex = 3;
            this.indicator.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.AllowAnimations = true;
            this.settingsButton.AllowMouseEffects = true;
            this.settingsButton.AllowToggling = true;
            this.settingsButton.AnimationSpeed = 200;
            this.settingsButton.AutoGenerateColors = false;
            this.settingsButton.AutoRoundBorders = false;
            this.settingsButton.AutoSizeLeftIcon = true;
            this.settingsButton.AutoSizeRightIcon = true;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackColor1 = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.ButtonText = "Settings";
            this.settingsButton.ButtonTextMarginLeft = 0;
            this.settingsButton.ColorContrastOnClick = 45;
            this.settingsButton.ColorContrastOnHover = 45;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.settingsButton.CustomizableEdges = borderEdges1;
            this.settingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.settingsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.settingsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.DimGray;
            this.settingsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.settingsButton.IconMarginLeft = 11;
            this.settingsButton.IconPadding = 13;
            this.settingsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.settingsButton.IconSize = 25;
            this.settingsButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.settingsButton.IdleBorderRadius = 1;
            this.settingsButton.IdleBorderThickness = 1;
            this.settingsButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.settingsButton.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.IdleIconLeftImage")));
            this.settingsButton.IdleIconRightImage = null;
            this.settingsButton.IndicateFocus = true;
            this.settingsButton.Location = new System.Drawing.Point(0, 245);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.settingsButton.OnDisabledState.BorderRadius = 1;
            this.settingsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.OnDisabledState.BorderThickness = 1;
            this.settingsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.settingsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.settingsButton.OnDisabledState.IconLeftImage = null;
            this.settingsButton.OnDisabledState.IconRightImage = null;
            this.settingsButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.settingsButton.onHoverState.BorderRadius = 1;
            this.settingsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.onHoverState.BorderThickness = 1;
            this.settingsButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.settingsButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.settingsButton.onHoverState.IconLeftImage = null;
            this.settingsButton.onHoverState.IconRightImage = null;
            this.settingsButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.settingsButton.OnIdleState.BorderRadius = 1;
            this.settingsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.OnIdleState.BorderThickness = 1;
            this.settingsButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.settingsButton.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.OnIdleState.IconLeftImage")));
            this.settingsButton.OnIdleState.IconRightImage = null;
            this.settingsButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.settingsButton.OnPressedState.BorderRadius = 1;
            this.settingsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.OnPressedState.BorderThickness = 1;
            this.settingsButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.settingsButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.settingsButton.OnPressedState.IconLeftImage = null;
            this.settingsButton.OnPressedState.IconRightImage = null;
            this.settingsButton.Size = new System.Drawing.Size(190, 54);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsButton.TextMarginLeft = 0;
            this.settingsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.settingsButton.UseDefaultRadiusAndThickness = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exploreButton
            // 
            this.exploreButton.AllowAnimations = true;
            this.exploreButton.AllowMouseEffects = true;
            this.exploreButton.AllowToggling = true;
            this.exploreButton.AnimationSpeed = 200;
            this.exploreButton.AutoGenerateColors = false;
            this.exploreButton.AutoRoundBorders = false;
            this.exploreButton.AutoSizeLeftIcon = true;
            this.exploreButton.AutoSizeRightIcon = true;
            this.exploreButton.BackColor = System.Drawing.Color.Transparent;
            this.exploreButton.BackColor1 = System.Drawing.Color.Transparent;
            this.exploreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exploreButton.BackgroundImage")));
            this.exploreButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exploreButton.ButtonText = "Explore";
            this.exploreButton.ButtonTextMarginLeft = 0;
            this.exploreButton.ColorContrastOnClick = 45;
            this.exploreButton.ColorContrastOnHover = 45;
            this.exploreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.exploreButton.CustomizableEdges = borderEdges2;
            this.exploreButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exploreButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exploreButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exploreButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exploreButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exploreButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.exploreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exploreButton.ForeColor = System.Drawing.Color.DimGray;
            this.exploreButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exploreButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.exploreButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.exploreButton.IconMarginLeft = 11;
            this.exploreButton.IconPadding = 13;
            this.exploreButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exploreButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.exploreButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.exploreButton.IconSize = 25;
            this.exploreButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.exploreButton.IdleBorderRadius = 1;
            this.exploreButton.IdleBorderThickness = 1;
            this.exploreButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.exploreButton.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("exploreButton.IdleIconLeftImage")));
            this.exploreButton.IdleIconRightImage = null;
            this.exploreButton.IndicateFocus = true;
            this.exploreButton.Location = new System.Drawing.Point(0, 191);
            this.exploreButton.Name = "exploreButton";
            this.exploreButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exploreButton.OnDisabledState.BorderRadius = 1;
            this.exploreButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exploreButton.OnDisabledState.BorderThickness = 1;
            this.exploreButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exploreButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exploreButton.OnDisabledState.IconLeftImage = null;
            this.exploreButton.OnDisabledState.IconRightImage = null;
            this.exploreButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.exploreButton.onHoverState.BorderRadius = 1;
            this.exploreButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exploreButton.onHoverState.BorderThickness = 1;
            this.exploreButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.exploreButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.exploreButton.onHoverState.IconLeftImage = null;
            this.exploreButton.onHoverState.IconRightImage = null;
            this.exploreButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.exploreButton.OnIdleState.BorderRadius = 1;
            this.exploreButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exploreButton.OnIdleState.BorderThickness = 1;
            this.exploreButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.exploreButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.exploreButton.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("exploreButton.OnIdleState.IconLeftImage")));
            this.exploreButton.OnIdleState.IconRightImage = null;
            this.exploreButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.exploreButton.OnPressedState.BorderRadius = 1;
            this.exploreButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exploreButton.OnPressedState.BorderThickness = 1;
            this.exploreButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.exploreButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.exploreButton.OnPressedState.IconLeftImage = null;
            this.exploreButton.OnPressedState.IconRightImage = null;
            this.exploreButton.Size = new System.Drawing.Size(190, 54);
            this.exploreButton.TabIndex = 5;
            this.exploreButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exploreButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.exploreButton.TextMarginLeft = 0;
            this.exploreButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.exploreButton.UseDefaultRadiusAndThickness = true;
            this.exploreButton.Click += new System.EventHandler(this.exploreButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.AllowAnimations = true;
            this.fileButton.AllowMouseEffects = true;
            this.fileButton.AllowToggling = true;
            this.fileButton.AnimationSpeed = 200;
            this.fileButton.AutoGenerateColors = false;
            this.fileButton.AutoRoundBorders = false;
            this.fileButton.AutoSizeLeftIcon = true;
            this.fileButton.AutoSizeRightIcon = true;
            this.fileButton.BackColor = System.Drawing.Color.Transparent;
            this.fileButton.BackColor1 = System.Drawing.Color.Transparent;
            this.fileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileButton.BackgroundImage")));
            this.fileButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileButton.ButtonText = "File Data";
            this.fileButton.ButtonTextMarginLeft = 0;
            this.fileButton.ColorContrastOnClick = 45;
            this.fileButton.ColorContrastOnHover = 45;
            this.fileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.fileButton.CustomizableEdges = borderEdges3;
            this.fileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fileButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.fileButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fileButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.fileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.fileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileButton.ForeColor = System.Drawing.Color.DimGray;
            this.fileButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.fileButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.fileButton.IconMarginLeft = 11;
            this.fileButton.IconPadding = 13;
            this.fileButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.fileButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.fileButton.IconSize = 25;
            this.fileButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.fileButton.IdleBorderRadius = 1;
            this.fileButton.IdleBorderThickness = 1;
            this.fileButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.fileButton.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("fileButton.IdleIconLeftImage")));
            this.fileButton.IdleIconRightImage = null;
            this.fileButton.IndicateFocus = true;
            this.fileButton.Location = new System.Drawing.Point(0, 137);
            this.fileButton.Name = "fileButton";
            this.fileButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.fileButton.OnDisabledState.BorderRadius = 1;
            this.fileButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileButton.OnDisabledState.BorderThickness = 1;
            this.fileButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fileButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.fileButton.OnDisabledState.IconLeftImage = null;
            this.fileButton.OnDisabledState.IconRightImage = null;
            this.fileButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.fileButton.onHoverState.BorderRadius = 1;
            this.fileButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileButton.onHoverState.BorderThickness = 1;
            this.fileButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.fileButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.fileButton.onHoverState.IconLeftImage = null;
            this.fileButton.onHoverState.IconRightImage = null;
            this.fileButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.fileButton.OnIdleState.BorderRadius = 1;
            this.fileButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileButton.OnIdleState.BorderThickness = 1;
            this.fileButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.fileButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.fileButton.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("fileButton.OnIdleState.IconLeftImage")));
            this.fileButton.OnIdleState.IconRightImage = null;
            this.fileButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.fileButton.OnPressedState.BorderRadius = 1;
            this.fileButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.fileButton.OnPressedState.BorderThickness = 1;
            this.fileButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.fileButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.fileButton.OnPressedState.IconLeftImage = null;
            this.fileButton.OnPressedState.IconRightImage = null;
            this.fileButton.Size = new System.Drawing.Size(190, 54);
            this.fileButton.TabIndex = 4;
            this.fileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileButton.TextMarginLeft = 0;
            this.fileButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.fileButton.UseDefaultRadiusAndThickness = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.AllowAnimations = true;
            this.menuButton.AllowMouseEffects = true;
            this.menuButton.AllowToggling = true;
            this.menuButton.AnimationSpeed = 200;
            this.menuButton.AutoGenerateColors = false;
            this.menuButton.AutoRoundBorders = false;
            this.menuButton.AutoSizeLeftIcon = true;
            this.menuButton.AutoSizeRightIcon = true;
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.BackColor1 = System.Drawing.Color.Transparent;
            this.menuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuButton.BackgroundImage")));
            this.menuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.menuButton.ButtonText = "Dashboard";
            this.menuButton.ButtonTextMarginLeft = 0;
            this.menuButton.ColorContrastOnClick = 45;
            this.menuButton.ColorContrastOnHover = 45;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.menuButton.CustomizableEdges = borderEdges4;
            this.menuButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.menuButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menuButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.ForeColor = System.Drawing.Color.DimGray;
            this.menuButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.menuButton.IconMarginLeft = 11;
            this.menuButton.IconPadding = 13;
            this.menuButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.menuButton.IconSize = 25;
            this.menuButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.menuButton.IdleBorderRadius = 1;
            this.menuButton.IdleBorderThickness = 1;
            this.menuButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.menuButton.IdleIconLeftImage = global::Warehouse.Properties.Resources.Sidebar_Window_icon;
            this.menuButton.IdleIconRightImage = null;
            this.menuButton.IndicateFocus = true;
            this.menuButton.Location = new System.Drawing.Point(0, 83);
            this.menuButton.Name = "menuButton";
            this.menuButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.menuButton.OnDisabledState.BorderRadius = 1;
            this.menuButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.menuButton.OnDisabledState.BorderThickness = 1;
            this.menuButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menuButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.menuButton.OnDisabledState.IconLeftImage = null;
            this.menuButton.OnDisabledState.IconRightImage = null;
            this.menuButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.menuButton.onHoverState.BorderRadius = 1;
            this.menuButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.menuButton.onHoverState.BorderThickness = 1;
            this.menuButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.menuButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.menuButton.onHoverState.IconLeftImage = null;
            this.menuButton.onHoverState.IconRightImage = null;
            this.menuButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.menuButton.OnIdleState.BorderRadius = 1;
            this.menuButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.menuButton.OnIdleState.BorderThickness = 1;
            this.menuButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.menuButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.menuButton.OnIdleState.IconLeftImage = global::Warehouse.Properties.Resources.Sidebar_Window_icon;
            this.menuButton.OnIdleState.IconRightImage = null;
            this.menuButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.menuButton.OnPressedState.BorderRadius = 1;
            this.menuButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.menuButton.OnPressedState.BorderThickness = 1;
            this.menuButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.menuButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.menuButton.OnPressedState.IconLeftImage = null;
            this.menuButton.OnPressedState.IconRightImage = null;
            this.menuButton.Size = new System.Drawing.Size(190, 54);
            this.menuButton.TabIndex = 2;
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuButton.TextMarginLeft = 0;
            this.menuButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.menuButton.UseDefaultRadiusAndThickness = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(190, 14);
            this.bunifuSeparator1.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.BorderColor = System.Drawing.Color.Transparent;
            this.logoPanel.BorderRadius = 3;
            this.logoPanel.BorderThickness = 1;
            this.logoPanel.Controls.Add(this.bunifuLabel1);
            this.logoPanel.Controls.Add(this.bunifuPictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.ShowBorders = true;
            this.logoPanel.Size = new System.Drawing.Size(190, 69);
            this.logoPanel.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel1.Location = new System.Drawing.Point(90, 26);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(77, 21);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Welcome!";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 33;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 6);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(66, 66);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // topbarPanel
            // 
            this.topbarPanel.BackgroundColor = System.Drawing.Color.Silver;
            this.topbarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topbarPanel.BackgroundImage")));
            this.topbarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topbarPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topbarPanel.BorderRadius = 3;
            this.topbarPanel.BorderThickness = 1;
            this.topbarPanel.Controls.Add(this.hideButton);
            this.topbarPanel.Controls.Add(this.bunifuButton1);
            this.topbarPanel.Controls.Add(this.exitButton);
            this.topbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbarPanel.Location = new System.Drawing.Point(0, 0);
            this.topbarPanel.Name = "topbarPanel";
            this.topbarPanel.ShowBorders = true;
            this.topbarPanel.Size = new System.Drawing.Size(1021, 27);
            this.topbarPanel.TabIndex = 1;
            // 
            // hideButton
            // 
            this.hideButton.AllowAnimations = true;
            this.hideButton.AllowMouseEffects = true;
            this.hideButton.AllowToggling = false;
            this.hideButton.AnimationSpeed = 200;
            this.hideButton.AutoGenerateColors = false;
            this.hideButton.AutoRoundBorders = false;
            this.hideButton.AutoSizeLeftIcon = true;
            this.hideButton.AutoSizeRightIcon = true;
            this.hideButton.BackColor = System.Drawing.Color.Transparent;
            this.hideButton.BackColor1 = System.Drawing.Color.Transparent;
            this.hideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hideButton.BackgroundImage")));
            this.hideButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hideButton.ButtonText = "";
            this.hideButton.ButtonTextMarginLeft = 0;
            this.hideButton.ColorContrastOnClick = 45;
            this.hideButton.ColorContrastOnHover = 45;
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.hideButton.CustomizableEdges = borderEdges5;
            this.hideButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hideButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hideButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hideButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hideButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hideButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.hideButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.hideButton.IconMarginLeft = 11;
            this.hideButton.IconPadding = 5;
            this.hideButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hideButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.hideButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.hideButton.IconSize = 25;
            this.hideButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.hideButton.IdleBorderRadius = 1;
            this.hideButton.IdleBorderThickness = 1;
            this.hideButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.hideButton.IdleIconLeftImage = global::Warehouse.Properties.Resources.hide_circle;
            this.hideButton.IdleIconRightImage = null;
            this.hideButton.IndicateFocus = false;
            this.hideButton.Location = new System.Drawing.Point(50, 0);
            this.hideButton.Name = "hideButton";
            this.hideButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hideButton.OnDisabledState.BorderRadius = 1;
            this.hideButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hideButton.OnDisabledState.BorderThickness = 1;
            this.hideButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hideButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hideButton.OnDisabledState.IconLeftImage = null;
            this.hideButton.OnDisabledState.IconRightImage = null;
            this.hideButton.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.hideButton.onHoverState.BorderRadius = 1;
            this.hideButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hideButton.onHoverState.BorderThickness = 1;
            this.hideButton.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.hideButton.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.hideButton.onHoverState.IconLeftImage = null;
            this.hideButton.onHoverState.IconRightImage = null;
            this.hideButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.hideButton.OnIdleState.BorderRadius = 1;
            this.hideButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hideButton.OnIdleState.BorderThickness = 1;
            this.hideButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.hideButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.hideButton.OnIdleState.IconLeftImage = global::Warehouse.Properties.Resources.hide_circle;
            this.hideButton.OnIdleState.IconRightImage = null;
            this.hideButton.OnPressedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.hideButton.OnPressedState.BorderRadius = 1;
            this.hideButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hideButton.OnPressedState.BorderThickness = 1;
            this.hideButton.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.hideButton.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.hideButton.OnPressedState.IconLeftImage = null;
            this.hideButton.OnPressedState.IconRightImage = null;
            this.hideButton.Size = new System.Drawing.Size(28, 27);
            this.hideButton.TabIndex = 9;
            this.hideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hideButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.hideButton.TextMarginLeft = 0;
            this.hideButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.hideButton.UseDefaultRadiusAndThickness = true;
            this.hideButton.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges6;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 5;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleIconLeftImage = global::Warehouse.Properties.Resources.roll_circle;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(27, 0);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = global::Warehouse.Properties.Resources.roll_circle;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(23, 27);
            this.bunifuButton1.TabIndex = 8;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.windowButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowMouseEffects = true;
            this.exitButton.AllowToggling = false;
            this.exitButton.AnimationSpeed = 200;
            this.exitButton.AutoGenerateColors = false;
            this.exitButton.AutoRoundBorders = false;
            this.exitButton.AutoSizeLeftIcon = true;
            this.exitButton.AutoSizeRightIcon = true;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackColor1 = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.ButtonText = "";
            this.exitButton.ButtonTextMarginLeft = 0;
            this.exitButton.ColorContrastOnClick = 45;
            this.exitButton.ColorContrastOnHover = 45;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.exitButton.CustomizableEdges = borderEdges7;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.exitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.exitButton.IconMarginLeft = 11;
            this.exitButton.IconPadding = 5;
            this.exitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.exitButton.IconSize = 25;
            this.exitButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.exitButton.IdleBorderRadius = 1;
            this.exitButton.IdleBorderThickness = 1;
            this.exitButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.exitButton.IdleIconLeftImage = global::Warehouse.Properties.Resources.exit_circle2;
            this.exitButton.IdleIconRightImage = null;
            this.exitButton.IndicateFocus = false;
            this.exitButton.Location = new System.Drawing.Point(0, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exitButton.OnDisabledState.BorderRadius = 1;
            this.exitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnDisabledState.BorderThickness = 1;
            this.exitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exitButton.OnDisabledState.IconLeftImage = null;
            this.exitButton.OnDisabledState.IconRightImage = null;
            this.exitButton.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.onHoverState.BorderRadius = 1;
            this.exitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.onHoverState.BorderThickness = 1;
            this.exitButton.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.onHoverState.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.onHoverState.IconLeftImage = null;
            this.exitButton.onHoverState.IconRightImage = null;
            this.exitButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.exitButton.OnIdleState.BorderRadius = 1;
            this.exitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnIdleState.BorderThickness = 1;
            this.exitButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.exitButton.OnIdleState.IconLeftImage = global::Warehouse.Properties.Resources.exit_circle2;
            this.exitButton.OnIdleState.IconRightImage = null;
            this.exitButton.OnPressedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.OnPressedState.BorderRadius = 1;
            this.exitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnPressedState.BorderThickness = 1;
            this.exitButton.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.OnPressedState.IconLeftImage = null;
            this.exitButton.OnPressedState.IconRightImage = null;
            this.exitButton.Size = new System.Drawing.Size(27, 27);
            this.exitButton.TabIndex = 7;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.TextMarginLeft = 0;
            this.exitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.exitButton.UseDefaultRadiusAndThickness = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dashboardLabelIntro
            // 
            this.dashboardLabelIntro.AllowParentOverrides = false;
            this.dashboardLabelIntro.AutoEllipsis = false;
            this.dashboardLabelIntro.Cursor = System.Windows.Forms.Cursors.Default;
            this.dashboardLabelIntro.CursorType = System.Windows.Forms.Cursors.Default;
            this.dashboardLabelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardLabelIntro.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.dashboardLabelIntro.ForeColor = System.Drawing.Color.DimGray;
            this.dashboardLabelIntro.Location = new System.Drawing.Point(3, 3);
            this.dashboardLabelIntro.Name = "dashboardLabelIntro";
            this.dashboardLabelIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dashboardLabelIntro.Size = new System.Drawing.Size(817, 31);
            this.dashboardLabelIntro.TabIndex = 2;
            this.dashboardLabelIntro.Text = "Dashboard";
            this.dashboardLabelIntro.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardLabelIntro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // fileLabelIntro
            // 
            this.fileLabelIntro.AllowParentOverrides = false;
            this.fileLabelIntro.AutoEllipsis = false;
            this.fileLabelIntro.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileLabelIntro.CursorType = System.Windows.Forms.Cursors.Default;
            this.fileLabelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileLabelIntro.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.fileLabelIntro.ForeColor = System.Drawing.Color.DimGray;
            this.fileLabelIntro.Location = new System.Drawing.Point(3, 3);
            this.fileLabelIntro.Name = "fileLabelIntro";
            this.fileLabelIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileLabelIntro.Size = new System.Drawing.Size(817, 31);
            this.fileLabelIntro.TabIndex = 3;
            this.fileLabelIntro.Text = "File";
            this.fileLabelIntro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.fileLabelIntro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // exploreLabelIntro
            // 
            this.exploreLabelIntro.AllowParentOverrides = false;
            this.exploreLabelIntro.AutoEllipsis = false;
            this.exploreLabelIntro.Cursor = System.Windows.Forms.Cursors.Default;
            this.exploreLabelIntro.CursorType = System.Windows.Forms.Cursors.Default;
            this.exploreLabelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.exploreLabelIntro.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.exploreLabelIntro.ForeColor = System.Drawing.Color.DimGray;
            this.exploreLabelIntro.Location = new System.Drawing.Point(3, 3);
            this.exploreLabelIntro.Name = "exploreLabelIntro";
            this.exploreLabelIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exploreLabelIntro.Size = new System.Drawing.Size(817, 31);
            this.exploreLabelIntro.TabIndex = 3;
            this.exploreLabelIntro.Text = "Explore";
            this.exploreLabelIntro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.exploreLabelIntro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // settingsLabelIntro
            // 
            this.settingsLabelIntro.AllowParentOverrides = false;
            this.settingsLabelIntro.AutoEllipsis = false;
            this.settingsLabelIntro.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingsLabelIntro.CursorType = System.Windows.Forms.Cursors.Default;
            this.settingsLabelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsLabelIntro.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.settingsLabelIntro.ForeColor = System.Drawing.Color.DimGray;
            this.settingsLabelIntro.Location = new System.Drawing.Point(3, 3);
            this.settingsLabelIntro.Name = "settingsLabelIntro";
            this.settingsLabelIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsLabelIntro.Size = new System.Drawing.Size(817, 31);
            this.settingsLabelIntro.TabIndex = 3;
            this.settingsLabelIntro.Text = "Settings";
            this.settingsLabelIntro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.settingsLabelIntro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1021, 572);
            this.Controls.Add(this.controlPage);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.sidebarPanel.ResumeLayout(false);
            this.controlPage.ResumeLayout(false);
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            this.filePage.ResumeLayout(false);
            this.filePage.PerformLayout();
            this.explorePage.ResumeLayout(false);
            this.explorePage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.topbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuShadowPanel sidebarPanel;
        private Bunifu.UI.WinForms.BunifuPanel logoPanel;
        private Bunifu.UI.WinForms.BunifuPanel topbarPanel;
        private Bunifu.UI.WinForms.BunifuPages controlPage;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.TabPage filePage;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton menuButton;
        private System.Windows.Forms.PictureBox indicator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton settingsButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exploreButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton fileButton;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        private System.Windows.Forms.TabPage explorePage;
        private System.Windows.Forms.TabPage settingsPage;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton hideButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuLabel dashboardLabelIntro;
        private Bunifu.UI.WinForms.BunifuLabel fileLabelIntro;
        private Bunifu.UI.WinForms.BunifuLabel exploreLabelIntro;
        private Bunifu.UI.WinForms.BunifuLabel settingsLabelIntro;
    }
}

