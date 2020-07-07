using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppEContact.Modèles;

namespace WindowsFormsAppEContact
{
    static class Program
    {
        private static string mohamed;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBContact.AddContact(new Contact("Mohamed Ali", DateTime.Parse("01/01/1984"),"mohamed@gmail.com","98 44 88 47", "M", null));
            DBContact.AddContact(new Contact("Hassan Ali", DateTime.Parse("01/11/1988"), "hassan@gmail.com", "99 44 98 27", "M", null));
            DBContact.AddContact(new Contact("Mohamed Alamin", DateTime.Parse("01/12/1974"), "mohamedal@gmail.com", "90 87 87 77", "M", null));
            DBContact.AddContact(new Contact("Fatim Ali", DateTime.Parse("31/01/1994"), "fatim@gmail.com", "84 24 24 24", "F", null));
            DBContact.AddContact(new Contact("khadidjia Ali", DateTime.Parse("31/12/1988"), "khadidj@gmail.com", "93 23 24 24", "F", null));
            DBContact.AddContact(new Contact("Boubacar Ali", DateTime.Parse("11/11/1989"), "boube@gmail.com", "84 84 84 47", "M", null));
            DBContact.AddContact(new Contact("Maryam Ali", DateTime.Parse("31/12/1990"), "maryama@gmail.com", "99 44 88 77", "F", null));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
