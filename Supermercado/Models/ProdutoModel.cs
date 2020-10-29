using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Supermercado.Models
{
    public class ProdutoModel : IDisposable
    {
        private SqlConnection connection;
        public ProdutoModel()
        {
            string strConn = "Data Source=OPN02\\SQLEXPRESS;Initial Catalog=BDProduto;Integrated Security=true";
            connection = new SqlConnection(strConn);
            connection.Open();
        }
        public void Dispose()
        {
            connection.Close();
        }
        public List<Produto> Read()
        {
            List<Produto> lista = new List<Produto>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM Produto";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Produto produto = new Produto();
                produto.Codigo = (int)reader["Id"];
                produto.Nome = (string)reader["Nome"];
                produto.Categoria = (string)reader["Categoria"];
                produto.Marca = (string)reader["Marca"];
                produto.Preco = (string)reader["Preco"];
                lista.Add(produto);
            }

            return lista;
        }
    }
}