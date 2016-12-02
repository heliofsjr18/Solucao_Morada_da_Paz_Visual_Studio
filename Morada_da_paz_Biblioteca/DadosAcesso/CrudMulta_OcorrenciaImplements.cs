using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.conexaodb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public class CrudMulta_OcorrenciaImplements : conexaoImplements, CrudMulta_Ocorrencia
    {
        public void inserir(multa m, ocorrencia o)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO ocorrencia_multa (id_ocorrencia, id_multa, valor_total) VALUES (@id_ocorrencia, @id_multa, @valor_total)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@id_ocorrencia", o.Id);
                comand.Parameters.AddWithValue("@id_multa", m.Id);
                comand.Parameters.AddWithValue("@valor_total", m.Preco);
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
