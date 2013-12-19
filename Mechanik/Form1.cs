using System;
using System.Drawing;
using System.Windows.Forms;
using Mechanik.Rejestr;
using System.Xml.Linq;
using Mechanik.Properties;

namespace Mechanik
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        UserControlAdd add;
        UserControlSearch search;
        UserControlView view;
        

        public Form1()
        {
           
            InitializeComponent();
            view = new UserControlView();
            add = new UserControlAdd();
            search = new UserControlSearch();
            metroPanel.Controls.Add(view);
            DisplayUserControl(view);
          
        }


        internal void DisplayUserControl(UserControl userControl)
        {
            foreach (Control control in metroPanel.Controls)
            {
                if (control is UserControl)
                {
                    if (control == userControl)
                    {
                        control.Visible = true;
                        control.Enabled = true;
                        control.BringToFront();
                        control.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        control.Visible = false;
                        control.Enabled = false;
                        control.Dock = DockStyle.None;
                        Controls.Remove(control);
                    }
                }
            }
        }
       

        

        //#region Animacja przycisków menu

        //private void buttonMenuView_MouseHover(object sender, EventArgs e)
        //{
        //    buttonMenuView.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //}

        //private void buttonMenuView_MouseLeave(object sender, EventArgs e)
        //{
        //    buttonMenuView.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        //}

        //private void buttonMenuAddRepair_MouseHover(object sender, EventArgs e)
        //{
        //    buttonMenuAddRepair.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //}
        //private void buttonMenuAddRepair_MouseLeave(object sender, EventArgs e)
        //{
        //    buttonMenuAddRepair.Font = new Font("Segoe UI", 10, FontStyle.Regular);

        //}

        //private void buttonMenuSearch_MouseHover(object sender, EventArgs e)
        //{
        //    buttonMenuSearch.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        //}

        //private void buttonMenuSearch_MouseLeave(object sender, EventArgs e)
        //{
        //    buttonMenuSearch.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        //}

        
        //#endregion

        //#region Buttons Click

        ///// <summary>
        ///// Zdarzenie klikniecia na przycisk
        ///// Wyświetl auta
        ///// Zmiania wszystkim User Controlom Visibility na "false"
        ///// Ustawia userControlView.Visibility na true
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void buttonMenuView_Click(object sender, EventArgs e)
        //{
        //    clearView();
        //    userControlView.Visible = true;
        //}

        ///// <summary>
        ///// Zdarzenie klikniecia na przycisk
        ///// Dodaj naprawe
        ///// Zmiania wszystkim User Controlom Visibility na "false"
        ///// Ustawia userControlAdd.Visibility na true
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void buttonMenuAddRepair_Click(object sender, EventArgs e)
        //{
        //    clearView();
        //    userControlAdd.Visible = true;
        //}


        ///// <summary>
        ///// Zdarzenie klikniecia na przycisk
        ///// Szukaj
        ///// Zmiania wszystkim User Controlom Visibility na "false"
        ///// Ustawia userControlSearch.Visibility na true
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void buttonMenuSearch_Click(object sender, EventArgs e)
        //{
        //    clearView();
        //    userControlSearch.Visible = true;
        //}

        //#endregion
       
        

       private void wybierzPlikXMLToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (openFileDialogXml.ShowDialog() == DialogResult.OK)
           {
               
               Settings.Default.PATH = openFileDialogXml.FileName;
               Settings.Default.Save();
             
            }
       }

       private void nowyPlikXMLToolStripMenuItem_Click(object sender, EventArgs e)
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


       private void metroTileAdd_Click(object sender, EventArgs e)
       {
           
           metroPanel.Controls.Add(add);
           DisplayUserControl(add);
       }

       private void metroTileSearch_Click(object sender, EventArgs e)
       {
           
           metroPanel.Controls.Add(search);
           DisplayUserControl(search);
       }

       private void metroTileView_Click(object sender, EventArgs e)
       {
           metroPanel.Controls.Add(view);
           DisplayUserControl(view);
       }

       

     
    }
}
