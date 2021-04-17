using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class FileClassManager
    {
        private static List<FileClass> FileList { get; } = new List<FileClass>();

        public void Add(FileClass data)
        {
            var list = new List<FileClass>() {data};
            foreach (var item in list)
            {
                FileList.Add(item);
            }
        }

        public void Remove(FileClass data)
        {
            if (FileList.Contains(data))
                FileList.Remove(data);
        }
    }
}
