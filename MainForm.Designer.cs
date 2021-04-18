

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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.sidebarPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.controlPage = new Bunifu.UI.WinForms.BunifuPages();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.dashboardLabelIntro = new Bunifu.UI.WinForms.BunifuLabel();
            this.filePage = new System.Windows.Forms.TabPage();
            this.dataGridProduct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrantyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeviewPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextTreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.createChildNodeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteChildNodeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.colorTransitionSide = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.thirdDashboardPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.secondChartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticsLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.secondDashboardPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.nodePicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.totalNodesLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.totalNodesNumLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.firstDashboardPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.filePicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.totalFilesLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.totalFilesNumLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.panelButton = new Bunifu.UI.WinForms.BunifuPanel();
            this.thirdPanelButton = new System.Windows.Forms.Panel();
            this.csvButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.secondPanelButton = new System.Windows.Forms.Panel();
            this.sortButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addNodeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.fileButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.menuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.logoPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.logoLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.logoPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.topbarPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.hideButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sidebarPanel.SuspendLayout();
            this.controlPage.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            this.filePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.datagridContext.SuspendLayout();
            this.treeviewPanel.SuspendLayout();
            this.contextTreeview.SuspendLayout();
            this.thirdDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondChartDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            this.secondDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodePicture)).BeginInit();
            this.firstDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePicture)).BeginInit();
            this.panelButton.SuspendLayout();
            this.thirdPanelButton.SuspendLayout();
            this.secondPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.topbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.Transparent;
            this.sidebarPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.sidebarPanel.BorderRadius = 1;
            this.sidebarPanel.BorderThickness = 1;
            this.sidebarPanel.Controls.Add(this.indicator);
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
            this.sidebarPanel.Size = new System.Drawing.Size(190, 773);
            this.sidebarPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.sidebarPanel.TabIndex = 0;
            // 
            // controlPage
            // 
            this.controlPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.controlPage.AllowTransitions = true;
            this.controlPage.Controls.Add(this.dashboardPage);
            this.controlPage.Controls.Add(this.filePage);
            this.controlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPage.Location = new System.Drawing.Point(190, 27);
            this.controlPage.Multiline = true;
            this.controlPage.Name = "controlPage";
            this.controlPage.Page = this.filePage;
            this.controlPage.PageIndex = 1;
            this.controlPage.PageName = "filePage";
            this.controlPage.PageTitle = "File";
            this.controlPage.SelectedIndex = 0;
            this.controlPage.Size = new System.Drawing.Size(1010, 773);
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
            this.dashboardPage.Controls.Add(this.thirdDashboardPanel);
            this.dashboardPage.Controls.Add(this.secondDashboardPanel);
            this.dashboardPage.Controls.Add(this.firstDashboardPanel);
            this.dashboardPage.Controls.Add(this.dashboardLabelIntro);
            this.dashboardPage.Location = new System.Drawing.Point(4, 4);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardPage.Size = new System.Drawing.Size(1002, 747);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
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
            this.dashboardLabelIntro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dashboardLabelIntro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dashboardLabelIntro.Size = new System.Drawing.Size(121, 31);
            this.dashboardLabelIntro.TabIndex = 2;
            this.dashboardLabelIntro.Text = "Dashboard";
            this.dashboardLabelIntro.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dashboardLabelIntro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // filePage
            // 
            this.filePage.Controls.Add(this.dataGridProduct);
            this.filePage.Controls.Add(this.treeviewPanel);
            this.filePage.Location = new System.Drawing.Point(4, 4);
            this.filePage.Name = "filePage";
            this.filePage.Padding = new System.Windows.Forms.Padding(3);
            this.filePage.Size = new System.Drawing.Size(1002, 747);
            this.filePage.TabIndex = 1;
            this.filePage.Text = "File";
            this.filePage.UseVisualStyleBackColor = true;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowCustomTheming = false;
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProduct.ColumnHeadersHeight = 40;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CodeColumn,
            this.UcnColumn,
            this.CompanyColumn,
            this.AmountColumn,
            this.CostColumn,
            this.CurrencyColumn,
            this.WarrantyColumn,
            this.StatusColumn,
            this.DiscountColumn,
            this.CountryColumn});
            this.dataGridProduct.ContextMenuStrip = this.datagridContext;
            this.dataGridProduct.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.dataGridProduct.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridProduct.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridProduct.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.dataGridProduct.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProduct.CurrentTheme.BackColor = System.Drawing.Color.Orange;
            this.dataGridProduct.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.dataGridProduct.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Orange;
            this.dataGridProduct.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridProduct.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridProduct.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.dataGridProduct.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridProduct.CurrentTheme.Name = null;
            this.dataGridProduct.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dataGridProduct.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridProduct.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridProduct.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.dataGridProduct.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProduct.EnableHeadersVisualStyles = false;
            this.dataGridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.dataGridProduct.HeaderBackColor = System.Drawing.Color.Orange;
            this.dataGridProduct.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridProduct.Location = new System.Drawing.Point(179, 3);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.RowHeadersVisible = false;
            this.dataGridProduct.RowTemplate.Height = 40;
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(820, 741);
            this.dataGridProduct.TabIndex = 1;
            this.dataGridProduct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // CodeColumn
            // 
            this.CodeColumn.HeaderText = "Code";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            // 
            // UcnColumn
            // 
            this.UcnColumn.HeaderText = "UCN";
            this.UcnColumn.Name = "UcnColumn";
            this.UcnColumn.ReadOnly = true;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.HeaderText = "Company";
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // CostColumn
            // 
            this.CostColumn.HeaderText = "Cost";
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.ReadOnly = true;
            // 
            // CurrencyColumn
            // 
            this.CurrencyColumn.HeaderText = "Currency";
            this.CurrencyColumn.Name = "CurrencyColumn";
            this.CurrencyColumn.ReadOnly = true;
            // 
            // WarrantyColumn
            // 
            this.WarrantyColumn.HeaderText = "Warranty";
            this.WarrantyColumn.Name = "WarrantyColumn";
            this.WarrantyColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // DiscountColumn
            // 
            this.DiscountColumn.HeaderText = "Discount";
            this.DiscountColumn.Name = "DiscountColumn";
            this.DiscountColumn.ReadOnly = true;
            // 
            // CountryColumn
            // 
            this.CountryColumn.HeaderText = "Country";
            this.CountryColumn.Name = "CountryColumn";
            this.CountryColumn.ReadOnly = true;
            // 
            // datagridContext
            // 
            this.datagridContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProductToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.datagridContext.Name = "datagridContext";
            this.datagridContext.Size = new System.Drawing.Size(140, 54);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // treeviewPanel
            // 
            this.treeviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.treeviewPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.treeviewPanel.BorderRadius = 1;
            this.treeviewPanel.BorderThickness = 1;
            this.treeviewPanel.Controls.Add(this.treeView);
            this.treeviewPanel.Controls.Add(this.panelButton);
            this.treeviewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeviewPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.treeviewPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.treeviewPanel.Location = new System.Drawing.Point(3, 3);
            this.treeviewPanel.Name = "treeviewPanel";
            this.treeviewPanel.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.treeviewPanel.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.treeviewPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.treeviewPanel.ShadowDept = 2;
            this.treeviewPanel.ShadowDepth = 5;
            this.treeviewPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.treeviewPanel.ShadowTopLeftVisible = false;
            this.treeviewPanel.Size = new System.Drawing.Size(176, 741);
            this.treeviewPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.treeviewPanel.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.contextTreeview;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 48);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(176, 693);
            this.treeView.TabIndex = 0;
            this.treeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDoubleClick);
            // 
            // contextTreeview
            // 
            this.contextTreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStrip,
            this.editNodeStrip,
            this.addProductStrip,
            this.createChildNodeStrip,
            this.toolStripMenuItem1,
            this.deleteChildNodeStrip});
            this.contextTreeview.Name = "contextTreeview";
            this.contextTreeview.Size = new System.Drawing.Size(172, 120);
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.Size = new System.Drawing.Size(171, 22);
            this.openToolStrip.Text = "Open";
            this.openToolStrip.Click += new System.EventHandler(this.openToolStrip_Click);
            // 
            // editNodeStrip
            // 
            this.editNodeStrip.Name = "editNodeStrip";
            this.editNodeStrip.Size = new System.Drawing.Size(171, 22);
            this.editNodeStrip.Text = "Edit";
            this.editNodeStrip.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addProductStrip
            // 
            this.addProductStrip.Name = "addProductStrip";
            this.addProductStrip.Size = new System.Drawing.Size(171, 22);
            this.addProductStrip.Text = "Add product";
            this.addProductStrip.Click += new System.EventHandler(this.addDataProduct_Click);
            // 
            // createChildNodeStrip
            // 
            this.createChildNodeStrip.Name = "createChildNodeStrip";
            this.createChildNodeStrip.Size = new System.Drawing.Size(171, 22);
            this.createChildNodeStrip.Text = "Create Child Node";
            this.createChildNodeStrip.Click += new System.EventHandler(this.createChildNodeStrip_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // deleteChildNodeStrip
            // 
            this.deleteChildNodeStrip.Name = "deleteChildNodeStrip";
            this.deleteChildNodeStrip.Size = new System.Drawing.Size(171, 22);
            this.deleteChildNodeStrip.Text = "Delete";
            this.deleteChildNodeStrip.Click += new System.EventHandler(this.deleteChildNodeStrip_Click);
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = false;
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
            // colorTransitionSide
            // 
            this.colorTransitionSide.AutoTransition = false;
            this.colorTransitionSide.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Purple,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
            this.colorTransitionSide.EndColor = System.Drawing.Color.White;
            this.colorTransitionSide.Interval = 10;
            this.colorTransitionSide.ProgessValue = 0;
            this.colorTransitionSide.StartColor = System.Drawing.Color.White;
            this.colorTransitionSide.TransitionControl = this.sidebarPanel;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 10;
            this.bunifuElipse.TargetControl = this;
            // 
            // thirdDashboardPanel
            // 
            this.thirdDashboardPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thirdDashboardPanel.AutoSize = true;
            this.thirdDashboardPanel.BackgroundColor = System.Drawing.Color.LightGray;
            this.thirdDashboardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdDashboardPanel.BackgroundImage")));
            this.thirdDashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdDashboardPanel.BorderColor = System.Drawing.Color.Transparent;
            this.thirdDashboardPanel.BorderRadius = 3;
            this.thirdDashboardPanel.BorderThickness = 1;
            this.thirdDashboardPanel.Controls.Add(this.secondChartDashboard);
            this.thirdDashboardPanel.Controls.Add(this.chartDashboard);
            this.thirdDashboardPanel.Controls.Add(this.statisticsLabel);
            this.thirdDashboardPanel.Location = new System.Drawing.Point(31, 307);
            this.thirdDashboardPanel.Name = "thirdDashboardPanel";
            this.thirdDashboardPanel.ShowBorders = true;
            this.thirdDashboardPanel.Size = new System.Drawing.Size(963, 424);
            this.thirdDashboardPanel.TabIndex = 5;
            // 
            // secondChartDashboard
            // 
            this.secondChartDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondChartDashboard.BackColor = System.Drawing.Color.Moccasin;
            this.secondChartDashboard.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.secondChartDashboard.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.secondChartDashboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.secondChartDashboard.Legends.Add(legend1);
            this.secondChartDashboard.Location = new System.Drawing.Point(480, 56);
            this.secondChartDashboard.Name = "secondChartDashboard";
            this.secondChartDashboard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.secondChartDashboard.Size = new System.Drawing.Size(471, 346);
            this.secondChartDashboard.TabIndex = 7;
            this.secondChartDashboard.Text = "chart";
            // 
            // chartDashboard
            // 
            this.chartDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartDashboard.BackColor = System.Drawing.Color.Moccasin;
            this.chartDashboard.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartDashboard.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDashboard.Legends.Add(legend2);
            this.chartDashboard.Location = new System.Drawing.Point(27, 56);
            this.chartDashboard.Name = "chartDashboard";
            this.chartDashboard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartDashboard.Size = new System.Drawing.Size(447, 346);
            this.chartDashboard.TabIndex = 6;
            this.chartDashboard.Text = "chart";
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AllowParentOverrides = false;
            this.statisticsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statisticsLabel.AutoEllipsis = false;
            this.statisticsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.statisticsLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.statisticsLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.statisticsLabel.ForeColor = System.Drawing.Color.Black;
            this.statisticsLabel.Location = new System.Drawing.Point(34, 20);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statisticsLabel.Size = new System.Drawing.Size(237, 30);
            this.statisticsLabel.TabIndex = 4;
            this.statisticsLabel.Text = "Total program statistics:";
            this.statisticsLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.statisticsLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // secondDashboardPanel
            // 
            this.secondDashboardPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondDashboardPanel.BackgroundColor = System.Drawing.Color.LightGray;
            this.secondDashboardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondDashboardPanel.BackgroundImage")));
            this.secondDashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondDashboardPanel.BorderColor = System.Drawing.Color.Transparent;
            this.secondDashboardPanel.BorderRadius = 3;
            this.secondDashboardPanel.BorderThickness = 1;
            this.secondDashboardPanel.Controls.Add(this.nodePicture);
            this.secondDashboardPanel.Controls.Add(this.totalNodesLabel);
            this.secondDashboardPanel.Controls.Add(this.totalNodesNumLabel);
            this.secondDashboardPanel.Location = new System.Drawing.Point(549, 54);
            this.secondDashboardPanel.Name = "secondDashboardPanel";
            this.secondDashboardPanel.ShowBorders = true;
            this.secondDashboardPanel.Size = new System.Drawing.Size(414, 153);
            this.secondDashboardPanel.TabIndex = 4;
            // 
            // nodePicture
            // 
            this.nodePicture.AllowFocused = false;
            this.nodePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nodePicture.AutoSizeHeight = true;
            this.nodePicture.BackColor = System.Drawing.Color.Transparent;
            this.nodePicture.BorderRadius = 0;
            this.nodePicture.Image = global::Warehouse.Properties.Resources.node;
            this.nodePicture.IsCircle = true;
            this.nodePicture.Location = new System.Drawing.Point(266, 21);
            this.nodePicture.Name = "nodePicture";
            this.nodePicture.Size = new System.Drawing.Size(115, 115);
            this.nodePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nodePicture.TabIndex = 7;
            this.nodePicture.TabStop = false;
            this.nodePicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // totalNodesLabel
            // 
            this.totalNodesLabel.AllowParentOverrides = false;
            this.totalNodesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalNodesLabel.AutoEllipsis = false;
            this.totalNodesLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalNodesLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.totalNodesLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.totalNodesLabel.ForeColor = System.Drawing.Color.Black;
            this.totalNodesLabel.Location = new System.Drawing.Point(77, 79);
            this.totalNodesLabel.Name = "totalNodesLabel";
            this.totalNodesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalNodesLabel.Size = new System.Drawing.Size(115, 30);
            this.totalNodesLabel.TabIndex = 6;
            this.totalNodesLabel.Text = "Total nodes";
            this.totalNodesLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.totalNodesLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // totalNodesNumLabel
            // 
            this.totalNodesNumLabel.AllowParentOverrides = false;
            this.totalNodesNumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalNodesNumLabel.AutoEllipsis = false;
            this.totalNodesNumLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalNodesNumLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.totalNodesNumLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.totalNodesNumLabel.ForeColor = System.Drawing.Color.Black;
            this.totalNodesNumLabel.Location = new System.Drawing.Point(124, 16);
            this.totalNodesNumLabel.Name = "totalNodesNumLabel";
            this.totalNodesNumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalNodesNumLabel.Size = new System.Drawing.Size(16, 37);
            this.totalNodesNumLabel.TabIndex = 5;
            this.totalNodesNumLabel.Text = "0";
            this.totalNodesNumLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.totalNodesNumLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // firstDashboardPanel
            // 
            this.firstDashboardPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstDashboardPanel.BackgroundColor = System.Drawing.Color.LightGray;
            this.firstDashboardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstDashboardPanel.BackgroundImage")));
            this.firstDashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstDashboardPanel.BorderColor = System.Drawing.Color.Transparent;
            this.firstDashboardPanel.BorderRadius = 3;
            this.firstDashboardPanel.BorderThickness = 1;
            this.firstDashboardPanel.Controls.Add(this.filePicture);
            this.firstDashboardPanel.Controls.Add(this.totalFilesLabel);
            this.firstDashboardPanel.Controls.Add(this.totalFilesNumLabel);
            this.firstDashboardPanel.Location = new System.Drawing.Point(58, 54);
            this.firstDashboardPanel.Name = "firstDashboardPanel";
            this.firstDashboardPanel.ShowBorders = true;
            this.firstDashboardPanel.Size = new System.Drawing.Size(407, 153);
            this.firstDashboardPanel.TabIndex = 3;
            // 
            // filePicture
            // 
            this.filePicture.AllowFocused = false;
            this.filePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filePicture.AutoSizeHeight = true;
            this.filePicture.BackColor = System.Drawing.Color.Transparent;
            this.filePicture.BorderRadius = 0;
            this.filePicture.Image = global::Warehouse.Properties.Resources.fileBigNew;
            this.filePicture.IsCircle = true;
            this.filePicture.Location = new System.Drawing.Point(289, 18);
            this.filePicture.Name = "filePicture";
            this.filePicture.Size = new System.Drawing.Size(115, 115);
            this.filePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filePicture.TabIndex = 4;
            this.filePicture.TabStop = false;
            this.filePicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // totalFilesLabel
            // 
            this.totalFilesLabel.AllowParentOverrides = false;
            this.totalFilesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalFilesLabel.AutoEllipsis = false;
            this.totalFilesLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalFilesLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.totalFilesLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.totalFilesLabel.ForeColor = System.Drawing.Color.Black;
            this.totalFilesLabel.Location = new System.Drawing.Point(109, 79);
            this.totalFilesLabel.Name = "totalFilesLabel";
            this.totalFilesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalFilesLabel.Size = new System.Drawing.Size(96, 30);
            this.totalFilesLabel.TabIndex = 3;
            this.totalFilesLabel.Text = "Total files";
            this.totalFilesLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.totalFilesLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // totalFilesNumLabel
            // 
            this.totalFilesNumLabel.AllowParentOverrides = false;
            this.totalFilesNumLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalFilesNumLabel.AutoEllipsis = false;
            this.totalFilesNumLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalFilesNumLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.totalFilesNumLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.totalFilesNumLabel.ForeColor = System.Drawing.Color.Black;
            this.totalFilesNumLabel.Location = new System.Drawing.Point(147, 13);
            this.totalFilesNumLabel.Name = "totalFilesNumLabel";
            this.totalFilesNumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalFilesNumLabel.Size = new System.Drawing.Size(16, 37);
            this.totalFilesNumLabel.TabIndex = 2;
            this.totalFilesNumLabel.Text = "0";
            this.totalFilesNumLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.totalFilesNumLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panelButton
            // 
            this.panelButton.BackgroundColor = System.Drawing.SystemColors.Window;
            this.panelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelButton.BackgroundImage")));
            this.panelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButton.BorderColor = System.Drawing.Color.Transparent;
            this.panelButton.BorderRadius = 1;
            this.panelButton.BorderThickness = 1;
            this.panelButton.Controls.Add(this.thirdPanelButton);
            this.panelButton.Controls.Add(this.secondPanelButton);
            this.panelButton.Controls.Add(this.addNodeButton);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.ShowBorders = true;
            this.panelButton.Size = new System.Drawing.Size(176, 48);
            this.panelButton.TabIndex = 1;
            // 
            // thirdPanelButton
            // 
            this.thirdPanelButton.Controls.Add(this.csvButton);
            this.thirdPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdPanelButton.Location = new System.Drawing.Point(0, 23);
            this.thirdPanelButton.Name = "thirdPanelButton";
            this.thirdPanelButton.Size = new System.Drawing.Size(86, 25);
            this.thirdPanelButton.TabIndex = 10;
            // 
            // csvButton
            // 
            this.csvButton.AllowAnimations = true;
            this.csvButton.AllowMouseEffects = true;
            this.csvButton.AllowToggling = true;
            this.csvButton.AnimationSpeed = 200;
            this.csvButton.AutoGenerateColors = false;
            this.csvButton.AutoRoundBorders = false;
            this.csvButton.AutoSizeLeftIcon = true;
            this.csvButton.AutoSizeRightIcon = true;
            this.csvButton.BackColor = System.Drawing.Color.Transparent;
            this.csvButton.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.csvButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("csvButton.BackgroundImage")));
            this.csvButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.csvButton.ButtonText = "CSV";
            this.csvButton.ButtonTextMarginLeft = 0;
            this.csvButton.ColorContrastOnClick = 45;
            this.csvButton.ColorContrastOnHover = 45;
            this.csvButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.csvButton.CustomizableEdges = borderEdges3;
            this.csvButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.csvButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.csvButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.csvButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.csvButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.csvButton.Enabled = false;
            this.csvButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.csvButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.csvButton.ForeColor = System.Drawing.Color.DimGray;
            this.csvButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.csvButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.csvButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.csvButton.IconMarginLeft = 11;
            this.csvButton.IconPadding = 13;
            this.csvButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.csvButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.csvButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.csvButton.IconSize = 25;
            this.csvButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.csvButton.IdleBorderRadius = 1;
            this.csvButton.IdleBorderThickness = 1;
            this.csvButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.csvButton.IdleIconLeftImage = null;
            this.csvButton.IdleIconRightImage = null;
            this.csvButton.IndicateFocus = true;
            this.csvButton.Location = new System.Drawing.Point(0, 0);
            this.csvButton.Name = "csvButton";
            this.csvButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.csvButton.OnDisabledState.BorderRadius = 1;
            this.csvButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.csvButton.OnDisabledState.BorderThickness = 1;
            this.csvButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.csvButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.csvButton.OnDisabledState.IconLeftImage = null;
            this.csvButton.OnDisabledState.IconRightImage = null;
            this.csvButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.csvButton.onHoverState.BorderRadius = 1;
            this.csvButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.csvButton.onHoverState.BorderThickness = 1;
            this.csvButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.csvButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.csvButton.onHoverState.IconLeftImage = null;
            this.csvButton.onHoverState.IconRightImage = null;
            this.csvButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.csvButton.OnIdleState.BorderRadius = 1;
            this.csvButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.csvButton.OnIdleState.BorderThickness = 1;
            this.csvButton.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.csvButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.csvButton.OnIdleState.IconLeftImage = null;
            this.csvButton.OnIdleState.IconRightImage = null;
            this.csvButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.csvButton.OnPressedState.BorderRadius = 1;
            this.csvButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.csvButton.OnPressedState.BorderThickness = 1;
            this.csvButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.csvButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.csvButton.OnPressedState.IconLeftImage = null;
            this.csvButton.OnPressedState.IconRightImage = null;
            this.csvButton.Size = new System.Drawing.Size(86, 23);
            this.csvButton.TabIndex = 8;
            this.csvButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.csvButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.csvButton.TextMarginLeft = 0;
            this.csvButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.csvButton.UseDefaultRadiusAndThickness = true;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // secondPanelButton
            // 
            this.secondPanelButton.Controls.Add(this.sortButton);
            this.secondPanelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.secondPanelButton.Location = new System.Drawing.Point(86, 23);
            this.secondPanelButton.Name = "secondPanelButton";
            this.secondPanelButton.Size = new System.Drawing.Size(90, 25);
            this.secondPanelButton.TabIndex = 9;
            // 
            // sortButton
            // 
            this.sortButton.AllowAnimations = true;
            this.sortButton.AllowMouseEffects = true;
            this.sortButton.AllowToggling = true;
            this.sortButton.AnimationSpeed = 200;
            this.sortButton.AutoGenerateColors = false;
            this.sortButton.AutoRoundBorders = false;
            this.sortButton.AutoSizeLeftIcon = true;
            this.sortButton.AutoSizeRightIcon = true;
            this.sortButton.BackColor = System.Drawing.Color.Transparent;
            this.sortButton.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.sortButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton.BackgroundImage")));
            this.sortButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortButton.ButtonText = "Sort";
            this.sortButton.ButtonTextMarginLeft = 0;
            this.sortButton.ColorContrastOnClick = 45;
            this.sortButton.ColorContrastOnHover = 45;
            this.sortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.sortButton.CustomizableEdges = borderEdges4;
            this.sortButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sortButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.sortButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sortButton.ForeColor = System.Drawing.Color.DimGray;
            this.sortButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.sortButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.sortButton.IconMarginLeft = 11;
            this.sortButton.IconPadding = 13;
            this.sortButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sortButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.sortButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.sortButton.IconSize = 25;
            this.sortButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.sortButton.IdleBorderRadius = 1;
            this.sortButton.IdleBorderThickness = 1;
            this.sortButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.sortButton.IdleIconLeftImage = null;
            this.sortButton.IdleIconRightImage = null;
            this.sortButton.IndicateFocus = true;
            this.sortButton.Location = new System.Drawing.Point(0, 0);
            this.sortButton.Name = "sortButton";
            this.sortButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortButton.OnDisabledState.BorderRadius = 1;
            this.sortButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortButton.OnDisabledState.BorderThickness = 1;
            this.sortButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortButton.OnDisabledState.IconLeftImage = null;
            this.sortButton.OnDisabledState.IconRightImage = null;
            this.sortButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.sortButton.onHoverState.BorderRadius = 1;
            this.sortButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortButton.onHoverState.BorderThickness = 1;
            this.sortButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.sortButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.sortButton.onHoverState.IconLeftImage = null;
            this.sortButton.onHoverState.IconRightImage = null;
            this.sortButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.sortButton.OnIdleState.BorderRadius = 1;
            this.sortButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortButton.OnIdleState.BorderThickness = 1;
            this.sortButton.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.sortButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.sortButton.OnIdleState.IconLeftImage = null;
            this.sortButton.OnIdleState.IconRightImage = null;
            this.sortButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.sortButton.OnPressedState.BorderRadius = 1;
            this.sortButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortButton.OnPressedState.BorderThickness = 1;
            this.sortButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.sortButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.sortButton.OnPressedState.IconLeftImage = null;
            this.sortButton.OnPressedState.IconRightImage = null;
            this.sortButton.Size = new System.Drawing.Size(90, 23);
            this.sortButton.TabIndex = 9;
            this.sortButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sortButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sortButton.TextMarginLeft = 0;
            this.sortButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.sortButton.UseDefaultRadiusAndThickness = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // addNodeButton
            // 
            this.addNodeButton.AllowAnimations = true;
            this.addNodeButton.AllowMouseEffects = true;
            this.addNodeButton.AllowToggling = true;
            this.addNodeButton.AnimationSpeed = 200;
            this.addNodeButton.AutoGenerateColors = false;
            this.addNodeButton.AutoRoundBorders = false;
            this.addNodeButton.AutoSizeLeftIcon = true;
            this.addNodeButton.AutoSizeRightIcon = true;
            this.addNodeButton.BackColor = System.Drawing.Color.Transparent;
            this.addNodeButton.BackColor1 = System.Drawing.Color.Gainsboro;
            this.addNodeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNodeButton.BackgroundImage")));
            this.addNodeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addNodeButton.ButtonText = "Add Node";
            this.addNodeButton.ButtonTextMarginLeft = 0;
            this.addNodeButton.ColorContrastOnClick = 45;
            this.addNodeButton.ColorContrastOnHover = 45;
            this.addNodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.addNodeButton.CustomizableEdges = borderEdges5;
            this.addNodeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addNodeButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addNodeButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addNodeButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addNodeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNodeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.addNodeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addNodeButton.ForeColor = System.Drawing.Color.DimGray;
            this.addNodeButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNodeButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.addNodeButton.IconLeftPadding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.addNodeButton.IconMarginLeft = 11;
            this.addNodeButton.IconPadding = 13;
            this.addNodeButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNodeButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.addNodeButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addNodeButton.IconSize = 25;
            this.addNodeButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.addNodeButton.IdleBorderRadius = 1;
            this.addNodeButton.IdleBorderThickness = 1;
            this.addNodeButton.IdleFillColor = System.Drawing.Color.Gainsboro;
            this.addNodeButton.IdleIconLeftImage = null;
            this.addNodeButton.IdleIconRightImage = null;
            this.addNodeButton.IndicateFocus = true;
            this.addNodeButton.Location = new System.Drawing.Point(0, 0);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addNodeButton.OnDisabledState.BorderRadius = 1;
            this.addNodeButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addNodeButton.OnDisabledState.BorderThickness = 1;
            this.addNodeButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addNodeButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addNodeButton.OnDisabledState.IconLeftImage = null;
            this.addNodeButton.OnDisabledState.IconRightImage = null;
            this.addNodeButton.onHoverState.BorderColor = System.Drawing.Color.White;
            this.addNodeButton.onHoverState.BorderRadius = 1;
            this.addNodeButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addNodeButton.onHoverState.BorderThickness = 1;
            this.addNodeButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.addNodeButton.onHoverState.ForeColor = System.Drawing.Color.LightSalmon;
            this.addNodeButton.onHoverState.IconLeftImage = null;
            this.addNodeButton.onHoverState.IconRightImage = null;
            this.addNodeButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.addNodeButton.OnIdleState.BorderRadius = 1;
            this.addNodeButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addNodeButton.OnIdleState.BorderThickness = 1;
            this.addNodeButton.OnIdleState.FillColor = System.Drawing.Color.Gainsboro;
            this.addNodeButton.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.addNodeButton.OnIdleState.IconLeftImage = null;
            this.addNodeButton.OnIdleState.IconRightImage = null;
            this.addNodeButton.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.addNodeButton.OnPressedState.BorderRadius = 1;
            this.addNodeButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addNodeButton.OnPressedState.BorderThickness = 1;
            this.addNodeButton.OnPressedState.FillColor = System.Drawing.Color.White;
            this.addNodeButton.OnPressedState.ForeColor = System.Drawing.Color.LightSalmon;
            this.addNodeButton.OnPressedState.IconLeftImage = null;
            this.addNodeButton.OnPressedState.IconRightImage = null;
            this.addNodeButton.Size = new System.Drawing.Size(176, 23);
            this.addNodeButton.TabIndex = 8;
            this.addNodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNodeButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addNodeButton.TextMarginLeft = 0;
            this.addNodeButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.addNodeButton.UseDefaultRadiusAndThickness = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Orange;
            this.indicator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.indicator.Location = new System.Drawing.Point(3, 83);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(4, 57);
            this.indicator.TabIndex = 3;
            this.indicator.TabStop = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.fileButton.CustomizableEdges = borderEdges1;
            this.fileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fileButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.fileButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fileButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.fileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.fileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
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
            this.fileButton.IdleIconLeftImage = global::Warehouse.Properties.Resources.Sidebar_Documents_icon;
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
            this.fileButton.OnIdleState.IconLeftImage = global::Warehouse.Properties.Resources.Sidebar_Documents_icon;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.menuButton.CustomizableEdges = borderEdges2;
            this.menuButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.menuButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menuButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
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
            this.logoPanel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.BorderColor = System.Drawing.Color.Transparent;
            this.logoPanel.BorderRadius = 3;
            this.logoPanel.BorderThickness = 1;
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Controls.Add(this.logoPicture);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.ShowBorders = true;
            this.logoPanel.Size = new System.Drawing.Size(190, 69);
            this.logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AllowParentOverrides = false;
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoLabel.AutoEllipsis = false;
            this.logoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.logoLabel.Location = new System.Drawing.Point(90, 26);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoLabel.Size = new System.Drawing.Size(77, 21);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Welcome!";
            this.logoLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.logoLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // logoPicture
            // 
            this.logoPicture.AllowFocused = false;
            this.logoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPicture.AutoSizeHeight = true;
            this.logoPicture.BorderRadius = 36;
            this.logoPicture.Image = global::Warehouse.Properties.Resources.dashboard;
            this.logoPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoPicture.IsCircle = true;
            this.logoPicture.Location = new System.Drawing.Point(12, 4);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(72, 72);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            this.logoPicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.logoPicture.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            this.logoPicture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.logoPicture_MouseDoubleClick);
            // 
            // topbarPanel
            // 
            this.topbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(182)))));
            this.topbarPanel.BackgroundColor = System.Drawing.Color.Gainsboro;
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
            this.topbarPanel.Size = new System.Drawing.Size(1200, 27);
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.hideButton.CustomizableEdges = borderEdges6;
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
            this.hideButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.hideButton.OnPressedState.BorderRadius = 1;
            this.hideButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hideButton.OnPressedState.BorderThickness = 1;
            this.hideButton.OnPressedState.FillColor = System.Drawing.Color.Transparent;
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
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges7;
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
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Transparent;
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
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.exitButton.CustomizableEdges = borderEdges8;
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
            this.exitButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.exitButton.OnPressedState.BorderRadius = 1;
            this.exitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exitButton.OnPressedState.BorderThickness = 1;
            this.exitButton.OnPressedState.FillColor = System.Drawing.Color.Transparent;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.controlPage);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.controlPage.ResumeLayout(false);
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            this.filePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.datagridContext.ResumeLayout(false);
            this.treeviewPanel.ResumeLayout(false);
            this.contextTreeview.ResumeLayout(false);
            this.thirdDashboardPanel.ResumeLayout(false);
            this.thirdDashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondChartDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.secondDashboardPanel.ResumeLayout(false);
            this.secondDashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodePicture)).EndInit();
            this.firstDashboardPanel.ResumeLayout(false);
            this.firstDashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePicture)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.thirdPanelButton.ResumeLayout(false);
            this.secondPanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.topbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuShadowPanel sidebarPanel;
        private Bunifu.UI.WinForms.BunifuPanel logoPanel;
        private Bunifu.UI.WinForms.BunifuPanel topbarPanel;
        private Bunifu.UI.WinForms.BunifuPages controlPage;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.TabPage filePage;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton menuButton;
        private System.Windows.Forms.PictureBox indicator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton fileButton;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        private Bunifu.UI.WinForms.BunifuLabel logoLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox logoPicture;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton hideButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuLabel dashboardLabelIntro;
        private Bunifu.UI.WinForms.BunifuColorTransition colorTransitionSide;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridProduct;
        private Bunifu.UI.WinForms.BunifuShadowPanel treeviewPanel;
        private System.Windows.Forms.ContextMenuStrip contextTreeview;
        private System.Windows.Forms.ToolStripMenuItem editNodeStrip;
        private System.Windows.Forms.ToolStripMenuItem createChildNodeStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteChildNodeStrip;
        private Bunifu.UI.WinForms.BunifuPanel panelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addNodeButton;
        private System.Windows.Forms.ToolStripMenuItem addProductStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountColumn;
        private System.Windows.Forms.ContextMenuStrip datagridContext;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem openToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryColumn;
        private System.Windows.Forms.Panel thirdPanelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton csvButton;
        private System.Windows.Forms.Panel secondPanelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton sortButton;
        private Bunifu.UI.WinForms.BunifuPanel thirdDashboardPanel;
        private Bunifu.UI.WinForms.BunifuPanel secondDashboardPanel;
        private Bunifu.UI.WinForms.BunifuPanel firstDashboardPanel;
        private Bunifu.UI.WinForms.BunifuLabel totalFilesLabel;
        private Bunifu.UI.WinForms.BunifuLabel totalFilesNumLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox filePicture;
        private Bunifu.UI.WinForms.BunifuPictureBox nodePicture;
        private Bunifu.UI.WinForms.BunifuLabel totalNodesLabel;
        private Bunifu.UI.WinForms.BunifuLabel totalNodesNumLabel;
        private Bunifu.UI.WinForms.BunifuLabel statisticsLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private BunifuElipse bunifuElipse;
        private System.Windows.Forms.DataVisualization.Charting.Chart secondChartDashboard;
    }
}

