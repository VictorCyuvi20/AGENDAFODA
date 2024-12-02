using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDAFODA.VariabeGoblal
{
    public static class UserSession
    {
        private static string _nome = null;
        private static string _usuario = null;
        private static string _senha = null;

        public static string usuario
        {
            get { return _usuario; }
            set {
                value = value; 
                 _usuario = value; }
        }
        public static string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public static string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

    }
}
