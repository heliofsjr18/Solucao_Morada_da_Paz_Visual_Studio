using System.Text;
using System.Threading.Tasks;
using projeto_morada_da_paz.basicas;
using projeto_morada_da_paz.conexaodb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    class CrudMulta_OcorrenciaImplements : conexaoImplements, CrudMulta_Ocorrencia
    {
        public void inserir(multa m, ocorrencia o)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO ocorrencia_multa (id_ocorrencia, id_multa)";
                insertSql += " values ";
                insertSql += " (@id_ocorrencia, @id_multa)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@id_ocorrencia", o.Id);
                comand.Parameters.AddWithValue("@id_multa", m.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
