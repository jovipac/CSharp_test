using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaAereas.Properties
{
    interface ICopyPasteable
    {
        void CutToClipboard();
        void CopyToClipboard();
        void PasteFromClipboard();
    }

    public class MyTextBox : TextBox, ICopyPasteable
    {

        #region ICopyPasteable Membres

        public void CutToClipboard()
        {
            Clipboard.SetText(this.SelectedText);
            this.Text = string.Empty;
        }

        public void CopyToClipboard()
        {
            Clipboard.SetText(this.Text);
        }

        public void PasteFromClipboard()
        {
            if (Clipboard.ContainsText())
            {
                this.Text = Clipboard.GetText();
            }
        }

        #endregion
    }
}
