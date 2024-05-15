﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DataUsuarios
    {
        private ConexionSQL connSQL = new ConexionSQL();
        private SqlCommand comandoSQL = new SqlCommand();
        public int RenglonesAfectados = 0;

        public DataUsuarios()
        {

        }

        public Boolean Insertar(string nombre, string apellidoP, string apellidoM, string correo, string direccion, string telefono)
        {
            try
            {
                comandoSQL.Connection = connSQL.AbrirConexion();
                comandoSQL.CommandText = "proc_InsertarUsuario";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.AddWithValue("@nombre", nombre);
                comandoSQL.Parameters.AddWithValue("@apellidoP", apellidoP);
                comandoSQL.Parameters.AddWithValue("@apellidoM", apellidoM);
                comandoSQL.Parameters.AddWithValue("@correo", correo);
                comandoSQL.Parameters.AddWithValue("@direccion", direccion);
                comandoSQL.Parameters.AddWithValue("@telefono", telefono);

                RenglonesAfectados = comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();

                return true; // Indica que la inserción fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuarios:Insertar " + ex.Message);
                return false; // Indica que hubo un error durante la inserción
            }
        }

        public Boolean Autenticar(string usuario, string pass)
        {
            try
            {
                comandoSQL.Connection = connSQL.AbrirConexion();
                comandoSQL.CommandText = "proc_ValidaUsuario";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                comandoSQL.Parameters.AddWithValue("@password", pass);

                RenglonesAfectados = comandoSQL.ExecuteNonQuery();
                comandoSQL.Parameters.Clear();
                connSQL.CerrarConexion();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DataUsuarios:Autenticar " + ex.Message);
                RenglonesAfectados = 0;
                return false;
            }
        }
    }
}