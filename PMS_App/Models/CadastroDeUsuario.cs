using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PMS_App.Models
{
    public class CadastroDeUsuario
    {
        Usuario usuario = new Usuario();

        List<Usuario> listaUsuario = new List<Usuario>();


        public bool adcionarUsuario(Usuario usuarioAux) 
        {
            string connection = @"Data Source=RAVINDRA\SQLEXPRESS;
        Initial Catalog=Employee;Integrated Security=SSPI;";

        //[WebMethod]
       // [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
       /* public string InsertEmployee(string empID, string firstName,
            string lastName, string address, string city,
            string pincode, string state, string country)*/
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Usuario( Nome, Email,QtdHorasNomimais,QtdHorasDisponiveis) VALUES(@usuarioAux.Nome ,@usuarioAux.Email, @usuarioAux.QtdHorasDisponiveis,@usuarioAux.QtdHorasNominais)";
                cmd.Parameters.AddWithValue("@usuarioAux.Nome", usuarioAux.Matricula);
                cmd.Parameters.AddWithValue("@usuarioAux.Email", usuarioAux.Email);
                cmd.Parameters.AddWithValue("@usuarioAux.QtdHorasNominais", usuarioAux.QtdHorasNominais);
                cmd.Parameters.AddWithValue("@usuarioAux.QtdHorasDisponiveis", usuarioAux.QtdHorasDisponiveis);
                
                cmd.ExecuteNonQuery();
                return true;
               Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
                return false;
        }

    }
    }
}