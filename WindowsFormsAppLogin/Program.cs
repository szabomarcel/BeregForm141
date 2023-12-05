using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    internal static class Program
    {
        //-- a többi osztályban (Form-ok) is használhatók
        public static FormLogin formLogin = null;
        public static FormVasarlas formVasarlas = null;
        /*public static MySqlConnection connection = null;
        public static MySqlCommand command = null;*/
        public static int UserId;
        public static Database db = new Database();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin = new FormLogin();
            formVasarlas = new FormVasarlas();
            Application.Run(formLogin);
        }
    }
}
