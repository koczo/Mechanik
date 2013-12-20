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
                        if(control.Equals(view))
                            view.LoadView();
                        if (control.Equals(search))
                            search.LoadView();
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
           add.SaveButtonClicked += add_SaveButtonClicked;
           DisplayUserControl(add);
       }

       void add_SaveButtonClicked(object sender, EventArgs e)
       {
           //throw new NotImplementedException();
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
