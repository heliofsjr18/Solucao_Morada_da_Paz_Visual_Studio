using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.conexaodb;
using System.Data.SqlClient;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public class CrudOcorrenciaImplements : conexaoImplements, CrudOcorrencia
    {
        public void alterar(ocorrencia o)
        {

            try
            {
                SqlConnection c = conectar();
                string query = "UPDATE ocorrencia set descricao = @descricao, id_usuario = @id_usuario, id_unidade_residencial = @id_unidade_residencial";
                query += "WHERE id = @id";
                SqlCommand comand = new SqlCommand(query,c);
                comand.Parameters.AddWithValue("@descricao", o.Descricao);
                comand.Parameters.AddWithValue("@id_usuario", o.Id_usuario);
                comand.Parameters.AddWithValue("@id_unidade_residencial", o.Id_unidade_residencial);
                comand.Parameters.AddWithValue("@id", o.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void excluir(ocorrencia o)
        {
            try
            {
                SqlConnection c = conectar();
                string query = "DELETE FROM ocorrencia WHERE id = @id";
                SqlCommand comand = new SqlCommand(query, c);
                comand.Parameters.AddWithValue("@id", o.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void inserir(ocorrencia o)
        {
            try
            {
                SqlConnection c = conectar();
                string query = "INSERT INTO ocorrencia (situacao,numero_ocorrencia ,descricao, id_usuario, id_unidade_residencial) ";
                query += "values";
                query += "(@situacao,@numero_ocorrencia ,@descricao, @id_usuario, @id_unidade_residencial)";

                SqlCommand comand = new SqlCommand(query, c);
                comand.Parameters.AddWithValue("@situacao", o.Situacao);
                comand.Parameters.AddWithValue("@descricao",o.Descricao);
                comand.Parameters.AddWithValue("@numero_ocorrencia", o.Numero_ocorrencia);
                comand.Parameters.AddWithValue("@id_usuario", o.Id_usuario.Id);
                comand.Parameters.AddWithValue("@id_unidade_residencial", o.Id_unidade_residencial.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ocorrencia> listar()
        {
            try
            {
                SqlConnection c = conectar();
                /*string query = "SELECT o.situacao, o.numero_ocorrencia, o.descricao, u.nome_completo, ur.numero_unidade";
                query += "FROM ocorrencia as o inner join usuario as u on u.id = o.id_usuario";
                query += "inner join unidade_residencial as ur on ur.id = o.id_unidade_residencial";*/
                string query = "SELECT id, situacao, numero_ocorrencia, descricao, id_usuario, id_unidade_residencial";
                query += "FROM ocorrencia";

                SqlCommand comand = new SqlCommand(query, c);
                SqlDataReader reader = comand.ExecuteReader();

                List<ocorrencia> oc = new List<ocorrencia>();

                while (reader.NextResult())
                {
                    ocorrencia oco = new ocorrencia();

                    oco.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    oco.Situacao = reader.GetString(reader.GetOrdinal("situacao"));
                    oco.Numero_ocorrencia = reader.GetString(reader.GetOrdinal("numero_ocorrencia"));
                    oco.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    oco.Id_usuario.Id = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                    oco.Id_unidade_residencial.Id = reader.GetInt32(reader.GetOrdinal("id_unidade_residencial"));

                    oc.Add(oco);

                }
                return oc;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ocorrencia pesquisar(ocorrencia o)
        {
            try
            {
                SqlConnection c = conectar();
                string query = "SELECT id, situacao, numero_ocorrencia, descricao, id_usuario, id_unidade_residencial";
                query += "FROM ocorrencia WHERE id = @id";

                SqlCommand comand = new SqlCommand(query, c);
                SqlDataReader reader = comand.ExecuteReader();

                ocorrencia oco = new ocorrencia();
                oco.Id = reader.GetInt32(reader.GetOrdinal("id"));


                return oco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }
    }
}
