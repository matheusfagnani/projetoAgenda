using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgenda.variableGlobal
{
    internal class User_session
    {
        public static string _nome = null;
        public static string _usuario = null;
         public static string _senha = null;



        public string nome
        {
            get { return _nome;}
            set { value = value.ToUpper();
                _nome = value; }
        }

         public string Usuario
        {
            get
            {
                return _usuario;

            }
            set
            {
                value = value.ToUpper();
                _usuario = value;
            }
        }
            

            public string senha {
            get { return _senha; }

            set { _senha = value; } 
        
        }
        }



}
