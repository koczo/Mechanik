using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mechanik
{
    public partial class UserControlAdd : UserControl
    {
        public event EventHandler SaveButtonClicked;

        public UserControlAdd()
        {
            InitializeComponent();
        }
    }
}
