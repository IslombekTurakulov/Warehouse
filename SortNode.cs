using System;
using System.Collections;
using System.Windows.Forms;

namespace Warehouse
{
    // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.treeviewnodesorter?redirectedfrom=MSDN&view=net-5.0#System_Windows_Forms_TreeView_TreeViewNodeSorter
    // Create a node sorter that implements the IComparer interface.
    public class SortNode : IComparer
    {

        public SortNode() { }
        // Compare the length of the strings, or the strings
        // themselves, if they are the same length.
        public int Compare(object x, object y)
        {
            var tx = x as TreeNode;
            var ty = y as TreeNode;
            // If this is a child node, preserve the same order by comparing the node Index, not the text
            if (tx.Parent != null && ty.Parent != null)
                return tx.Index - ty.Index;
            // This is a root node, compare by name.
            return string.Compare(tx.Text, ty.Text);
        }
    } 
}
