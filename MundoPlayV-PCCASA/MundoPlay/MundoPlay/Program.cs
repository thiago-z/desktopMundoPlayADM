using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MundoPlay
{
    public static class Program
    {
        //Variavel global do usuário que vai se logar
        //Puxa o nome do usuário logado
        public static string nomeUsuario = "";
        //Puxa a senha?????
        public static string senhaUsuario = "";
        //Puxa se usuário tem privilegios adm
        public static string admUsuario = "";
        //Puxa foto do usuário
        public static string fotoUsuario = "";


        public static string privilegioADM = "Administrador";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
