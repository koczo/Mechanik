using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mechanik.Pojazdy;
using System.Xml.Linq;
using System.Linq;
using Mechanik.Rejestr;
using System.IO;
using Mechanik.Properties;

namespace Mechanik
{
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {
        public string textOpis, textRej, textModel, textKolor, textNrKolor;
        public Marka.Typ marka;
        UserControlView _usV;
        UserControlSearch _usS;
        //Reg r = new Reg();


        public EditForm(UserControlView usV)
        {
            InitializeComponent();
            _usV = usV;
            this.FormClosing += new FormClosingEventHandler(EditForm_FormClosing);

        }
        public EditForm(UserControlSearch usS)
        {
            InitializeComponent();
            _usS = usS;
            FormClosing += new FormClosingEventHandler(EditForm_FormClosing);

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edycja pojazdu o numerze \nrejestracyjnym " + textRej;
            labelTytyl.Text = textRej;
            comboBoxMarka.DataSource = Enum.GetValues(typeof(Pojazdy.Marka.Typ));

            comboBoxMarka.SelectedIndex = comboBoxMarka.Items.IndexOf(marka);

            //MessageBox.Show(comboBoxMarka.Items.IndexOf(marka).ToString());
            textBoxModel.Text = textModel;
            textBoxKolor.Text = textKolor;
            textBoxNrKolor.Text = textNrKolor;
            richTextBoxOpis.Text = textOpis;

        }

        private void labelTytyl_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxMarka.SelectedIndex != 0 && !String.IsNullOrEmpty(textBoxModel.Text) && !String.IsNullOrEmpty(textBoxKolor.Text) && !String.IsNullOrEmpty(textBoxNrKolor.Text))
            {

                if (Settings.Default.PATH != null || !File.Exists(Settings.Default.PATH))
                {
                    List<Auto> auta = Auto.ReadFromXML(Settings.Default.PATH);
                    var a = (from auto in auta
                             where auto.NrRej == textRej
                             select auto).FirstOrDefault();
                    a.Marka = comboBoxMarka.Text.ConvertToEnum<Marka.Typ>();
                    a.Model = textBoxModel.Text;
                    a.Kolor = textBoxKolor.Text;
                    a.NrKolor = textBoxNrKolor.Text;
                    a.Opis = richTextBoxOpis.Text;

                    Auto.Write(auta);
                    this.Close();
                }

            }
            else
                MessageBox.Show("Wypłnij poprawnie formularz edycji pojazdu", "Błąd w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_usV != null)
                _usV.Refreshes();
            if (_usS != null)
                _usS.Refr();
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {

            if (Settings.Default.PATH != null || !File.Exists(Settings.Default.PATH))
            {
                List<Auto> auta = Auto.ReadFromXML(Settings.Default.PATH);
                var a = (from auto in auta
                         where auto.NrRej == textRej
                         select auto).FirstOrDefault();
                auta.Remove(a);
                Auto.Write(auta);
                this.Close();
            }

        }







    }
}
