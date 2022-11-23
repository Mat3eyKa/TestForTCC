using System;

using System.Windows.Forms;

namespace AdminForms
{
    public class Settrings
    {
        public void CheckLetters(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8)
                e.Handled = true;
        }

        public void CheckIsDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
    
}
