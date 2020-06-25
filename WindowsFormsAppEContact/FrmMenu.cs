using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEContact
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            frmListContact frmlstc = new frmListContact();
            frmlstc.Dock = DockStyle.Fill;
            pContent.Controls.Add(frmlstc);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            FrmAddContact frmAdd = new FrmAddContact();
            frmAdd.Dock = DockStyle.Fill;
            pContent.Controls.Add(frmAdd);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            btnListContact_Click(sender, e);

        }
    }
}
