using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Mechanik.Pojazdy;
using Mechanik.Rejestr;
using System.IO;
using Mechanik.Properties;

namespace Mechanik
{
    public partial class UserControlView : UserControl
    {
        // Zrobić publiczna podawana z Form 1 
        //domyślnie ściezka zapisana w rejestrze


        //Reg r = new Reg();
        public UserControlView()
        {
            InitializeComponent();
        }

        public void ShowView()
        {

            this.Visible = true;
        }

        private void UserControlView_Load(object sender, EventArgs e)
        {

            if (Settings.Default.PATH != null || !File.Exists(Settings.Default.PATH))
            {
                List<Auto> auta = Auto.ReadFromXML(Settings.Default.PATH);

                //Wczytuje z pliku XML i wpisuje w ListView



                int i = 0;
                foreach (var a in auta)
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

        private void listViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControlView_VisibleChanged(object sender, EventArgs e)

        {
            listViewCar.Items.Clear();
            UserControlView_Load(null, null);
        }
       
        public void Refreshes()
        {
            UserControlView_VisibleChanged(null,null);
        }

       
    }
}
