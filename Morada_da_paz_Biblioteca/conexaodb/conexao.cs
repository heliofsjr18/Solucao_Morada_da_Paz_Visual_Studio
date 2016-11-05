using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Morada_da_paz_Biblioteca.conexaodb
{
    public interface conexao
    {
        SqlConnection conectar();

        void desconectar(SqlConnection conexao);
    }
}
