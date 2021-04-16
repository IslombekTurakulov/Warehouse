using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

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

        #region Settings

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
            indicator.Top = ((Control)sender).Top;
            controlPage.SetPage(filePage);
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
        #endregion

        private void addDataProduct_Click(object sender, EventArgs e)
        {
            try
            {
                isClosedForm = false;
                addFileForm = new AddFileForm();
                addFileForm.ShowDialog();
                if (isClosedForm)
                {
                    DirectoryInfo newRootDit = new DirectoryInfo("data");
                    if (!newRootDit.Exists)
                        newRootDit.Create();

                    using (var fileStreamWriter = new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json", FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        using var streamWriter = new StreamWriter(fileStreamWriter);

                        fileStreamWriter.Seek(fileStreamWriter.Length, SeekOrigin.End);
                        streamWriter.WriteLine(JsonSerializer.Serialize(fileClasses));
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        void GetData(FileClass file, bool isClosed)
        {
            fileClasses = file;
            isClosedForm = isClosed;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTreeName editTree = new EditTreeName();
            editTree.ShowDialog();
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

                DirectoryInfo newRootDit = new DirectoryInfo("data");
                File.Create($"{newRootDit.FullName}/{nodeViewName}.json");

                treeView.Nodes.Add(nodeViewName);
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
                File.Create($"{newRootDit.FullName}/{nodeViewName}.json");

                name.Nodes.Add(nodeViewName);
                SaveTree("DataNodes.xml", treeView);
                treeView.ExpandAll();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                    if (fileDatagrid.Rows.Count > 0)
                        fileDatagrid.Rows.Clear();
                    if (!File.Exists($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json"))
                    {
                        treeView.Nodes.Remove(treeView.SelectedNode);
                        throw new ArgumentException("File doesn't exist");
                    }

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
                            fileDatagrid.Rows.Add(restoredPerson?.Name, restoredPerson?.Code,
                                restoredPerson?.UCN, restoredPerson?.Company,
                                restoredPerson?.Amount, restoredPerson?.Cost,
                                restoredPerson?.Currency, restoredPerson?.Warranty,
                                restoredPerson?.Status, restoredPerson?.Discount);
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
                    var node = new TreeNode();
                    treeView.Nodes.Add(node);
                    FillNode(treeView, node, d);
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
            DirectoryInfo newRootDit = new DirectoryInfo("data");

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
            var data = new List<DataNode>();

            foreach (TreeNode node in tv.Nodes)
            {
                var dataNode = GetDataNode(node);
                data.Add(dataNode);
            }

            SerializeToFile(data, filename);
        }

        private static DataNode GetDataNode(TreeNode node)
        {
            var dataNode = new DataNode();
            dataNode.Text = node.Text;
            dataNode.IsExpanded = node.IsExpanded;
            dataNode.IsSelected = node.IsSelected;

            foreach (TreeNode n in node.Nodes)
            {
                var d = GetDataNode(n);
                dataNode.Nodes.Add(d);
            }

            return dataNode;
        }

        private void deleteChildNodeStrip_Click(object sender, EventArgs e)
        {
            DirectoryInfo newRootDit = new DirectoryInfo("data");
            if (!newRootDit.Exists)
                newRootDit.Create();
            else
            {
                var path = $"{newRootDit.FullName}/{treeView.SelectedNode.Text}";
                if (File.Exists(path))
                    File.Delete(path);
                treeView.Nodes.Remove(treeView.SelectedNode);
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
                    if (fileDatagrid.Rows.Count > 0)
                        fileDatagrid.Rows.Clear();
                    if (!File.Exists($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json"))
                    {
                        treeView.Nodes.Remove(treeView.SelectedNode);
                        throw new ArgumentException("File doesn't exist");
                    }

                    using (FileStream fs =
                        new FileStream($"{newRootDit.FullName}/{treeView.SelectedNode.Text}.json",
                            FileMode.OpenOrCreate))
                    {
                        using var sReader = new StreamReader(fs);
                        if (sReader.ReadToEnd() == String.Empty)
                            throw new ArgumentException("File is empty!");
                        while (sReader.Peek() > -1)
                        {
                            FileClass restoredPerson =
                                JsonSerializer.Deserialize<FileClass>(sReader.ReadLine() ?? string.Empty);
                            fileDatagrid.Rows.Add(restoredPerson?.Name, restoredPerson?.Code,
                                restoredPerson?.UCN, restoredPerson?.Company,
                                restoredPerson?.Amount, restoredPerson?.Cost,
                                restoredPerson?.Currency, restoredPerson?.Warranty,
                                restoredPerson?.Status, restoredPerson?.Discount);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
