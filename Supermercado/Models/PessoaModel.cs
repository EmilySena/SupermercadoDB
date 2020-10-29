using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Supermercado.Models
{
    public class PessoaModel: IDisposable
    {
        private SqlConnection connection;
        public PessoaModel()
        {
            string strConn = "Data Source=OPN02\\SQLEXPRESS;Initial Catalog=BDPessoa;Integrated Security=true";
            connection = new SqlConnection(strConn);
            connection.Open();
        }
        public void Dispose()
        {
            connection.Close();
        }
        public List<Pessoa> Read()
        {
            List<Pessoa> lista = new List<Pessoa>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM Pessoa";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Pessoa pessoa = new Pessoa();
                pessoa.Id = (int)reader["IdContato"];
                pessoa.Nome = (string)reader["Nome"];
                pessoa.Idade = (int)reader["Idade"];
                pessoa.Email = (string)reader["Email"];
                pessoa.Login = (string)reader["Login"];
                lista.Add(pessoa);
            }

            return lista;
        }
        public void Create(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"INSERT INTO Pessoa VALUES (@nome, @idade, @email, @login)";
            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@idade", pessoa.Idade);
            cmd.Parameters.AddWithValue("@email", pessoa.Email);
            cmd.Parameters.AddWithValue("@login", pessoa.Login);
            cmd.ExecuteNonQuery();
        }
    }
}