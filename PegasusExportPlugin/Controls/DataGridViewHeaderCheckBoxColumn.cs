using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace PegasusExportPlugin.Controls
{
    public class DataGridViewHeaderCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        private readonly DataGridViewCheckBoxColumnHeaderCell _checkboxHeaderCell =
            new DataGridViewCheckBoxColumnHeaderCell();

        private readonly DataGridViewColumnHeaderCell _headerCell = new DataGridViewColumnHeaderCell();

        private bool _headerCheckBox;

        public DataGridViewHeaderCheckBoxColumn()
        {
            MinimumWidth = 20;
            Width = 20;
            HeaderText = "";
            AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
        }

        [DefaultValue(false)]
        [Category("Extras")]
        [Description("Add a checkbox to the row header in the first column of the grid.")]
        public bool HeaderCheckBox
        {
            set
            {
                _headerCheckBox = value;
                HeaderCell = _headerCheckBox ? _checkboxHeaderCell : _headerCell;
            }
            get { return _headerCheckBox; }
        }

        [DefaultValue(HeaderCheckBoxBehaviour.SelectAll)]
        [Category("Extras")]
        [Description("Property to change the behaviour of the checkbox in the column header.")]
        public HeaderCheckBoxBehaviour HeaderCheckBoxBehaviour
        {
            set { _checkboxHeaderCell.HeaderCheckBoxBehaviour = value; }
            get { return _checkboxHeaderCell.HeaderCheckBoxBehaviour; }
        }

        public override object Clone()
        {
            var copy = base.Clone() as DataGridViewHeaderCheckBoxColumn;
            copy.HeaderCheckBox = HeaderCheckBox;
            copy.HeaderCheckBoxBehaviour = HeaderCheckBoxBehaviour;
            copy.HeaderText = HeaderText;
            copy.Width = Width;
            copy.MinimumWidth = MinimumWidth;
            return copy;
        }
    }
}
