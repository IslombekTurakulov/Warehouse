using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        // Assgigning variables
        private static FileClass fileClasses;
        private AddFileForm addFileForm;
        private string nodeViewName;
        private bool nodeViewNameBoolean;
        private bool isClosedForm;
        private readonly List<TreeNode> node = new List<TreeNode>();

        public MainForm()
        {
            // Adding event handler
            // It helps to control the data from Form to another Form.
            Program.CallBackMy.CallbackEventHandler = this.GetData;
            Program.CallBackMy.AddTreeViewEventHandler = this.AddTreeView;
            InitializeComponent();
            // Maximize the program window.
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            // Enables dragging.
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
            bunifuFormDock.SubscribeControlToDragEvents(logoPanel);
        }

        #region Events
        /// <summary>
        /// This method receiving class and boolean variable.
        /// </summary>
        /// <param name="file">New Product Class</param>
        /// <param name="isClosed">Boolean variable</param>
        void GetData(FileClass file, bool isClosed)
        {
            fileClasses = file;
            isClosedForm = isClosed;
        }

        /// <summary>
        /// This method receiving 
        /// </summary>
        /// <param name="nodeviewname"></param>
        /// <param name="nodeviewnameboolean"></param>
        private void AddTreeView(string nodeviewname, bool nodeviewnameboolean)
        {
            nodeViewName = nodeviewname;
            nodeViewNameBoolean = nodeviewnameboolean;
        }
        #endregion

        #region Settings

        /// <summary>
        /// Exit method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Are you sure want to exit?",
                "Program exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// MainForm Settings 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowButton_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        /// <summary>
        /// MainForm Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizeWindow_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        /// <summary>
        /// Button Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(dashboardPage);
        }

        /// <summary>
        /// Button Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(filePage);
        }


        /// <summary>
        /// Logo secret method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BunifuPictureBox_Click(object sender, EventArgs e)
        {
            colorTransitionSide.Interval = 20;
            topbarColorTransition.ColorArray = colorTransitionSide.ColorArray;
            topbarColorTransition.Start();
            colorTransitionSide.Start();
            logoPicture.BackColor = Color.WhiteSmoke;
            logoPicture.ForeColor = Color.WhiteSmoke;
        }

        /// <summary>
        /// Stops the color transition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoPicture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            topbarColorTransition.Stop();
            colorTransitionSide.Stop();
        }

        #endregion

        /// <summary>
        /// Adds the product of node file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDataProduct_Click(object sender, EventArgs e)
        {
            try
            {
                isClosedForm = false;
                // Creating new form and showing it.
                addFileForm = new AddFileForm();
                addFileForm.ShowDialog();

                if (!isClosedForm)
                    return;

                // Creating new directory.
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                // If root doesn't exist, we create a new one.
                if (!newRootDit.Exists) newRootDit.Create();

                // FileStream function.
                using (var fileStreamWriter = new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    List<FileClass> listClasses = new List<FileClass>();
                    using var streamReader = new StreamReader(fileStreamWriter);
                    // In this loop, code will get all data from file 
                    // And add it to new List.
                    while (streamReader.Peek() > -1)
                    {
                        string input = streamReader.ReadToEnd();
                        // Validation.
                        if (input == string.Empty)
                            throw new ArgumentException("File is empty");
                        if (input.Length < 10)
                            throw new ArgumentException("File is empty");
                        // Deserializing file.
                        var restoredPerson =
                            JsonSerializer.Deserialize<List<FileClass>>(input);
                        // Adding data to new list.
                        if (restoredPerson != null)
                            listClasses.AddRange(restoredPerson);
                    }
                    // And the we add the new one
                    // Which was applied by AddFileForm
                    listClasses?.Add(fileClasses);
                    // Going back to first position.
                    fileStreamWriter.Position = 0;
                    using var streamWriter = new StreamWriter(fileStreamWriter);
                    // Serializing.
                    streamWriter.WriteLine(JsonSerializer.Serialize(listClasses));

                    // Refreshing the main dashboard.
                    RefreshDashboard();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Edit node name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                // Validation. If this directory exists.
                if (!newRootDit.Exists) newRootDit.Create();
                nodeViewNameBoolean = false;
                // Calling form.
                EditTreeName editTree = new EditTreeName();
                editTree.ShowDialog();
                if (!nodeViewNameBoolean) 
                    return;
                // Renaming the filename using File.Move().
                File.Move($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json", $"{newRootDit.FullName}/{nodeViewName}.json");
                treeView.SelectedNode.Text = nodeViewName;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Add the node to treeview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                nodeViewName = "";
                nodeViewNameBoolean = false;
                // Calling form.
                var editTreeName = new EditTreeName();
                editTreeName.ShowDialog();

                if (!nodeViewNameBoolean) return;
                if (treeView.Nodes.Cast<TreeNode>().Any(nodes => nodes.Text == nodeViewName))
                    throw new ArgumentException("Node is already exist!");

                // Checking, if this directory exists.
                var newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists) newRootDit.Create();
                using (FileStream fs =
                    new FileStream($"{newRootDit.FullName}/{nodeViewName}.json",
                        FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    // Creating.
                    var sw = new StreamWriter(fs);
                    sw.Write("");
                }
                // Adding new node to treeview.
                treeView.Nodes.Add(nodeViewName);
                // Saving treeview.
                SaveTree("DataNodes.xml", treeView);
                RefreshDashboard();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Creates child node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createChildNodeStrip_Click(object sender, EventArgs e)
        {
            try
            {
                var name = treeView.SelectedNode;
                nodeViewName = "";
                nodeViewNameBoolean = false;
                // Creating new form.
                var editTreeName = new EditTreeName();
                editTreeName.ShowDialog();
                // If this node is exists.
                if (treeView.Nodes.Cast<TreeNode>().Any(nodes => nodes.Text == nodeViewName))
                    throw new ArgumentException("Node is already exist!");

                if (!nodeViewNameBoolean) return;
                var newRootDit = new DirectoryInfo("data");
                // Validation.
                if (!newRootDit.Exists) newRootDit.Create();
                using (FileStream fs =
                    new FileStream($"{newRootDit.FullName}/{nodeViewName}.json",
                        FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var sw = new StreamWriter(fs);
                    sw.Write("");
                }
                // Checking if this node exist,
                var treeNode = new TreeNode(nodeViewName);
                if (!treeView.Nodes.Contains(treeNode))
                    name.Nodes.Add(nodeViewName);
                else
                    throw new ArgumentException("The name of node is already exist!");
                // Save treeview.
                SaveTree("DataNodes.xml", treeView);
                treeView.ExpandAll();
                RefreshDashboard();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Checking the directory.
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists)
                    newRootDit.Create();
                else
                {
                    // Checking the datagrid.
                    if (dataGridProduct.Rows.Count > 0)
                        dataGridProduct.Rows.Clear();
                    // Checking the existance of file.
                    var path = $"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json";
                    if (!File.Exists(path))
                    {
                        treeView.Nodes.Remove(treeView.SelectedNode);
                        throw new ArgumentException("File doesn't exist");
                    }

                    using (FileStream fs =
                        new FileStream(path,
                            FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using var sReader = new StreamReader(fs);
                        // While loop.
                        while (sReader.Peek() > -1)
                        {
                            string input = sReader.ReadToEnd();
                            // Validation.
                            if (input == String.Empty)
                                throw new ArgumentException("File is empty");
                            if (input.Length < 10)
                                throw new ArgumentException("File is empty");
                            // Deserializing the file to class.
                            List<FileClass> listOfRestoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input);
                            if (listOfRestoredPerson == null) continue;
                            // Adding the information to datagrid.
                            foreach (var restoredPerson in listOfRestoredPerson)
                            {
                                dataGridProduct.Rows.Add(restoredPerson?.Name, restoredPerson?.Code,
                                    restoredPerson?.UCN, restoredPerson?.Company,
                                    restoredPerson?.Amount, restoredPerson?.Cost,
                                    restoredPerson?.Currency, restoredPerson?.Warranty,
                                    restoredPerson?.Status, restoredPerson?.Discount,
                                    restoredPerson?.Country);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Mainform close event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => SaveTree("DataNodes.xml", treeView);

        /// <summary>
        /// Mainform load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string fileXml = "DataNodes.xml";
                // If file exists.
                if (!File.Exists(fileXml))
                    return;
                // Deserializing file.
                var data = DeserializeFromFile<DataNode[]>(fileXml);
                foreach (var d in data)
                {
                    // Adding node to treeview and filling.
                    var treeNode = new TreeNode();
                    treeView.Nodes.Add(treeNode);
                    FillNode(treeView, treeNode, d);
                }
                treeView.ExpandAll();
                // If nodes is greater than 1
                if (treeView.Nodes.Count >= 1)
                {
                    csvButton.Enabled = true;
                }

                RefreshDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method of refreshing dashboard information.
        /// </summary>
        private void RefreshDashboard()
        {

            try
            {
                var newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists) newRootDit.Create();
                // How many files in this directory.
                var amountOfFiles = newRootDit.GetFiles().Length;
                // Variables.
                totalFilesNumLabel.Text = $@"{amountOfFiles}";
                totalNodesNumLabel.Text = $@"{treeView.Nodes.Count}";

                List<CSVClassAnalyzer> tempFileClasses = new List<CSVClassAnalyzer>();
                CallRecursive(treeView);

                foreach (var treeNode in node.Where(treeNode => File.Exists($"{newRootDit.FullName}/{treeNode.Text}.json")))
                {
                    using (var fs =
                        new FileStream($"{newRootDit.FullName}/{treeNode.Text}.json",
                            FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        // creating new object.
                        using var sReader = new StreamReader(fs);
                        while (sReader.Peek() > -1)
                        {
                            var input = sReader.ReadToEnd();
                            // Validation.
                            if (input == string.Empty)
                                continue;
                            if (input.Length < 10)
                                continue;
                            // Deserialization.
                            var listOfRestoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input);
                            // Adding classes to new list.
                            if (listOfRestoredPerson != null)
                                tempFileClasses.AddRange(from data in listOfRestoredPerson
                                                         select new CSVClassAnalyzer
                                                         {
                                                             Country = data.Country,
                                                             Name = data.Name,
                                                             Amount = data.Amount,
                                                             Cost = data.Cost
                                                         });
                        }
                    }
                }
                // Adding the new series.
                var series = chartDashboard.Series.Add("Total amount and cost");
                chartDashboard.Titles.Add("Total amount and cost");
                // Adding the data.
                foreach (var data in tempFileClasses)
                    series.Points.AddXY(data.Cost, data.Amount);
                // Adding the new series.
                var secondSeries = secondChartDashboard.Series.Add("Total name and country");
                secondChartDashboard.Titles.Add("Total name and country");
                // Adding the data.
                foreach (var data in tempFileClasses)
                    secondSeries.Points.AddXY(data.Name, data.Cost);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Method which serializes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void SerializeToFile<T>(T data, string filename)
        {
            using (var sw = new StreamWriter(filename))
            {
                // Xml serializer.
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(sw, data);
            }
        }
        
        /// <summary>
        /// Method of deserialization.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fname"></param>
        /// <returns></returns>
        public static T DeserializeFromFile<T>(string fname) where T : class
        {
            using (var sr = new StreamReader(fname))
            {
                // Xml serialization.
                var ser = new XmlSerializer(typeof(T));
                var data = ser.Deserialize(sr) as T;
                return data;
            }
        }
        /// <summary>
        /// Filling node to treeview.
        /// </summary>
        /// <param name="tempTreeView">TreeView</param>
        /// <param name="node">TreeNode</param>
        /// <param name="dataNode">DataNode</param>
        private static void FillNode(TreeView tempTreeView, TreeNode node, DataNode dataNode)
        {
            foreach (var c in dataNode.Nodes)
            {
                var n = new TreeNode();
                FillNode(tempTreeView, n, c);
                node.Nodes.Add(n);
            }
            // Adding info.
            node.Text = dataNode.Text;
            if (dataNode.IsExpanded) node.Expand();
            if (dataNode.IsSelected) tempTreeView.SelectedNode = node;
        }

        /// <summary>
        /// Method which saves the tree nodes.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="tv"></param>
        private static void SaveTree(string filename, TreeView tv)
        {
            var data = (from TreeNode node in tv.Nodes select GetDataNode(node)).ToList();
            SerializeToFile(data, filename);
        }

        /// <summary>
        /// Receives the datanode.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static DataNode GetDataNode(TreeNode node)
        {
            // Creating new object DataNode.
            var dataNode = new DataNode { Text = node.Text, IsExpanded = node.IsExpanded, IsSelected = node.IsSelected };
            foreach (TreeNode treeNode in node.Nodes)
            {
                // Adding node to datanode.
                var tempDataNode = GetDataNode(treeNode);
                tempDataNode.Nodes.Add(tempDataNode);
            }
            return dataNode;
        }

        /// <summary>
        /// Method which deletes the node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteChildNodeStrip_Click(object sender, EventArgs e)
        {
            try
            {
                // Directory validation.
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists)
                    newRootDit.Create();
                else
                {
                    var path = $"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json";
                    // File existance.
                    if (File.Exists(path))
                        File.Delete(path);
                    if (treeView.SelectedNode.Nodes.Count >= 1)
                    {
                        // Creating tree node collection.
                        TreeNodeCollection nodes = treeView.SelectedNode.Nodes;
                        foreach (TreeNode node in nodes)
                            File.Delete($"{node.Text}.json");
                    }
                    // Clear the nodes.
                    treeView.SelectedNode.Nodes.Clear();
                    // Removing nodes.
                    treeView.Nodes.Remove(treeView.SelectedNode);
                    csvButton.Enabled = treeView.Nodes.Count != 0;
                    // Clearing DataGrid rows.
                    dataGridProduct.Rows.Clear();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                // Checking the directory.
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists)
                    newRootDit.Create();
                else
                {
                    // Checking the datagrid.
                    if (dataGridProduct.Rows.Count > 0)
                        dataGridProduct.Rows.Clear();
                    // Checking the existance of file.
                    var path = $"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json";
                    if (!File.Exists(path))
                    {
                        treeView.Nodes.Remove(treeView.SelectedNode);
                        throw new ArgumentException("File doesn't exist");
                    }

                    using (FileStream fs =
                        new FileStream(path,
                            FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using var sReader = new StreamReader(fs);
                        // While loop.
                        while (sReader.Peek() > -1)
                        {
                            string input = sReader.ReadToEnd();
                            // Validation.
                            if (input == String.Empty)
                                throw new ArgumentException("File is empty");
                            if (input.Length < 10)
                                throw new ArgumentException("File is empty");
                            // Deserializing the file to class.
                            List<FileClass> listOfRestoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input);
                            if (listOfRestoredPerson == null) continue;
                            // Adding the information to datagrid.
                            foreach (var restoredPerson in listOfRestoredPerson)
                            {
                                dataGridProduct.Rows.Add(restoredPerson?.Name, restoredPerson?.Code,
                                    restoredPerson?.UCN, restoredPerson?.Company,
                                    restoredPerson?.Amount, restoredPerson?.Cost,
                                    restoredPerson?.Currency, restoredPerson?.Warranty,
                                    restoredPerson?.Status, restoredPerson?.Discount,
                                    restoredPerson?.Country);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Edit the product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // If rows count is greater than 1.
                if (dataGridProduct.Rows.Count >= 1)
                {
                    // Directory validation.
                    DirectoryInfo newRootDit = new DirectoryInfo("data");
                    if (!newRootDit.Exists)
                        newRootDit.Create();
                    // Creating variables.
                    var rowIndex = dataGridProduct.SelectedRows;
                    var fileClassManager = new List<FileClass>();
                    // FileStream reader.
                    using (FileStream fs =
                        new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json",
                            FileMode.OpenOrCreate))
                    {
                        using var sReader = new StreamReader(fs);
                        // While loop.
                        while (sReader.Peek() > -1)
                        {
                            string input = sReader.ReadToEnd();
                            if (input == String.Empty)
                                throw new ArgumentException("File is empty");
                            // Deserialization.
                            List<FileClass> restoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input ?? string.Empty);
                            fileClassManager.AddRange(restoredPerson);
                        }
                    }

                    // Foreach loop validation.
                    var newListFileClasses = fileClassManager.Where(file => file.UCN == rowIndex[0].Cells[2].Value.ToString()).ToList();
                    // Creating new object AddFileForm.
                    var addProductForm = new AddFileForm { fileClass = newListFileClasses };
                    addProductForm.ShowDialog();
                    if (isClosedForm)
                    {
                        // Adding classes.
                        foreach (var file in fileClassManager.Where(file => file.UCN == rowIndex[0].Cells[2].Value.ToString()))
                        {
                            file.Name = fileClasses.Name;
                            file.Code = fileClasses.Code;
                            file.UCN = fileClasses.UCN;
                            file.Company = fileClasses.Company;
                            file.Amount = fileClasses.Amount;
                            file.Cost = fileClasses.Cost;
                            file.Currency = fileClasses.Currency;
                            file.Warranty = fileClasses.Warranty;
                            file.Status = fileClasses.Status;
                            file.Discount = fileClasses.Discount;
                            file.Country = fileClasses.Country;
                            file.PictureBox = fileClasses.PictureBox;
                            file.Description = fileClasses.Description;
                        }
                        // Adding to DataGrid.
                        for (int i = 0; i < rowIndex.Count; i++)
                        {
                            rowIndex[i].Cells[0].Value = fileClasses.Name;
                            rowIndex[i].Cells[1].Value = fileClasses.Code;
                            rowIndex[i].Cells[2].Value = fileClasses.UCN;
                            rowIndex[i].Cells[3].Value = fileClasses.Company;
                            rowIndex[i].Cells[4].Value = fileClasses.Amount;
                            rowIndex[i].Cells[5].Value = fileClasses.Cost;
                            rowIndex[i].Cells[6].Value = fileClasses.Currency;
                            rowIndex[i].Cells[7].Value = fileClasses.Warranty ? "Available" : "Unavailable";
                            rowIndex[i].Cells[8].Value = fileClasses.Status ? "Available" : "Unavailable";
                            rowIndex[i].Cells[9].Value = fileClasses.Discount;
                            rowIndex[i].Cells[10].Value = fileClasses.Country;
                        }
                    }
                    // FileStream.
                    using (var fileStreamWriter =
                        new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json",
                            FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        // Writes and serializes.
                        fileStreamWriter.Position = 0;
                        using var streamWriter = new StreamWriter(fileStreamWriter);
                        streamWriter.WriteLine(JsonSerializer.Serialize(fileClassManager));
                    }
                }
                else
                {
                    MessageBox.Show(@"Datagrid is empty!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Sorting the TreeView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortButton_Click(object sender, EventArgs e)
        {
            try
            {
                treeView.TreeViewNodeSorter = new SortNode();
                treeView.Sort();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// CSV button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csvButton_Click(object sender, EventArgs e)
        {
            node.Clear();
            // Form creates.
            CSVSort csvSortForm = new CSVSort();
            csvSortForm.ShowDialog();

            // Introducing variables.
            int tempCost = csvSortForm.Cost;
            int tempAmount = csvSortForm.Amount;
            bool tempIsClosed = csvSortForm.IsClosed;

            DirectoryInfo newRootDit = new DirectoryInfo("data");
            // Validating directory.
            if (!newRootDit.Exists)
                newRootDit.Create();
            var tempFileClasses = new List<CSVClassAnalyzer>();

            if (!tempIsClosed) return;
            // Recursive treeview.
            CallRecursive(treeView);
            // Foreach loop validation.
            foreach (var treeNode in node.Where(treeNode => File.Exists($"{newRootDit.FullName}/{treeNode.Text}.json")))
            {
                using (var fs =
                    new FileStream($"{newRootDit.FullName}/{treeNode.Text}.json",
                        FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using var sReader = new StreamReader(fs);
                    // While loop with deserialization.
                    while (sReader.Peek() > -1)
                    {
                        var input = sReader.ReadToEnd();
                        // Validation.
                        if (input == string.Empty)
                            continue;
                        if (input.Length < 10)
                            continue;
                        // Deserializing.
                        var listOfRestoredPerson =
                            JsonSerializer.Deserialize<List<FileClass>>(input);
                        // if list is not null.
                        if (listOfRestoredPerson != null)
                            // Validation.
                            tempFileClasses.AddRange(from data in listOfRestoredPerson
                                where data.Amount <= tempAmount && data.Cost <= tempCost
                                select new CSVClassAnalyzer
                                {
                                    NodePath = treeNode.FullPath,
                                    Country = data.Country,
                                    UCN = data.UCN,
                                    Name = data.Name,
                                    Amount = data.Amount,
                                    Cost = data.Cost
                                });
                    }
                }
            }
            // If list data counts if greater or equal than 1.
            if (tempFileClasses.Count >= 1)
            {
                SaveToCSV(tempFileClasses);
                MessageBox.Show(@"CSV file created. And it's located in exe path!");
            }
            else
            {
                MessageBox.Show(@"I couldn't find the data you entered ");
            }

        }

        /// <summary>
        /// Method which saves csv file.
        /// </summary>
        /// <param name="tempFileClasses"></param>
        private void SaveToCSV(List<CSVClassAnalyzer> tempFileClasses)
        {
            // If this file exists.
            if (File.Exists("csvData.csv"))
                File.Delete("csvData.csv");

            using (StreamWriter streamReader = new StreamWriter("csvData.csv"))
            {
                // Csv configuration.
                CsvConfiguration csvConfiguration =
                    new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
                // Writes it to file.
                using (var csv = new CsvWriter(streamReader, csvConfiguration))
                {
                    csv.WriteRecords(tempFileClasses);
                }
            }
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            node.Add(treeNode);
            // Print each node recursively.  
            foreach (TreeNode tempTreeNode in treeNode.Nodes)
            {
                PrintRecursive(tempTreeNode);
            }
        }

        // Call the procedure using the TreeView.  
        private void CallRecursive(TreeView treeView)
        {
            // Print each node recursively.  
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode treeNode in nodes)
            {
                PrintRecursive(treeNode);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // If rows is less than 1.
                if (dataGridProduct.Rows.Count < 1)
                    throw new ArgumentException("Datagrid is empty!");

                var selected = dataGridProduct.SelectedRows;
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                // Creating two List variables.
                List<FileClass> fileListClass = new List<FileClass>();
                List<FileClass> tempFileClasses = new List<FileClass>();

                using (FileStream fs =
                    new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json",
                        FileMode.OpenOrCreate))
                {
                    using var sReader = new StreamReader(fs);
                    // While loop.
                    while (sReader.Peek() > -1)
                    {
                        string input = sReader.ReadToEnd();
                        // Validation.
                        if (input == String.Empty)
                            throw new ArgumentException("File is empty");
                        // Desezialization.
                        List<FileClass> restoredPerson =
                            JsonSerializer.Deserialize<List<FileClass>>(input);
                        fileListClass.AddRange(restoredPerson);
                    }
                    // Adding it to the new list.
                    foreach (var data in fileListClass)
                        for (int i = 0; i < selected.Count; i++)
                            if (data.UCN != selected[0].Cells[2].Value.ToString())
                                tempFileClasses.Add(data);
                    fs.Position = 0;
                }

                if (tempFileClasses.Count > 0)
                {
                    using (FileStream fs =
                        new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json",
                            FileMode.OpenOrCreate))
                    {
                        // Serialization.
                        using var streamWriter = new StreamWriter(fs);
                        streamWriter.WriteLine(JsonSerializer.Serialize(tempFileClasses));
                    }
                }
                else
                {
                    File.WriteAllText($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json", "");
                }
                // Removes the selected row.
                foreach (DataGridViewRow rows in selected)
                    dataGridProduct.Rows.Remove(rows);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
