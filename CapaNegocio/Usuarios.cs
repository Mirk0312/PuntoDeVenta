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


        public Boolean fnValidarLogin()
        {
            try
            {
                //Instanciar usuario en la capa de datos
                DataUsuarios user = new DataUsuarios();
                // Llamar al método Autenticar y obtener el resultado
                bool resultado = user.Autenticar(getUsuario(), getPassword());
                // Devolver el resultado de la autenticación
                return resultado;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y registrarla en la consola
                Console.WriteLine("[fnValidarLogin] ---> " + ex.Message);
                // Devolver falso en caso de excepción
                return false;
            }
        }

    }
}

