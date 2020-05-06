using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEContact.Modèles
{
   public static class DBContact
    {
        public static List<Contact> lstContacts;


        // Ajouter un contact à la liste des contacts 
        public static int AddContact(Contact c)
        {
            if (lstContacts==null)
            {
                lstContacts = new List<Contact>();
            }
            c.Id = lstContacts.Any() ? lstContacts.Max(x => x.Id)+1:100 ; // lamda Expressions
            lstContacts.Add(c);
            return 0;
        }
        // Récuperer la liste des contacts
        public static List<Contact> GetlstContacts()
        {
            return lstContacts;
        }
        // supprimer un contact
        public static void DeleteContact(int idContact)
        {
            int index = lstContacts.FindIndex(x => x.Id == idContact);
                lstContacts.RemoveAt(index);
        }
        //Modifier un contact

        public static void Updatecontact(Contact c)
        {
            Contact rech = lstContacts.FirstOrDefault(x => x.Id == c.Id);
            rech.Nomcomplet = c.Nomcomplet;
            rech.Datenaiss = c.Datenaiss;
            rech.Email = c.Email;
            rech.Genre = c.Genre;
            rech.Tel = c.Tel;
            rech.Photo = c.Photo;
        }

        // Chercher par Nom
        public static List<Contact> SearchContact(string name)
        {
            List<Contact> res = lstContacts.Where(x => x.Nomcomplet.ToLower().Contains(name.ToLower())).ToList();
            return res;
        }


    }
}
