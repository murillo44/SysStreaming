using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDao
    {
        public List<Categoria> GetCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                using (SqlConnection con = new SqlConnection(ConexionesDB.GetConexionUAIStreaming()))
                {
                    con.Open();
                    string query = "SELECT * FROM CATEGORIA";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Categoria categoria = new Categoria
                                {
                                    IdCategoria = Convert.ToInt32(reader["ID_CATEGORIA"].ToString()),
                                    Descripcion = reader["DESCRIPCION"].ToString()
                                };
                                listaCategorias.Add(categoria);
                            }
                        }
                    }
                }
                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
