using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class acAccountNameBox : TextBox
    {
        public acAccountNameBox()
        {
            InitializeComponent();
        }
        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
           
            if (char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                return;
            }

            if (InvalidUserEntry != null)
                InvalidUserEntry(this, e);
        }
    }
}