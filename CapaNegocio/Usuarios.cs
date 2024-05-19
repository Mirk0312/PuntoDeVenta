using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuarios
    {
        private String usuario, password;
        public void setUsuario(string usuario) {
            this.usuario = usuario;
        }
        public string getUsuario()
        {
            return this.usuario;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()      
        {  
            return this.password;
        }


    }
}

