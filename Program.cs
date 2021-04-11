using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static class CallBackMy
        {
            public delegate void CallbackEvent(FileClass fileClass);
            public static CallbackEvent CallbackEventHandler;
            public delegate void TreeViewName(string treeviewText);
            public static TreeViewName TreeViewEventHandler;
            public delegate void AddTreeView(string nodeViewName, bool nodeViewNameBoolean);
            public static AddTreeView AddTreeViewEventHandler;
        }
    }
}
