using Mechanik.Pojazdy;
using Mechanik.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mechanik
{
    public partial class UserControlAdd : UserControl
    {
        public event EventHandler SaveButtonClicked;

        public UserControlAdd()
        {
            InitializeComponent();
            
            comboBoxMarka.DataSource = Enum.GetValues(typeof(Pojazdy.Typ));
        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNrRej.Text) && comboBoxMarka.SelectedIndex != 0 && !String.IsNullOrEmpty(textBoxModel.Text) && !String.IsNullOrEmpty(textBoxKolor.Text) && !String.IsNullOrEmpty(textBoxNrKolor.Text))
            {
                if (!File.Exists(Settings.Default.PATH) || Settings.Default.PATH == null)
                {
                    if (saveFileDialogXML.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialogXML.FileName != null)
                        {
                            Settings.Default.PATH = saveFileDialogXML.FileName;
                            Settings.Default.Save();
                            XDocument xml = new XDocument(
                             new XElement("dane"));

                            xml.Save(Settings.Default.PATH);
                        }

                    }
                }
                List<Auto> auta = Auto.ReadFromXML(Settings.Default.PATH);

                if (Auto.Exists(auta, textBoxNrRej.Text))
                {
                    MessageBox.Show("Pojazd juz istnieje");
                }
                else
                {
                    auta.Add(new Auto(
                        textBoxNrRej.Text.ToUpper(),
                        comboBoxMarka.Text.ConvertToEnum<Typ>(),
                        textBoxModel.Text.FirstToUpper(),
                        textBoxKolor.Text.FirstToUpper(),
                        textBoxNrKolor.Text.ToUpper(),
                        richTextBoxOpis.Text.FirstToUpper()
                        ));

                    Auto.Write(auta);
                    textBoxNrRej.Text = String.Empty;
                    comboBoxMarka.SelectedIndex = 0;
                    textBoxModel.Text = String.Empty;
                    textBoxKolor.Text = String.Empty;
                    textBoxNrKolor.Text = String.Empty;
                    richTextBoxOpis.Text = String.Empty;
                    this.Visible = false;

                }

            }
            else
                MessageBox.Show("Wypłnij poprawnie formularz dodania pojazdu", "Błąd w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.SaveButtonClicked(sender, e);
        }
    }
}