using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class FileClassManager
    {
        public static List<FileClass> FileList { get; set; }

        public FileClassManager()
        {
        }

        public void Add(FileClass data)
        {
            FileList.Add(data);
        }
    }
}
