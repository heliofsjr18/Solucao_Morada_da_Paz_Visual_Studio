using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_morada_da_paz.basicas;
using projeto_morada_da_paz.conexaodb;
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
                string query = "INSERT INTO ocorrencia (descricao, id_usuario, id_unidade_residencial) ";
                query += "values";
                query += "(@descricao, @id_usuario, @id_unidade_residencial)";

                SqlCommand comand = new SqlCommand(query, c);
                comand.Parameters.AddWithValue("@descricao",o.Descricao);
                comand.Parameters.AddWithValue("@id_usuario", o.Id_usuario);
                comand.Parameters.AddWithValue("@id_unidade_residencial", o.Id_unidade_residencial);
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
                string query = "SELECT o.situacao, o.numero_ocorrencia, o.descricao, u.nome_completo, ur.numero_unidade";
                query += "FROM ocorrencia as o inner join usuario as u on u.id = o.id_usuario";
                query += "inner join unidade_residencial as ur on ur.id = o.id_unidade_residencial";

                SqlCommand comand = new SqlCommand(query, c);
                SqlDataReader reader = comand.ExecuteReader();

                List<ocorrencia> oc = new List<ocorrencia>();

                while (reader.NextResult())
                {
                    ocorrencia oco = new ocorrencia();
                    usuario usu = new usuario();
                    unidade_residencial ur = new unidade_residencial();
                    oco.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    oco.Situacao = reader.GetString(reader.GetOrdinal("situacao"));
                    oco.Numero_ocorrencia = reader.GetString(reader.GetOrdinal("numero_ocorrencia"));
                    oco.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                   // oco.Id_usuario = reader.GetInt32(reader.GetOrdinal(""));
                }
                return null;
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
                //string query = "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
    }
}
