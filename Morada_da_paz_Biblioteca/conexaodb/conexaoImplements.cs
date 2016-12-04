using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.conexaodb
{
    public class conexaoImplements : conexao
    {
        public SqlConnection conectar()
        {            
            string stringconnection;
            if (dadosBanco.SegIntegrada == "T")
                stringconnection = @"Data Source=" + dadosBanco.url + ";Initial Catalog=" + dadosBanco.banco + ";User ID=" + dadosBanco.usuario + ";Password=" + dadosBanco.senha + ";Integrated Security=sspi" + ";";
            else
                stringconnection = @"Data Source=" + dadosBanco.url + ";Initial Catalog=" + dadosBanco.banco + ";User ID=" + dadosBanco.usuario + ";Password=" + dadosBanco.senha + ";";

            SqlConnection con = new SqlConnection(stringconnection);
            desconectar(con);
            con.Open();
            
            return con;
        }

        public void desconectar(SqlConnection conexao)
        {
            conexao.Close();            
        }        
                              
    }
}
