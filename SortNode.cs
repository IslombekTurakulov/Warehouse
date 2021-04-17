using System;
using System.Collections;
using System.Windows.Forms;

namespace Warehouse
{
    // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.treeviewnodesorter?redirectedfrom=MSDN&view=net-5.0#System_Windows_Forms_TreeView_TreeViewNodeSorter
    // Create a node sorter that implements the IComparer interface.
    public class SortNode : IComparer
    {
        // Compare the length of the strings, or the strings
        // themselves, if they are the same length.
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;
            // Compare the length of the strings, returning the difference.
            if (tx.Text.Length != ty.Text.Length)
                return tx.Text.Length - ty.Text.Length;

            // If they are the same length, call Compare.
            return String.CompareOrdinal(tx.Text, ty.Text);
        }
    } 
}
