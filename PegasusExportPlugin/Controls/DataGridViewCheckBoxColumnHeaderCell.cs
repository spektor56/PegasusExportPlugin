using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PegasusExportPlugin.Controls
{
    public delegate void CheckBoxClickedHandler(bool state);
    public class DataGridViewCheckBoxColumnHeaderCell : DataGridViewColumnHeaderCell
    {
        private static bool _mouseInContentBounds;
        private static readonly VisualStyleElement CheckBoxElement = VisualStyleElement.Button.CheckBox.UncheckedNormal;
        private CheckBoxState _cbState = CheckBoxState.UncheckedNormal;

        private Point _cellLocation;
        private Point _checkBoxLocation;
        private Size _checkBoxSize;
        private bool _checked;

        public HeaderCheckBoxBehaviour HeaderCheckBoxBehaviour { get; set; }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event CheckBoxClickedHandler OnCheckBoxClicked;

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates dataGridViewElementState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText,
                cellStyle, advancedBorderStyle, paintParts);
            var p = new Point();
            var s = CheckBoxRenderer.GetGlyphSize(graphics, CheckBoxState.UncheckedNormal);
            p.X = cellBounds.Location.X + (cellBounds.Width / 2) - (s.Width / 2);
            p.Y = cellBounds.Location.Y + (cellBounds.Height / 2) - (s.Height / 2);
            _cellLocation = cellBounds.Location;
            _checkBoxLocation = p;
            _checkBoxSize = s;
            if (_mouseInContentBounds)
            {
                _cbState = _checked ? CheckBoxState.CheckedHot : CheckBoxState.UncheckedHot;
            }
            else
            {
                _cbState = _checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
            }

            DataGridViewCheckBoxCellRenderer.DrawCheckBox(graphics,
                new Rectangle(p.X, p.Y, _checkBoxSize.Width, _checkBoxSize.Height),
                (int)_cbState);
        }

        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e)
        {
            if (DataGridView == null)
            {
                return;
            }

            var oldMouseInContentBounds = _mouseInContentBounds;
            if (e.X + _cellLocation.X >= _checkBoxLocation.X &&
                e.X + _cellLocation.X <= _checkBoxLocation.X + _checkBoxSize.Width &&
                e.Y + _cellLocation.Y >= _checkBoxLocation.Y &&
                e.Y + _cellLocation.Y <= _checkBoxLocation.Y + _checkBoxSize.Height)
            {
                _mouseInContentBounds = true;
            }
            else
            {
                _mouseInContentBounds = false;
            }

            if (oldMouseInContentBounds != _mouseInContentBounds)
            {
                DataGridView.InvalidateCell(this);
            }

            base.OnMouseMove(e);
        }

        public virtual void Select(bool bChecked)
        {
            if (DataGridView == null || DataGridView.DataSource == null)
            {
                return;
            }

            if (HeaderCheckBoxBehaviour == HeaderCheckBoxBehaviour.SelectAll)
            {
                //Very slow with DataGridViewAutoSizeColumnsMode.AllCells
                foreach (DataGridViewRow row in DataGridView.Rows)
                {
                    var checkBoxCell = row.Cells[ColumnIndex];
                    if (checkBoxCell is DataGridViewCheckBoxCell)
                    {
                        checkBoxCell.Value = bChecked;
                    }
                }

                _checked = bChecked;

                DataGridView.EndEdit(DataGridViewDataErrorContexts.Commit);
                DataGridView.BindingContext[DataGridView.DataSource].EndCurrentEdit();
            }

            DataGridView.InvalidateCell(this);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (DataGridView == null)
            {
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                var p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
                if (p.X >= _checkBoxLocation.X && p.X <= _checkBoxLocation.X + _checkBoxSize.Width &&
                    p.Y >= _checkBoxLocation.Y &&
                    p.Y <= _checkBoxLocation.Y + _checkBoxSize.Height)
                {
                    _checked = !_checked;
                    Select(_checked);
                    if (OnCheckBoxClicked != null)
                    {
                        OnCheckBoxClicked(_checked);
                    }
                    DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }

        internal class DataGridViewCheckBoxCellRenderer
        {
            private static VisualStyleRenderer _visualStyleRenderer;

            private static VisualStyleRenderer CheckBoxRenderer
            {
                get { return _visualStyleRenderer ?? (_visualStyleRenderer = new VisualStyleRenderer(CheckBoxElement)); }
            }

            public static void DrawCheckBox(Graphics g, Rectangle bounds, int state)
            {
                CheckBoxRenderer.SetParameters(CheckBoxElement.ClassName, CheckBoxElement.Part, state);
                CheckBoxRenderer.DrawBackground(g, bounds, Rectangle.Truncate(g.ClipBounds));
            }
        }
    }
}
