namespace Mechanik
{
    partial class UserControlSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewCar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelModel = new System.Windows.Forms.Label();
            this.labelNrKolor = new System.Windows.Forms.Label();
            this.comboBoxMarka = new MetroFramework.Controls.MetroComboBox();
            this.textBoxNrKolor = new MetroFramework.Controls.MetroTextBox();
            this.metroUserControl = new MetroFramework.Controls.MetroUserControl();
            this.SuspendLayout();
            // 
            // listViewCar
            // 
            this.listViewCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCar.FullRowSelect = true;
            this.listViewCar.GridLines = true;
            this.listViewCar.Location = new System.Drawing.Point(3, 88);
            this.listViewCar.MaximumSize = new System.Drawing.Size(620, 430);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(619, 288);
            this.listViewCar.TabIndex = 2;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            this.listViewCar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCar_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numer Rejestracyjny";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kolor";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Numer Koloru";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Opis";
            this.columnHeader6.Width = 190;
            // 
            // labelModel
            // 
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(26, 11);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(99, 25);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Marka";
            // 
            // labelNrKolor
            // 
            this.labelNrKolor.AutoSize = true;
            this.labelNrKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNrKolor.Location = new System.Drawing.Point(161, 11);
            this.labelNrKolor.Name = "labelNrKolor";
            this.labelNrKolor.Size = new System.Drawing.Size(105, 20);
            this.labelNrKolor.TabIndex = 5;
            this.labelNrKolor.Text = "Numer Koloru";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMarka.DropDownHeight = 300;
            this.comboBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarka.FontSize = MetroFramework.MetroLinkSize.Small;
            this.comboBoxMarka.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.IntegralHeight = false;
            this.comboBoxMarka.ItemHeight = 19;
            this.comboBoxMarka.Location = new System.Drawing.Point(30, 39);
            this.comboBoxMarka.MaxDropDownItems = 16;
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 25);
            this.comboBoxMarka.Style = MetroFramework.MetroColorStyle.Green;
            this.comboBoxMarka.StyleManager = null;
            this.comboBoxMarka.TabIndex = 7;
            this.comboBoxMarka.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // textBoxNrKolor
            // 
            this.textBoxNrKolor.CustomBackground = false;
            this.textBoxNrKolor.CustomForeColor = false;
            this.textBoxNrKolor.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.textBoxNrKolor.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.textBoxNrKolor.Location = new System.Drawing.Point(165, 41);
            this.textBoxNrKolor.Multiline = false;
            this.textBoxNrKolor.Name = "textBoxNrKolor";
            this.textBoxNrKolor.SelectedText = "";
            this.textBoxNrKolor.Size = new System.Drawing.Size(126, 23);
            this.textBoxNrKolor.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxNrKolor.StyleManager = null;
            this.textBoxNrKolor.TabIndex = 8;
            this.textBoxNrKolor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxNrKolor.UseStyleColors = false;
            // 
            // metroUserControl
            // 
            this.metroUserControl.CustomBackground = false;
            this.metroUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroUserControl.Location = new System.Drawing.Point(0, 0);
            this.metroUserControl.Name = "metroUserControl";
            this.metroUserControl.Size = new System.Drawing.Size(625, 420);
            this.metroUserControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroUserControl.StyleManager = null;
            this.metroUserControl.TabIndex = 9;
            this.metroUserControl.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNrKolor);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.labelNrKolor);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.metroUserControl);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(625, 420);
            this.Load += new System.EventHandler(this.UserControlSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelNrKolor;
        private MetroFramework.Controls.MetroComboBox comboBoxMarka;
        private MetroFramework.Controls.MetroTextBox textBoxNrKolor;
        private MetroFramework.Controls.MetroUserControl metroUserControl;

    }
}
