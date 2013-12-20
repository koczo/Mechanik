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
        public Typ marka;
        UserControlView view;
        UserControlSearch search;

        public EditForm()
        {
            InitializeComponent();
            view = new UserControlView();
            search = new UserControlSearch();
            view.LoadViewEvent += view_LoadViewEvent;
        }
    

        private void EditForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edycja pojazdu o numerze \nrejestracyjnym " + textRej;
            labelTytyl.Text = textRej;
            comboBoxMarka.DataSource = Enum.GetValues(typeof(Typ));

            comboBoxMarka.SelectedIndex = comboBoxMarka.Items.IndexOf(marka);
            textBoxModel.Text = textModel;
            textBoxKolor.Text = textKolor;
            textBoxNrKolor.Text = textNrKolor;
            richTextBoxOpis.Text = textOpis;

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
                    a.Marka = comboBoxMarka.Text.ConvertToEnum<Typ>();
                    a.Model = textBoxModel.Text;
                    a.Kolor = textBoxKolor.Text;
                    a.NrKolor = textBoxNrKolor.Text;
                    a.Opis = richTextBoxOpis.Text;

                    Auto.Edit(a);
                    view.LoadView();
                    
                    this.Close();
                }

            }
            else
                MessageBox.Show("Wypłnij poprawnie formularz edycji pojazdu", "Błąd w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        void view_LoadViewEvent(object sender, EventArgs e)
        {
            buttonDelate_Click(sender, e);
        }
    }
}
