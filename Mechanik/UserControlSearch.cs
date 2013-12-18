using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mechanik.Pojazdy;
using System.Linq;
using Mechanik.Rejestr;
using System.IO;
using Mechanik.Properties;

namespace Mechanik
{
    public partial class UserControlSearch : UserControl
    {

        //Reg r = new Reg();
        public UserControlSearch()
        {
            InitializeComponent();
        }

        private void textBoxNrRej_TextChanged(object sender, EventArgs e)
        {
            
            
            FillList(comboBoxMarka.Text, textBoxNrKolor.Text);
            
        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {
            comboBoxMarka.DataSource = Enum.GetValues(typeof(Pojazdy.Marka.Typ));
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FillList(comboBoxMarka.Text, textBoxNrKolor.Text);

        }

        public void FillList(string marka, string kolor)
        {
            if (Settings.Default.PATH != null || !File.Exists(Settings.Default.PATH))
            {
                List<Auto> auta = Auto.ReadFromXML(Settings.Default.PATH);
                listViewCar.Items.Clear();
                var s = new List<Auto>();

                if (kolor != null && kolor != "" && marka != "Wybierz")
                {
                    s = auta.Where(k => k.NrKolor.Contains(kolor) && k.Marka == marka.ConvertToEnum<Marka.Typ>()).ToList();
                }
                else if (kolor == null || kolor == "" && marka != "Wybierz")
                {
                    s = auta.Where(k => k.Marka == marka.ConvertToEnum<Marka.Typ>()).ToList();
                }
                else if (kolor != null && kolor != "" && marka == "Wybierz")
                {
                    s = auta.Where(k => k.NrKolor.Contains(kolor)).ToList();
                }


                int i = 0;

                foreach (var a in s)
                {


                    listViewCar.Items.Add(a.NrRej);

                    if (i % 2 == 0)
                        listViewCar.Items[i].BackColor = SystemColors.Info;
                    else
                        listViewCar.Items[i].BackColor = SystemColors.Window;
                    i++;

                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Marka.ToString());
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Model);
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Kolor);
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.NrKolor);
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Opis);


                } 
            }
        }

        private void listViewCar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(listViewCar.SelectedItems[0].SubItems[4].Text);
            //TO-DO 
            //Okno Edit z możliwościa edytowania 
            Auto auto = new Auto
                (
                listViewCar.SelectedItems[0].SubItems[0].Text,
                listViewCar.SelectedItems[0].SubItems[1].Text.ConvertToEnum<Marka.Typ>(),
                listViewCar.SelectedItems[0].SubItems[2].Text,
                listViewCar.SelectedItems[0].SubItems[3].Text,
                listViewCar.SelectedItems[0].SubItems[4].Text,
                listViewCar.SelectedItems[0].SubItems[5].Text

                );

            EditForm edit = new EditForm(this);

            edit.textRej = auto.NrRej;
            edit.marka = auto.Marka;
            edit.textModel = auto.Model;
            edit.textKolor = auto.Kolor;
            edit.textNrKolor = auto.NrKolor;
            edit.textOpis = auto.Opis;
            edit.ShowDialog();
        }

        public void Refr()
        {

            FillList(comboBoxMarka.Text, textBoxNrKolor.Text);
        }

      
    }
}
