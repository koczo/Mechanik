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
using System.Threading;

namespace Mechanik
{
    public partial class UserControlView : UserControl
    {

        public event EventHandler LoadViewEvent;
        public UserControlView()
        {
            InitializeComponent();
            this.LoadViewEvent += UserControlView_LoadViewEvent;
        }

        void UserControlView_LoadViewEvent(object sender, EventArgs e)
        {
            LoadView();
        }

        
        private void listViewCar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Auto auto = new Auto
                (
                listViewCar.SelectedItems[0].SubItems[0].Text,
                listViewCar.SelectedItems[0].SubItems[1].Text.ConvertToEnum<Typ>(),
                listViewCar.SelectedItems[0].SubItems[2].Text,
                listViewCar.SelectedItems[0].SubItems[3].Text,
                listViewCar.SelectedItems[0].SubItems[4].Text,
                listViewCar.SelectedItems[0].SubItems[5].Text

                );

            EditForm edit = new EditForm();
            
            edit.textRej = auto.NrRej;
            edit.marka = auto.Marka;
            edit.textModel = auto.Model;
            edit.textKolor = auto.Kolor;
            edit.textNrKolor = auto.NrKolor;
            edit.textOpis = auto.Opis;
            edit.ShowDialog();



        }

        public void LoadView()
        {
            
            if (!String.IsNullOrEmpty(Settings.Default.PATH) && File.Exists(Settings.Default.PATH))
            {
                listViewCar.Items.Clear();
                listViewCar.Visible = false;
                metroProgressSpinner.Visible = true;
                metroProgressSpinner.Value = 0;
                List<Auto> auta = Auto.ReadFromXML(Settings.Default.PATH);
                metroProgressSpinner.Maximum = auta.Count;
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
                    metroProgressSpinner.Value = i;
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Marka.ToString());
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Model);
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Kolor);
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.NrKolor);
                    listViewCar.Items[listViewCar.Items.Count - 1].SubItems.Add(a.Opis);

                }
                metroProgressSpinner.Visible = false;
                listViewCar.Visible = true;
            }
        }

  
    }
}
