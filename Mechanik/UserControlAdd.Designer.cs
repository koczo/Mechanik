namespace Mechanik
{
    partial class UserControlAdd
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.textBoxNrRej = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxKolor = new System.Windows.Forms.TextBox();
            this.textBoxNrKolor = new System.Windows.Forms.TextBox();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.labelRej = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNrKoloru = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.saveFileDialogXML = new System.Windows.Forms.SaveFileDialog();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(497, 455);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Location = new System.Drawing.Point(343, 105);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarka.TabIndex = 2;
            // 
            // textBoxNrRej
            // 
            this.textBoxNrRej.Location = new System.Drawing.Point(343, 61);
            this.textBoxNrRej.Name = "textBoxNrRej";
            this.textBoxNrRej.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrRej.TabIndex = 3;
            // 
            // textBoxModel
            // 
            this.textBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxModel.Location = new System.Drawing.Point(343, 154);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // textBoxKolor
            // 
            this.textBoxKolor.Location = new System.Drawing.Point(343, 227);
            this.textBoxKolor.Name = "textBoxKolor";
            this.textBoxKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolor.TabIndex = 5;
            // 
            // textBoxNrKolor
            // 
            this.textBoxNrKolor.Location = new System.Drawing.Point(343, 270);
            this.textBoxNrKolor.Name = "textBoxNrKolor";
            this.textBoxNrKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrKolor.TabIndex = 6;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Location = new System.Drawing.Point(255, 319);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(366, 96);
            this.richTextBoxOpis.TabIndex = 7;
            this.richTextBoxOpis.Text = "";
            // 
            // labelRej
            // 
            this.labelRej.AutoSize = true;
            this.labelRej.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRej.Location = new System.Drawing.Point(162, 64);
            this.labelRej.Name = "labelRej";
            this.labelRej.Size = new System.Drawing.Size(113, 19);
            this.labelRej.TabIndex = 8;
            this.labelRej.Text = "Numer Rejestra";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarka.Location = new System.Drawing.Point(162, 108);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(52, 19);
            this.labelMarka.TabIndex = 9;
            this.labelMarka.Text = "Marka";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(162, 157);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 19);
            this.labelModel.TabIndex = 10;
            this.labelModel.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(162, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kolor";
            // 
            // labelNrKoloru
            // 
            this.labelNrKoloru.AutoSize = true;
            this.labelNrKoloru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNrKoloru.Location = new System.Drawing.Point(162, 273);
            this.labelNrKoloru.Name = "labelNrKoloru";
            this.labelNrKoloru.Size = new System.Drawing.Size(104, 19);
            this.labelNrKoloru.TabIndex = 12;
            this.labelNrKoloru.Text = "Numer Koloru";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(162, 322);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(39, 19);
            this.labelOpis.TabIndex = 13;
            this.labelOpis.Text = "Opis";
            // 
            // saveFileDialogXML
            // 
            this.saveFileDialogXML.Filter = "Plik XML (*.xml)|*.xml";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(161, 192);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(40, 19);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(343, 192);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerData.TabIndex = 15;
            // 
            // UserControlAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mechanik.Properties.Resources.userControlAdd_03;
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelNrKoloru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.labelRej);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.textBoxNrKolor);
            this.Controls.Add(this.textBoxKolor);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxNrRej);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.buttonSave);
            this.Name = "UserControlAdd";
            this.Size = new System.Drawing.Size(787, 553);
            this.Load += new System.EventHandler(this.UserControlAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.TextBox textBoxNrRej;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxKolor;
        private System.Windows.Forms.TextBox textBoxNrKolor;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.Label labelRej;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNrKoloru;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXML;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
    }
}
