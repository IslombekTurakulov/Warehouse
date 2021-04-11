using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        private AddFileForm addFileForm;
        private string filePath;
        public MainForm()
        {
            // Добавляем обработчик события - который запустит функцию Reload
            Program.CallBackMy.callbackEventHandler = new Program.CallBackMy.callbackEvent(this.GetData);
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            bunifuFormDock.SubscribeControlToDragEvents(topbarPanel);
            bunifuFormDock.SubscribeControlToDragEvents(logoPanel);
        }

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void windowButton_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        private void minimizeWindow_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void menuButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
            controlPage.SetPage(dashboardPage);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            indicator.Top = ((Control) sender).Top;
            controlPage.SetPage(filePage);
            AnalyzeTreeView();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
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
                var n = new TreeNode(file.Name, 13, 13);
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
                    TrimOptions = TrimOptions.Trim
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

        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataTable dataTable = Converter( @"" + filePath + "\\" + treeView.SelectedNode.Text);
            fileDatagrid.DataSource = dataTable;
        }

        private void addDataForm_Click(object sender, EventArgs e)
        {
            addFileForm = new AddFileForm();
            addFileForm.ShowDialog();
        }

        void GetData(FileClass file)
        {
            FileClass newFileClass = file;
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
