namespace Mechanik
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.labelTytyl = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelKolor = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxKolor = new System.Windows.Forms.TextBox();
            this.labelNrKolor = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.textBoxNrKolor = new System.Windows.Forms.TextBox();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelate = new System.Windows.Forms.Button();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTytyl
            // 
            this.labelTytyl.AutoSize = true;
            this.labelTytyl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytyl.Location = new System.Drawing.Point(52, 113);
            this.labelTytyl.Name = "labelTytyl";
            this.labelTytyl.Size = new System.Drawing.Size(71, 30);
            this.labelTytyl.TabIndex = 0;
            this.labelTytyl.Text = "label1";
            this.labelTytyl.Click += new System.EventHandler(this.labelTytyl_Click);
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(54, 154);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(37, 13);
            this.labelMarka.TabIndex = 1;
            this.labelMarka.Text = "Marka";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(54, 181);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model";
            // 
            // labelKolor
            // 
            this.labelKolor.AutoSize = true;
            this.labelKolor.Location = new System.Drawing.Point(54, 240);
            this.labelKolor.Name = "labelKolor";
            this.labelKolor.Size = new System.Drawing.Size(31, 13);
            this.labelKolor.TabIndex = 3;
            this.labelKolor.Text = "Kolor";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(220, 151);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarka.TabIndex = 4;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(220, 178);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 5;
            // 
            // textBoxKolor
            // 
            this.textBoxKolor.Location = new System.Drawing.Point(220, 240);
            this.textBoxKolor.Name = "textBoxKolor";
            this.textBoxKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolor.TabIndex = 6;
            // 
            // labelNrKolor
            // 
            this.labelNrKolor.AutoSize = true;
            this.labelNrKolor.Location = new System.Drawing.Point(54, 269);
            this.labelNrKolor.Name = "labelNrKolor";
            this.labelNrKolor.Size = new System.Drawing.Size(71, 13);
            this.labelNrKolor.TabIndex = 7;
            this.labelNrKolor.Text = "Numer Koloru";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(54, 305);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(28, 13);
            this.labelOpis.TabIndex = 8;
            this.labelOpis.Text = "Opis";
            // 
            // textBoxNrKolor
            // 
            this.textBoxNrKolor.Location = new System.Drawing.Point(220, 266);
            this.textBoxNrKolor.Name = "textBoxNrKolor";
            this.textBoxNrKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrKolor.TabIndex = 9;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Location = new System.Drawing.Point(100, 305);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(330, 96);
            this.richTextBoxOpis.TabIndex = 10;
            this.richTextBoxOpis.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(338, 436);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelate
            // 
            this.buttonDelate.Location = new System.Drawing.Point(241, 436);
            this.buttonDelate.Name = "buttonDelate";
            this.buttonDelate.Size = new System.Drawing.Size(75, 23);
            this.buttonDelate.TabIndex = 12;
            this.buttonDelate.Text = "Usuń";
            this.buttonDelate.UseVisualStyleBackColor = true;
            this.buttonDelate.Click += new System.EventHandler(this.buttonDelate_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(220, 211);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerData.TabIndex = 13;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(54, 211);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 14;
            this.labelData.Text = "Data";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 469);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.buttonDelate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.textBoxNrKolor);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelNrKolor);
            this.Controls.Add(this.textBoxKolor);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.labelKolor);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.labelTytyl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.Text = "EditForm";
           // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTytyl;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelKolor;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxKolor;
        private System.Windows.Forms.Label labelNrKolor;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxNrKolor;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelate;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label labelData;

    }
}