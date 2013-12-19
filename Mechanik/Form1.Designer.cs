namespace Mechanik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSetXML = new System.Data.DataSet();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.metroTileView = new MetroFramework.Controls.MetroTile();
            this.metroTileAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileSearch = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetXML)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetXML
            // 
            this.dataSetXML.DataSetName = "NewDataSet";
            // 
            // openFileDialogXml
            // 
            resources.ApplyResources(this.openFileDialogXml, "openFileDialogXml");
            // 
            // saveFileDialogXML
            // 
            resources.ApplyResources(this.saveFileDialogXML, "saveFileDialogXML");
            // 
            // metroPanel
            // 
            this.metroPanel.CustomBackground = false;
            this.metroPanel.HorizontalScrollbar = false;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel, "metroPanel");
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel.StyleManager = null;
            this.metroPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel.VerticalScrollbar = false;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // metroTileView
            // 
            this.metroTileView.ActiveControl = null;
            this.metroTileView.CustomBackground = false;
            this.metroTileView.CustomForeColor = false;
            resources.ApplyResources(this.metroTileView, "metroTileView");
            this.metroTileView.Name = "metroTileView";
            this.metroTileView.PaintTileCount = true;
            this.metroTileView.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTileView.StyleManager = null;
            this.metroTileView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTileView.TileCount = 0;
            this.metroTileView.Click += new System.EventHandler(this.metroTileView_Click);
            // 
            // metroTileAdd
            // 
            this.metroTileAdd.ActiveControl = null;
            this.metroTileAdd.CustomBackground = false;
            this.metroTileAdd.CustomForeColor = false;
            resources.ApplyResources(this.metroTileAdd, "metroTileAdd");
            this.metroTileAdd.Name = "metroTileAdd";
            this.metroTileAdd.PaintTileCount = true;
            this.metroTileAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTileAdd.StyleManager = null;
            this.metroTileAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTileAdd.TileCount = 0;
            this.metroTileAdd.Click += new System.EventHandler(this.metroTileAdd_Click);
            // 
            // metroTileSearch
            // 
            this.metroTileSearch.ActiveControl = null;
            this.metroTileSearch.CustomBackground = false;
            this.metroTileSearch.CustomForeColor = false;
            resources.ApplyResources(this.metroTileSearch, "metroTileSearch");
            this.metroTileSearch.Name = "metroTileSearch";
            this.metroTileSearch.PaintTileCount = true;
            this.metroTileSearch.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSearch.StyleManager = null;
            this.metroTileSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTileSearch.TileCount = 0;
            this.metroTileSearch.Click += new System.EventHandler(this.metroTileSearch_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTileSearch);
            this.Controls.Add(this.metroTileAdd);
            this.Controls.Add(this.metroTileView);
            this.Controls.Add(this.metroPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetXML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSetXML;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXML;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTile metroTileView;
        private MetroFramework.Controls.MetroTile metroTileAdd;
        private MetroFramework.Controls.MetroTile metroTileSearch;
    }
}

