using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        private static FileClass newFileClass;
        private AddFileForm addFileForm;
        private string filePath;
        private string getNodeData;
        private string nodeViewName;
        private bool nodeViewNameBoolean;
        private bool isClosedForm;
        public MainForm()
        {
            // Добавляем обработчик события - который запустит функцию Reload
            Program.CallBackMy.CallbackEventHandler = new Program.CallBackMy.CallbackEvent(this.GetData);
            Program.CallBackMy.AddTreeViewEventHandler = new Program.CallBackMy.AddTreeView(this.AddTreeView);
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
            bunifuFormDock.SubscribeControlToDragEvents(logoPanel);
        }

        private void AddTreeView(string nodeviewname, bool nodeviewnameboolean)
        {
            nodeViewName = nodeviewname;
            nodeViewNameBoolean = nodeviewnameboolean;
        }

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void windowButton_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        private void minimizeWindow_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void menuButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(dashboardPage);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(filePage);
            AnalyzeTreeView();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(settingsPage);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            colorTransitionSide.Interval = 20;
            colorTransitionSide.Start();
            logoPicture.BackColor = Color.WhiteSmoke;
            logoPicture.ForeColor = Color.WhiteSmoke;
        }

        private void logoPicture_MouseDoubleClick(object sender, MouseEventArgs e) => colorTransitionSide.Stop();

        private void AnalyzeTreeView()
        {
            DirectoryInfo newRootDit = new DirectoryInfo("data");
            filePath = newRootDit.FullName;
            foreach (var file in newRootDit.GetFiles())
            {
                string newFile = file.Name.Replace(".txt", "");
                var n = new TreeNode(newFile, 13, 13);
                treeView.Nodes.Add(n);
            }
            if (treeView.Nodes.Count > 0)
            {
                if (treeView.Nodes[0].Text == "..." && treeView.Nodes[0].Tag == null)
                {
                    treeView.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(treeView.Tag.ToString());

                    //add files of rootdirectory
                    DirectoryInfo rootDir = new DirectoryInfo(treeView.Tag.ToString());
                    foreach (var file in rootDir.GetFiles())
                    {
                        TreeNode n = new TreeNode(file.Name, 13, 13);
                        treeView.Nodes.Add(n);
                    }

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);

                            foreach (var file in di.GetFiles())
                            {
                                TreeNode n = new TreeNode(file.Name, 13, 13);
                                node.Nodes.Add(n);
                            }

                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            treeView.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Reading new csv table.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private DataTable Converter(string filePath)
        {
            try
            {
                var dataTable = new DataTable("Data");
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("File not found!");
                // Setting up csv configuration for reading.
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    PrepareHeaderForMatch = args => args.Header.ToLower(),
                    MissingFieldFound = null,
                    TrimOptions = TrimOptions.Trim,
                    HasHeaderRecord = false
                };
                // Creating streams to read the file.
                using var sr = new StreamReader(filePath);
                using var csv = new CsvReader(sr, config);
                using var dr = new CsvDataReader(csv);
                dataTable.Load(dr);

                // For loop check for empty columns.
                for (int i = 1; i <= dataTable.Rows.Count; i++)
                {
                    for (int j = 1; j <= dataTable.Columns.Count; j++)
                    {
                        if (dataTable.Rows[i - 1].ItemArray[1].ToString() == String.Empty ||
                            dataTable.Rows[i - 1].ItemArray[2].ToString() == String.Empty)
                        {
                            dataTable.Rows.RemoveAt(i - 1);
                        }
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;

        }

        private void addDataForm_Click(object sender, EventArgs e)
        {
            addFileForm = new AddFileForm();
            addFileForm.ShowDialog();
            if (isClosedForm)
            {
                try
                {
                    DirectoryInfo newRootDit = new DirectoryInfo("data");
                    if (!newRootDit.Exists)
                        newRootDit.Create();

                    string path;
                    using (var fs = new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.txt", FileMode.OpenOrCreate))
                    {
                        using (var sw = new StreamWriter(fs))
                        {
                            fs.Seek(fs.Length, SeekOrigin.Begin);
                            sw.WriteLine(
                                $"{newFileClass.Name},{newFileClass.Code},{newFileClass.UCN},{newFileClass.Company},{newFileClass.Amount},{newFileClass.Cost},{newFileClass.Currency},{newFileClass.Warranty},{newFileClass.Status},{newFileClass.Discount}");
                        }
                    }
                    DataTable dataTable = Converter($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.txt");
                    fileDatagrid.DataSource = dataTable;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        void GetData(FileClass file, bool isClosed)
        {
            newFileClass = file;
            isClosedForm = isClosed;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTreeName editTree = new EditTreeName();
            editTree.ShowDialog();
        }

        private void addNodeButton_Click_1(object sender, EventArgs e)
        {
            nodeViewName = "";
            nodeViewNameBoolean = false;
            EditTreeName editTreeName = new EditTreeName();
            editTreeName.ShowDialog();
            if (nodeViewNameBoolean)
            {
                DirectoryInfo newRootDit = new DirectoryInfo("data");
                string path;
                using (var fs = new StreamWriter(new FileStream($"{newRootDit.FullName}/{nodeViewName}.txt", FileMode.OpenOrCreate)))
                {
                    fs.Write("");
                    path = $"{newRootDit.FullName}/{nodeViewName}.txt";
                }
                treeView.Nodes.Clear();
                AnalyzeTreeView();
                treeView.ExpandAll();
            }
        }

        private void createChildNodeStrip_Click(object sender, EventArgs e)
        {
            var name = treeView.SelectedNode;
            nodeViewName = "";
            nodeViewNameBoolean = false;
            EditTreeName editTreeName = new EditTreeName();
            editTreeName.ShowDialog();
          
            if (nodeViewNameBoolean)
            {
                 DirectoryInfo newRootDit = new DirectoryInfo("data");
                string path;
                using (var fs = new StreamWriter(new FileStream($"{newRootDit.FullName}/{nodeViewName}.txt", FileMode.OpenOrCreate)))
                {
                    fs.Write("");
                    path = $"{newRootDit.FullName}/{nodeViewName}.txt";
                }

                name.Nodes.Add($"{nodeViewName}");
                treeView.ExpandAll();
            }
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public static void SerializeToFile<T>(T data, string filename)
        {
            using (var sw = new StreamWriter(filename))
            {
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(sw, data);
            }
        }
        private static DataNode GetDataNode(TreeNode node)
        {
            var dataNode = new DataNode();
            dataNode.Text = node.Text;
            dataNode.IsExpanded = node.IsExpanded;
            dataNode.IsSelected = node.IsSelected;

            foreach(TreeNode n in node.Nodes)
            {
                var d = GetDataNode(n);
                dataNode.Nodes.Add(d);
            }

            return dataNode;
        }

        private static void SaveTree(string filename, TreeView tv)
        {
            var data = new List<DataNode>();

            foreach(TreeNode node in tv.Nodes)
            {
                var dataNode = GetDataNode(node);
                data.Add(dataNode);
            }

            SerializeToFile(data, filename);
        }

        private static void FillNode(TreeView tv, TreeNode node, DataNode d)
        {   
            foreach(var c in d.Nodes)
            {
                var n = new TreeNode();
                FillNode(tv, n, c);
                node.Nodes.Add(n);
            }       

            node.Text = d.Text;
            if (d.IsExpanded) node.Expand();        
            if (d.IsSelected) tv.SelectedNode = node;       
        }

        private static TreeView LoadTree(string fname)
        {
            var data = DeserializeFromFile<DataNode[]>(fname);
            var tv = new TreeView();        

            foreach(var d in data)
            {
                var node = new TreeNode();
                tv.Nodes.Add(node);
                FillNode(tv, node, d);                      
            }   

            return tv;
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
        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DirectoryInfo newRootDit = new DirectoryInfo("data");
            if (!newRootDit.Exists)
                newRootDit.Create();
            else
            {
                if (File.Exists($"{newRootDit}/{treeView.SelectedNode}.txt"))
                    File.Create($"{newRootDit}/{treeView.SelectedNode}.txt");
                if (fileDatagrid.Rows.Count > 0)
                    fileDatagrid.Rows.Clear();
                //DataTable dataTable = Converter($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.txt");
                using (var fs = new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.txt",
                    FileMode.OpenOrCreate))
                {
                    using (var sw = new StreamReader(fs))
                    {
                        while (sw.Peek() > -1)
                        {
                            string[] data = sw.ReadLine()?.Split(',');
                            if (data.Length > 10)
                                continue;
                            fileDatagrid.Rows.Add(data?[0], data?[1],
                                data?[2], data?[3],
                                data?[4], data?[5],
                                data?[6], data?[7],
                                data?[8], data?[9]);
                        }
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTree(@"datanodes.xml", treeView);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var fname = @"datanodes.xml";
            if (!File.Exists(fname))
                return;
           var tree = LoadTree(fname);
           treeView = tree;
        }
    }
}
