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

namespace Warehouse
{
    public partial class MainForm : Form
    {
        private static FileClass fileClasses;
        private AddFileForm addFileForm;
        private string filePath;
        private string nodeViewName;
        private bool nodeViewNameBoolean;
        private bool isClosedForm;

        public MainForm()
        {
            // Добавляем обработчик события - который запустит функцию Reload
            Program.CallBackMy.CallbackEventHandler = this.GetData;
            Program.CallBackMy.AddTreeViewEventHandler = this.AddTreeView;
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
            bunifuFormDock.SubscribeControlToDragEvents(logoPanel);
        }

        #region Events
        void GetData(FileClass file, bool isClosed)
        {
            fileClasses = file;
            isClosedForm = isClosed;
        }

        private void AddTreeView(string nodeviewname, bool nodeviewnameboolean)
        {
            nodeViewName = nodeviewname;
            nodeViewNameBoolean = nodeviewnameboolean;
        }
        #endregion

        #region Settings

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

        private void windowButton_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        private void minimizeWindow_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void menuButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(dashboardPage);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(filePage);
        }


        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            colorTransitionSide.Interval = 20;
            colorTransitionSide.Start();
            logoPicture.BackColor = Color.WhiteSmoke;
            logoPicture.ForeColor = Color.WhiteSmoke;
        }

        private void logoPicture_MouseDoubleClick(object sender, MouseEventArgs e) => colorTransitionSide.Stop();
        #endregion

        private void addDataProduct_Click(object sender, EventArgs e)
        {
            try
            {
                isClosedForm = false;
                addFileForm = new AddFileForm();
                addFileForm.ShowDialog();
                if (!isClosedForm) return;
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists) newRootDit.Create();

                using (var fileStreamWriter = new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    List<FileClass> listClasses = new List<FileClass>();
                    using var streamReader = new StreamReader(fileStreamWriter);
                    while (streamReader.Peek() > -1)
                    {
                        string input = streamReader.ReadToEnd();
                        if (input == string.Empty)
                            throw new ArgumentException("File is empty");
                        if (input.Length < 10)
                            throw new ArgumentException("File is empty");
                        var restoredPerson =
                            JsonSerializer.Deserialize<List<FileClass>>(input ?? string.Empty);

                        if (restoredPerson != null)
                            listClasses.AddRange(restoredPerson);
                    }
                    listClasses?.Add(fileClasses);
                    fileStreamWriter.Position = 0;
                    using var streamWriter = new StreamWriter(fileStreamWriter);
                    streamWriter.WriteLine(JsonSerializer.Serialize(listClasses));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                nodeViewNameBoolean = false;
                EditTreeName editTree = new EditTreeName();
                editTree.ShowDialog();
                if (nodeViewNameBoolean)
                    treeView.SelectedNode.Text = nodeViewName;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                nodeViewName = "";
                nodeViewNameBoolean = false;

                var editTreeName = new EditTreeName();
                editTreeName.ShowDialog();

                if (!nodeViewNameBoolean) return;

                var newRootDit = new DirectoryInfo("data");

                using (FileStream fs =
                    new FileStream($"{newRootDit.FullName}/{nodeViewName}.json",
                        FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var sw = new StreamWriter(fs);
                    sw.Write("");
                }

                if (!treeView.Nodes.ContainsKey(nodeViewName))
                    treeView.Nodes.Add(nodeViewName);
                else
                    throw new ArgumentException("The name of node is already exist!");
                SaveTree("DataNodes.xml", treeView);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void createChildNodeStrip_Click(object sender, EventArgs e)
        {
            try
            {
                var name = treeView.SelectedNode;
                nodeViewName = "";
                nodeViewNameBoolean = false;
                var editTreeName = new EditTreeName();
                editTreeName.ShowDialog();

                if (!nodeViewNameBoolean) return;
                var newRootDit = new DirectoryInfo("data");

                using (FileStream fs =
                    new FileStream($"{newRootDit.FullName}/{nodeViewName}.json",
                        FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var sw = new StreamWriter(fs);
                    sw.Write("");
                }
                var treeNode = new TreeNode(nodeViewName);
                if (!treeView.Nodes.Contains(treeNode))
                    name.Nodes.Add(nodeViewName);
                else
                    throw new ArgumentException("The name of node is already exist!");
                SaveTree("DataNodes.xml", treeView);
                treeView.ExpandAll();
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
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists)
                    newRootDit.Create();
                else
                {
                    if (dataGridProduct.Rows.Count > 0)
                        dataGridProduct.Rows.Clear();
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
                        while (sReader.Peek() > -1)
                        {
                            string input = sReader.ReadToEnd();
                            if (input == String.Empty)
                                throw new ArgumentException("File is empty");
                            if (input.Length < 10)
                                throw new ArgumentException("File is empty");
                            List<FileClass> listOfRestoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input);
                            if (listOfRestoredPerson == null) continue;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => SaveTree("DataNodes.xml", treeView);

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string fileXml = "DataNodes.xml";
                if (!File.Exists(fileXml))
                    return;

                var data = DeserializeFromFile<DataNode[]>(fileXml);
                foreach (var d in data)
                {
                    var treeNode = new TreeNode();
                    treeView.Nodes.Add(treeNode);
                    FillNode(treeView, treeNode, d);
                }
                treeView.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SerializeToFile<T>(T data, string filename)
        {
            using (var sw = new StreamWriter(filename))
            {
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(sw, data);
            }
        }

        public static T DeserializeFromFile<T>(string fname) where T : class
        {
            using (var sr = new StreamReader(fname))
            {
                var ser = new XmlSerializer(typeof(T));
                var data = ser.Deserialize(sr) as T;
                return data;
            }
        }

        private static void FillNode(TreeView tv, TreeNode node, DataNode d)
        {
            foreach (var c in d.Nodes)
            {
                var n = new TreeNode();
                FillNode(tv, n, c);
                node.Nodes.Add(n);
            }
            node.Text = d.Text;
            if (d.IsExpanded) node.Expand();
            if (d.IsSelected) tv.SelectedNode = node;
        }

        private static void SaveTree(string filename, TreeView tv)
        {
            var data = (from TreeNode node in tv.Nodes select GetDataNode(node)).ToList();

            SerializeToFile(data, filename);
        }

        private static DataNode GetDataNode(TreeNode node)
        {
            var dataNode = new DataNode { Text = node.Text, IsExpanded = node.IsExpanded, IsSelected = node.IsSelected };
            foreach (TreeNode n in node.Nodes)
            {
                var d = GetDataNode(n);
                dataNode.Nodes.Add(d);
            }

            return dataNode;
        }

        private void deleteChildNodeStrip_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists)
                    newRootDit.Create();
                else
                {
                    var path = $"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json";
                    if (File.Exists(path))
                        File.Delete(path);
                    if (treeView.SelectedNode.Nodes.Count >= 1)
                    {
                        TreeNodeCollection nodes = treeView.SelectedNode.Nodes;
                        foreach (TreeNode node in nodes)
                            File.Delete($"{node.Text}.json");
                    }
                    treeView.SelectedNode.Nodes.Clear();
                    treeView.Nodes.Remove(treeView.SelectedNode);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                if (!newRootDit.Exists)
                    newRootDit.Create();
                else
                {
                    if (dataGridProduct.Rows.Count > 0)
                        dataGridProduct.Rows.Clear();
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
                        while (sReader.Peek() > -1)
                        {
                            string input = sReader.ReadToEnd();
                            if (input == String.Empty)
                                throw new ArgumentException("File is empty");
                            if (input.Length < 10)
                                throw new ArgumentException("File is empty");
                            List<FileClass> listOfRestoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input);
                            if (listOfRestoredPerson != null)
                                foreach (var restoredPerson in listOfRestoredPerson)
                                {
                                    dataGridProduct.Rows.Add(restoredPerson?.Name, 
                                        restoredPerson?.Code,
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                var rowIndex = dataGridProduct.SelectedRows;
                var fileClassManager = new List<FileClass>();
                var newListFileClasses = new List<FileClass>();
                using (FileStream fs =
                    new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json",
                        FileMode.OpenOrCreate))
                {
                    using var sReader = new StreamReader(fs);
                    while (sReader.Peek() > -1)
                    {
                        string input = sReader.ReadLine();
                        if (input == String.Empty)
                            throw new ArgumentException("File is empty");
                        FileClass restoredPerson =
                            JsonSerializer.Deserialize<FileClass>(input ?? string.Empty);
                        fileClassManager.Add(restoredPerson);
                    }
                }

                foreach (var file in fileClassManager)
                {
                    if (file.UCN == rowIndex[0].Cells[2].Value.ToString())
                    {
                        newListFileClasses.Add(file);
                    }
                }
                var addProductForm = new AddFileForm { fileClass = newListFileClasses };
                addProductForm.ShowDialog();
                if (isClosedForm)
                {
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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView.Nodes.Count > 2)
                {
                    treeView.TreeViewNodeSorter = new SortNode();
                    treeView.Sort();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private List<TreeNode> node = new List<TreeNode>();
        private void csvButton_Click(object sender, EventArgs e)
        {
            CSVSort csvSortForm = new CSVSort();
            csvSortForm.ShowDialog();
            int tempCost = csvSortForm.Cost;
            int tempAmount = csvSortForm.Amount;
            bool tempIsClosed = csvSortForm.IsClosed;
            DirectoryInfo newRootDit = new DirectoryInfo("data");
            var tempFileClasses = new List<CSVClassAnalyzer>();
            if (tempIsClosed)
            {
                CallRecursive(treeView);
                foreach (var treeNode in node.Where(treeNode => File.Exists($"{newRootDit.FullName}/{treeNode.Text}.json")))
                {
                    using (var fs =
                        new FileStream($"{newRootDit.FullName}/{treeNode.Text}.json",
                            FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using var sReader = new StreamReader(fs);
                        while (sReader.Peek() > -1)
                        {
                            var input = sReader.ReadToEnd();
                            if (input == string.Empty)
                                continue;
                            if (input.Length < 10)
                                continue;
                            var listOfRestoredPerson =
                                JsonSerializer.Deserialize<List<FileClass>>(input);
                            if (listOfRestoredPerson != null)
                                tempFileClasses.AddRange(from data in listOfRestoredPerson
                                                         where data.Amount <= tempAmount && data.Cost <= tempCost
                                                         select new CSVClassAnalyzer
                                                         {
                                                             NodePath = treeNode.FullPath,
                                                             UCN = data.UCN,
                                                             Name = data.Name,
                                                             Amount = data.Amount,
                                                             Cost = data.Cost
                                                         });
                        }
                    }
                }

                if (tempFileClasses.Count > 1)
                {
                    SaveToCSV(tempFileClasses);
                    MessageBox.Show(@"CSV file created!");
                }
            }

        }
        private void SaveToCSV(List<CSVClassAnalyzer> tempFileClasses)
        {
            if (File.Exists("csvData.csv"))
                File.Delete("csvData.csv");

            using (StreamWriter streamReader = new StreamWriter("csvData.csv"))
            {
                using (var csv = new CsvWriter(streamReader, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(tempFileClasses);
                }
            }
        }

        private void quantitySort_Click(object sender, EventArgs e)
        {
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            node.Add(treeNode);
            // Print each node recursively.  
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        // Call the procedure using the TreeView.  
        private void CallRecursive(TreeView treeView)
        {
            // Print each node recursively.  
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}
