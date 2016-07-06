using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordAddIn
{
    public partial class TaskPaneControl : UserControl
    {
        public TaskPaneControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currRange = Globals.ThisAddIn.Application.Selection.Range;
            var text = ((ComboBox)sender).SelectedItem.ToString();

            currRange.Text = text;
        }
    }
}
