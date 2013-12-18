using System;
using System.Drawing;
using System.Windows.Forms;
using Mechanik.Rejestr;
using System.Xml.Linq;

namespace Mechanik
{
    public partial class Form1 : Form
    {
        Reg r = new Reg();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource=Enum.GetValues(typeof(Pojazdy.Marka.Typ));
            clearView();
            
        }
       

        

        #region Animacja przycisków menu

        private void buttonMenuView_MouseHover(object sender, EventArgs e)
        {
            buttonMenuView.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void buttonMenuView_MouseLeave(object sender, EventArgs e)
        {
            buttonMenuView.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void buttonMenuAddRepair_MouseHover(object sender, EventArgs e)
        {
            buttonMenuAddRepair.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
        private void buttonMenuAddRepair_MouseLeave(object sender, EventArgs e)
        {
            buttonMenuAddRepair.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        }

        private void buttonMenuSearch_MouseHover(object sender, EventArgs e)
        {
            buttonMenuSearch.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        }

        private void buttonMenuSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonMenuSearch.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        
        #endregion

        #region Buttons Click

        /// <summary>
        /// Zdarzenie klikniecia na przycisk
        /// Wyświetl auta
        /// Zmiania wszystkim User Controlom Visibility na "false"
        /// Ustawia userControlView.Visibility na true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuView_Click(object sender, EventArgs e)
        {
            clearView();
            userControlView.Visible = true;
        }

        /// <summary>
        /// Zdarzenie klikniecia na przycisk
        /// Dodaj naprawe
        /// Zmiania wszystkim User Controlom Visibility na "false"
        /// Ustawia userControlAdd.Visibility na true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuAddRepair_Click(object sender, EventArgs e)
        {
            clearView();
            userControlAdd.Visible = true;
        }


        /// <summary>
        /// Zdarzenie klikniecia na przycisk
        /// Szukaj
        /// Zmiania wszystkim User Controlom Visibility na "false"
        /// Ustawia userControlSearch.Visibility na true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuSearch_Click(object sender, EventArgs e)
        {
            clearView();
            userControlSearch.Visible = true;
        }

        #endregion
       
        
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /// <summary>
        /// Chowa wszyskie User Cntrol'e
        /// </summary>
       public void clearView()
        {
            userControlView.Visible = false;
            userControlAdd.Visible = false;
            userControlSearch.Visible = false;
        }

       private void panelView_Paint(object sender, PaintEventArgs e)
       {
           


       }

       private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void wybierzPlikXMLToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (openFileDialogXml.ShowDialog() == DialogResult.OK)
           {
               
               r.Path = openFileDialogXml.FileName;
               buttonMenuView_Click(null, null);
            }
       }

       private void nowyPlikXMLToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (saveFileDialogXML.ShowDialog() == DialogResult.OK)
           {
               if (saveFileDialogXML.FileName != null)
               {
                   r.Path = saveFileDialogXML.FileName;
                   XDocument xml = new XDocument(
                    new XElement("dane"));

                   xml.Save(r.Path);
                   buttonMenuView_Click(null, null);
               }
           }
       }

       private void userControlView_Load(object sender, EventArgs e)
       {

       }

       

     
    }
}
