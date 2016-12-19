using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.conexaodb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System;
using System.Collections.Generic;

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
                desconectar(conexao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<multa> lista(ocorrencia o)
        {
            try
            {
                SqlConnection c = conectar();
                string query = "select m.id, m.descricao, m.preco from multa as m inner join ocorrencia_multa as om on m.id = om.id_multa inner join ocorrencia as o on o.id = om.id_ocorrencia where o.id = @id;";

                SqlCommand comand = new SqlCommand(query, c);
                comand.Parameters.AddWithValue("@id", o.Id);

                SqlDataReader reader = comand.ExecuteReader();

                List<multa> m = new List<multa>();

                while (reader.Read())
                {
                    multa mu = new multa();

                    mu.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    mu.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    mu.Preco = reader.GetDouble(reader.GetOrdinal("preco"));


                    m.Add(mu);

                }
                desconectar(c);
                return m;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
