using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppEContact.Modèles;

namespace WindowsFormsAppEContact
{
    public partial class frmListContact : UserControl
    {
       
        public frmListContact()
        {
            InitializeComponent();
        }

        private void frmListContact_Load(object sender, EventArgs e)
        {
            BindingList<Contact> lst= new BindingList<Contact>(DBContact.GetlstContacts());
            dgvContact.DataSource = lst;
            dgvContact.AutoResizeColumns();
            dgvContact.AllowUserToResizeColumns = true;
            dgvContact.AllowUserToOrderColumns = true;
        }
    }
}
