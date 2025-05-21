using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBusiness
    {
        private CategoriaDao CategoriaDao = new CategoriaDao();

        public List<Categoria> GetCategorias()
        {
            try
            {
                return CategoriaDao.GetCategorias();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
