using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class Utilerias
    {
        public static Boolean validaVacio(String valor)
        {
            if (valor.Length == 0)
                return false;
            else
                return true;
        }
    }
}
