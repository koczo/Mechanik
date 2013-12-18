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
            this.textBoxNrKolor = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelNrKolor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNrKolor
            // 
            this.textBoxNrKolor.Location = new System.Drawing.Point(226, 86);
            this.textBoxNrKolor.Name = "textBoxNrKolor";
            this.textBoxNrKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrKolor.TabIndex = 0;
            this.textBoxNrKolor.TextChanged += new System.EventHandler(this.textBoxNrRej_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(91, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 279);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.listViewCar.Location = new System.Drawing.Point(76, 130);
            this.listViewCar.MaximumSize = new System.Drawing.Size(620, 430);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(620, 332);
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
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(76, 85);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarka.TabIndex = 3;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(87, 57);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(99, 25);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Marka";
            // 
            // labelNrKolor
            // 
            this.labelNrKolor.AutoSize = true;
            this.labelNrKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNrKolor.Location = new System.Drawing.Point(222, 57);
            this.labelNrKolor.Name = "labelNrKolor";
            this.labelNrKolor.Size = new System.Drawing.Size(105, 20);
            this.labelNrKolor.TabIndex = 5;
            this.labelNrKolor.Text = "Numer Koloru";
            // 
            // UserControlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mechanik.Properties.Resources.userControlAdd_03;
            this.Controls.Add(this.labelNrKolor);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxNrKolor);
            this.Name = "UserControlSearch";
            this.Size = new System.Drawing.Size(787, 553);
            this.Load += new System.EventHandler(this.UserControlSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNrKolor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelNrKolor;

    }
}
