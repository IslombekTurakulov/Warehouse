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

        /// <summary>
        /// Event Handlers.
        /// </summary>
        public static class CallBackMy
        {
            public delegate void CallbackEvent(FileClass fileClass, bool isClosed);
            public static CallbackEvent CallbackEventHandler;
            public delegate void ClassEditorData(FileClass fileClass);
            public static ClassEditorData TreeViewEventHandler;
            public delegate void AddTreeView(string nodeViewName, bool nodeViewNameBoolean);
            public static AddTreeView AddTreeViewEventHandler;
        }
    }
}
