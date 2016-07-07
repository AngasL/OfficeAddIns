using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WordAddIn
{
    public partial class ManageTaskPaneRibbon
    {
        private void ManageTaskPaneRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void ToggleTaskPane_Click(object sender, RibbonControlEventArgs e)
        {
            var ribbonButton = (RibbonToggleButton) sender;
            ribbonButton.Label = ribbonButton.Checked ? "Hide Task Panel" : "Show Task Panel";

            Globals.ThisAddIn.TaskPane.Visible = ribbonButton.Checked;
        }
    }
}
