namespace WordAddIn
{
    partial class ManageTaskPaneRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ManageTaskPaneRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.taskPaneManager = this.Factory.CreateRibbonGroup();
            this.ToggleTaskPane = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.taskPaneManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.taskPaneManager);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // taskPaneManager
            // 
            this.taskPaneManager.Items.Add(this.ToggleTaskPane);
            this.taskPaneManager.Label = "Task Pane Manager";
            this.taskPaneManager.Name = "taskPaneManager";
            // 
            // ToggleTaskPane
            // 
            this.ToggleTaskPane.Label = "Show Task Panel";
            this.ToggleTaskPane.Name = "ToggleTaskPane";
            this.ToggleTaskPane.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleTaskPane_Click);
            // 
            // ManageTaskPaneRibbon
            // 
            this.Name = "ManageTaskPaneRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ManageTaskPaneRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.taskPaneManager.ResumeLayout(false);
            this.taskPaneManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup taskPaneManager;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton ToggleTaskPane;
    }

    partial class ThisRibbonCollection
    {
        internal ManageTaskPaneRibbon ManageTaskPaneRibbon
        {
            get { return this.GetRibbon<ManageTaskPaneRibbon>(); }
        }
    }
}
