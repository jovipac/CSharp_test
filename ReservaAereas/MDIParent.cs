using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservaAereas.Properties;

namespace ReservaAereas
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowAboutForm(object sender, EventArgs e)
        {
            frmAboutBox AboutForm = new frmAboutBox();
            AboutForm.MdiParent = this;
            AboutForm.Show();
        }

        private void ShowRunwayForm(object sender, EventArgs e)
        {
            Form RunwayForm = new frmRunway();
            RunwayForm.MdiParent = this;
            RunwayForm.Show();
        }

        private void ShowAirlineForm(object sender, EventArgs e)
        {
            Form AirlineForm = new frmAirline();
            AirlineForm.MdiParent = this;
            AirlineForm.Show();
        }

        private void ShowLogin(object sender, EventArgs e)
        {
            frmLogin LoginDialog = new frmLogin();
            LoginDialog.OwningLoginForm = LoginDialog;
            LoginDialog.ShowDialog();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICopyPasteable control = sender as ICopyPasteable;
            if (control != null)
            {
                control.CutToClipboard();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICopyPasteable control = sender as ICopyPasteable;
            if (control != null)
            {
                control.CopyToClipboard();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICopyPasteable control = sender as ICopyPasteable;
            if (control != null)
            {
                control.PasteFromClipboard();
            }
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

    }
}
