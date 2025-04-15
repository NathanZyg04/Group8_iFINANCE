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
    public partial class acOpenAmountBox : TextBox
    {
        public acOpenAmountBox()
        {
            InitializeComponent();
        }

        public delegate void InvalidUserEntryEvent(object sender, KeyPressEventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Accept alphnumeric only.

            if (char.IsDigit(e.KeyChar) || e.KeyChar =='.' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
            }

            if (InvalidUserEntry != null)
                InvalidUserEntry(this, e);
        }
    }
}
