using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusExportPlugin.Controls
{
    public class DataGridViewCheckBoxColumnHeaderCellEventArgs
    {
        public DataGridViewCheckBoxColumnHeaderCellEventArgs(bool bChecked)
        {
            Checked = bChecked;
        }

        public bool Checked { get; private set; }
    }
}
