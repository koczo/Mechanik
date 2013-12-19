﻿namespace Mechanik
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(370, 394);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Location = new System.Drawing.Point(201, 57);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarka.TabIndex = 2;
            // 
            // textBoxNrRej
            // 
            this.textBoxNrRej.Location = new System.Drawing.Point(201, 13);
            this.textBoxNrRej.Name = "textBoxNrRej";
            this.textBoxNrRej.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrRej.TabIndex = 3;
            // 
            // textBoxModel
            // 
            this.textBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxModel.Location = new System.Drawing.Point(201, 106);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // textBoxKolor
            // 
            this.textBoxKolor.Location = new System.Drawing.Point(201, 179);
            this.textBoxKolor.Name = "textBoxKolor";
            this.textBoxKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolor.TabIndex = 5;
            // 
            // textBoxNrKolor
            // 
            this.textBoxNrKolor.Location = new System.Drawing.Point(201, 222);
            this.textBoxNrKolor.Name = "textBoxNrKolor";
            this.textBoxNrKolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrKolor.TabIndex = 6;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Location = new System.Drawing.Point(113, 271);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(366, 96);
            this.richTextBoxOpis.TabIndex = 7;
            this.richTextBoxOpis.Text = "";
            // 
            // labelRej
            // 
            this.labelRej.AutoSize = true;
            this.labelRej.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRej.Location = new System.Drawing.Point(20, 16);
            this.labelRej.Name = "labelRej";
            this.labelRej.Size = new System.Drawing.Size(113, 19);
            this.labelRej.TabIndex = 8;
            this.labelRej.Text = "Numer Rejestra";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarka.Location = new System.Drawing.Point(20, 60);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(52, 19);
            this.labelMarka.TabIndex = 9;
            this.labelMarka.Text = "Marka";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(20, 109);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(52, 19);
            this.labelModel.TabIndex = 10;
            this.labelModel.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kolor";
            // 
            // labelNrKoloru
            // 
            this.labelNrKoloru.AutoSize = true;
            this.labelNrKoloru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNrKoloru.Location = new System.Drawing.Point(20, 225);
            this.labelNrKoloru.Name = "labelNrKoloru";
            this.labelNrKoloru.Size = new System.Drawing.Size(104, 19);
            this.labelNrKoloru.TabIndex = 12;
            this.labelNrKoloru.Text = "Numer Koloru";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(20, 274);
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
            this.labelData.Location = new System.Drawing.Point(19, 144);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(40, 19);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(201, 144);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerData.TabIndex = 15;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroComboBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(340, 57);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox1.StyleManager = null;
            this.metroComboBox1.TabIndex = 17;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.CustomBackground = false;
            this.metroUserControl1.Location = new System.Drawing.Point(0, 0);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(625, 420);
            this.metroUserControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroUserControl1.StyleManager = null;
            this.metroUserControl1.TabIndex = 18;
            this.metroUserControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CustomBackground = false;
            this.metroTextBox1.CustomForeColor = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox1.Location = new System.Drawing.Point(340, 106);
            this.metroTextBox1.Multiline = false;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.StyleManager = null;
            this.metroTextBox1.TabIndex = 19;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseStyleColors = false;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.CustomBackground = false;
            this.metroTextBox2.CustomForeColor = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.metroTextBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.metroTextBox2.Location = new System.Drawing.Point(401, 144);
            this.metroTextBox2.Multiline = true;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(207, 119);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.StyleManager = null;
            this.metroTextBox2.TabIndex = 20;
            this.metroTextBox2.Text = "metroTextBox2";
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.UseStyleColors = false;
            // 
            // UserControlAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroComboBox1);
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
            this.Controls.Add(this.metroUserControl1);
            this.Name = "UserControlAdd";
            this.Size = new System.Drawing.Size(625, 420);
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
         private MetroFramework.Controls.MetroComboBox metroComboBox1;
         private MetroFramework.Controls.MetroUserControl metroUserControl1;
         private MetroFramework.Controls.MetroTextBox metroTextBox1;
         private MetroFramework.Controls.MetroTextBox metroTextBox2;
     }
 }
