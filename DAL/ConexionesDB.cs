using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConexionesDB
    {
        public static string GetConexionUAIStreaming()
        {
            return ConfigurationManager.ConnectionStrings["UAIStreamingDBCon"].ConnectionString;
        }
    }
}
