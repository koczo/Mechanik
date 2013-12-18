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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyPlikXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzPlikXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMenuSearch = new System.Windows.Forms.Button();
            this.buttonMenuAddRepair = new System.Windows.Forms.Button();
            this.buttonMenuView = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.userControlAdd = new Mechanik.UserControlAdd();
            this.userControlSearch = new Mechanik.UserControlSearch();
            this.userControlView = new Mechanik.UserControlView();
            this.dataSetXML = new System.Data.DataSet();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetXML)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyPlikXMLToolStripMenuItem,
            this.wybierzPlikXMLToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.programToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            resources.ApplyResources(this.programToolStripMenuItem, "programToolStripMenuItem");
            // 
            // nowyPlikXMLToolStripMenuItem
            // 
            this.nowyPlikXMLToolStripMenuItem.Name = "nowyPlikXMLToolStripMenuItem";
            resources.ApplyResources(this.nowyPlikXMLToolStripMenuItem, "nowyPlikXMLToolStripMenuItem");
            this.nowyPlikXMLToolStripMenuItem.Click += new System.EventHandler(this.nowyPlikXMLToolStripMenuItem_Click);
            // 
            // wybierzPlikXMLToolStripMenuItem
            // 
            this.wybierzPlikXMLToolStripMenuItem.Name = "wybierzPlikXMLToolStripMenuItem";
            resources.ApplyResources(this.wybierzPlikXMLToolStripMenuItem, "wybierzPlikXMLToolStripMenuItem");
            this.wybierzPlikXMLToolStripMenuItem.Click += new System.EventHandler(this.wybierzPlikXMLToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            resources.ApplyResources(this.zamknijToolStripMenuItem, "zamknijToolStripMenuItem");
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            resources.ApplyResources(this.oProgramieToolStripMenuItem, "oProgramieToolStripMenuItem");
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // buttonMenuSearch
            // 
            this.buttonMenuSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuSearch.BackgroundImage = global::Mechanik.Properties.Resources.Button_08;
            this.buttonMenuSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenuSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonMenuSearch, "buttonMenuSearch");
            this.buttonMenuSearch.Image = global::Mechanik.Properties.Resources.search;
            this.buttonMenuSearch.Name = "buttonMenuSearch";
            this.buttonMenuSearch.UseVisualStyleBackColor = false;
            this.buttonMenuSearch.Click += new System.EventHandler(this.buttonMenuSearch_Click);
            this.buttonMenuSearch.MouseLeave += new System.EventHandler(this.buttonMenuSearch_MouseLeave);
            this.buttonMenuSearch.MouseHover += new System.EventHandler(this.buttonMenuSearch_MouseHover);
            // 
            // buttonMenuAddRepair
            // 
            this.buttonMenuAddRepair.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuAddRepair.BackgroundImage = global::Mechanik.Properties.Resources.Button_06;
            this.buttonMenuAddRepair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenuAddRepair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonMenuAddRepair, "buttonMenuAddRepair");
            this.buttonMenuAddRepair.Image = global::Mechanik.Properties.Resources.add_file;
            this.buttonMenuAddRepair.Name = "buttonMenuAddRepair";
            this.buttonMenuAddRepair.UseVisualStyleBackColor = false;
            this.buttonMenuAddRepair.Click += new System.EventHandler(this.buttonMenuAddRepair_Click);
            this.buttonMenuAddRepair.MouseLeave += new System.EventHandler(this.buttonMenuAddRepair_MouseLeave);
            this.buttonMenuAddRepair.MouseHover += new System.EventHandler(this.buttonMenuAddRepair_MouseHover);
            // 
            // buttonMenuView
            // 
            this.buttonMenuView.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenuView.BackgroundImage = global::Mechanik.Properties.Resources.button_03;
            this.buttonMenuView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenuView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonMenuView, "buttonMenuView");
            this.buttonMenuView.Image = global::Mechanik.Properties.Resources._26;
            this.buttonMenuView.Name = "buttonMenuView";
            this.buttonMenuView.UseCompatibleTextRendering = true;
            this.buttonMenuView.UseVisualStyleBackColor = false;
            this.buttonMenuView.Click += new System.EventHandler(this.buttonMenuView_Click);
            this.buttonMenuView.MouseLeave += new System.EventHandler(this.buttonMenuView_MouseLeave);
            this.buttonMenuView.MouseHover += new System.EventHandler(this.buttonMenuView_MouseHover);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.Transparent;
            this.panelView.Controls.Add(this.button1);
            this.panelView.Controls.Add(this.userControlAdd);
            this.panelView.Controls.Add(this.userControlSearch);
            this.panelView.Controls.Add(this.userControlView);
            resources.ApplyResources(this.panelView, "panelView");
            this.panelView.Name = "panelView";
            this.panelView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelView_Paint);
            // 
            // userControlAdd
            // 
            resources.ApplyResources(this.userControlAdd, "userControlAdd");
            this.userControlAdd.Name = "userControlAdd";
            // 
            // userControlSearch
            // 
            resources.ApplyResources(this.userControlSearch, "userControlSearch");
            this.userControlSearch.Name = "userControlSearch";
            // 
            // userControlView
            // 
            resources.ApplyResources(this.userControlView, "userControlView");
            this.userControlView.Name = "userControlView";
            this.userControlView.Load += new System.EventHandler(this.userControlView_Load);
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mechanik.Properties.Resources.tlo4;
            this.Controls.Add(this.buttonMenuSearch);
            this.Controls.Add(this.buttonMenuAddRepair);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.buttonMenuView);
            this.Controls.Add(this.panelView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.Button buttonMenuView;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.Button buttonMenuSearch;
        private System.Windows.Forms.Button buttonMenuAddRepair;
        private System.Windows.Forms.Panel panelView;
        private System.Data.DataSet dataSetXML;
        private UserControlView userControlView;
        private UserControlAdd userControlAdd;
        private UserControlSearch userControlSearch;
        private System.Windows.Forms.ToolStripMenuItem wybierzPlikXMLToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.ToolStripMenuItem nowyPlikXMLToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXML;
        private System.Windows.Forms.Button button1;
    }
}

