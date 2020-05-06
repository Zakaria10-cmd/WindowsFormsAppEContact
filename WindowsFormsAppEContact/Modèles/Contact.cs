using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEContact.Modèles
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nomcomplet { get; set; }
            public DateTime Datenaiss { get; set; }
       
           public string Email { get; set; }
       
           public string Tel { get; set;}
       
          public string Genre { get; set; }

        public byte[] Photo { get; set; }

        public Contact(string nomcomplet, DateTime datenaiss, string email, string tel, string genre, byte[] Photo)
        {
            Nomcomplet = nomcomplet;
            this.Datenaiss = datenaiss;
            this.Email = email;
            this.Tel = tel;
            this.Genre = genre;
            this.Photo = Photo;
        }
        public Contact()
        {

        }
       


    }
}
