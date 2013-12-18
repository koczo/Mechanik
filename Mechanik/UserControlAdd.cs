using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Mechanik.Pojazdy;
using Mechanik.Rejestr;

namespace Mechanik
{
    public partial class UserControlAdd : UserControl
    {
        Reg r = new Reg();
        UserControlView _usv = new UserControlView();
        public UserControlAdd()
        {
            InitializeComponent();

            comboBoxMarka.DataSource = Enum.GetValues(typeof(Pojazdy.Marka.Typ));
        }
        public UserControlAdd(UserControlView usv)
        {
            InitializeComponent();
            _usv = usv;
            this.buttonSave.Click += new EventHandler((e, s) => _usv.ShowView());
            comboBoxMarka.DataSource = Enum.GetValues(typeof(Pojazdy.Marka.Typ));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(r.Path) || r.Path == null)
            {
                if (saveFileDialogXML.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialogXML.FileName != null)
                    {
                        r.Path = saveFileDialogXML.FileName;
                        XDocument xml = new XDocument(
                         new XElement("dane"));

                        xml.Save(r.Path);
                    }

                }
            }

            else
            {
                if (!String.IsNullOrEmpty(textBoxNrRej.Text) && comboBoxMarka.SelectedIndex != 0 && !String.IsNullOrEmpty(textBoxModel.Text) && !String.IsNullOrEmpty(textBoxKolor.Text) && !String.IsNullOrEmpty(textBoxNrKolor.Text))
                {
                    List<Auto> auta = Auto.ReadFromXML(r.Path);

                    if (Auto.Exists(auta, textBoxNrRej.Text))
                    {
                        MessageBox.Show("Pojazd juz istnieje");
                    }
                    else
                    {
                        auta.Add(new Auto(
                            textBoxNrRej.Text.ToUpper(),
                            comboBoxMarka.Text.ConvertToEnum<Mechanik.Pojazdy.Marka.Typ>(),
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
                        _usv.ShowView();
                    }

                }
                else
                    MessageBox.Show("Wypłnij poprawnie formularz dodania pojazdu","Błąd w formularzu",MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }

        }

        private void UserControlAdd_Load(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Text = "Dodawanie nowego pojazdu";
        }



    }
}
