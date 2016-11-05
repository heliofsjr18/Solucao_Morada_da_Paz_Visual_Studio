using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.conexaodb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public class CrudAdvertencia_OcorrenciaImplements : conexaoImplements, CrudAdvertencia_Ocorrencia
    {
        public void inserir(advertencia a, ocorrencia o)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO ocorrencia_advertencia (id_ocorrencia, id_advertencia)";
                insertSql += " values ";
                insertSql += " (@id_ocorrencia, @id_advertencia)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@id_ocorrencia", o.Id);
                comand.Parameters.AddWithValue("@id_advertencia", a.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public advertencia consultar(advertencia a, ocorrencia o)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id_ocorrencia, id_advertencia FROM advertencia" + 
                       "WHERE id_ocorrencia = @id_ocorrencia AND id_advertencia = @id_advertencia";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@id_advertencia", a.Id);
                comand.Parameters.AddWithValue("@id_ocorrencia", o.Id);
                advertencia advertConsulta = new advertencia();

                SqlDataReader reader = comand.ExecuteReader();

                advertConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                advertConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));

                return advertConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/

        /*public List<object> listar()
        {
            throw new NotImplementedException();
        }*/
    }
}
