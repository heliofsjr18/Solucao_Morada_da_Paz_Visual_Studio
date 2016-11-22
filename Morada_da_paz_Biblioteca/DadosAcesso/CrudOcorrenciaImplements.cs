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
                string query = "UPDATE ocorrencia set descricao = @descricao, id_usuario = @id_usuario, id_unidade_residencial = @id_unidade_residencial , tipoPublico = @tipoPublico WHERE id = @id";
                SqlCommand comand = new SqlCommand(query,c);
                comand.Parameters.AddWithValue("@descricao", o.Descricao);
                comand.Parameters.AddWithValue("@id_usuario", o.Id_usuario);
                comand.Parameters.AddWithValue("@id_unidade_residencial", o.Id_unidade_residencial);
                comand.Parameters.AddWithValue("@id", o.Id);
                comand.Parameters.AddWithValue("@tipoPublico", o.TipoPublico);
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
                string query = "INSERT INTO ocorrencia (situacao,numero_ocorrencia ,descricao, id_usuario, tipoPublico)  values (@situacao,@numero_ocorrencia ,@descricao, @id_usuario, @tipoPublico)";

                SqlCommand comand = new SqlCommand(query, c);
                comand.Parameters.AddWithValue("@situacao", o.Situacao);
                comand.Parameters.AddWithValue("@descricao",o.Descricao);
                comand.Parameters.AddWithValue("@numero_ocorrencia", o.Numero_ocorrencia);
                comand.Parameters.AddWithValue("@id_usuario", o.Id_usuario.Id);
                //comand.Parameters.AddWithValue("@id_unidade_residencial", o.Id_unidade_residencial.Id);
                comand.Parameters.AddWithValue("@tipoPublico", o.TipoPublico);
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
                string query = "SELECT id, situacao, numero_ocorrencia, descricao, id_usuario, id_unidade_residencial FROM ocorrencia";                

                SqlCommand comand = new SqlCommand(query, c);
                SqlDataReader reader = comand.ExecuteReader();

                List<ocorrencia> oc = new List<ocorrencia>();

                while (reader.Read())
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
                string query = "SELECT id, situacao, numero_ocorrencia, tipoPublico ,descricao, id_usuario, id_unidade_residencial";
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

        public List<ocorrencia> ListarPorUsuario(usuario u)
        {
            try
            {
                SqlConnection c = conectar();
                string query = "SELECT id, situacao, numero_ocorrencia, descricao, id_usuario, tipoPublico FROM ocorrencia WHERE id_usuario = @id_usuario";

                SqlCommand comand = new SqlCommand(query, c);
                comand.Parameters.AddWithValue("@id_usuario", u.Id);

                SqlDataReader reader = comand.ExecuteReader();


                List<ocorrencia> oc = new List<ocorrencia>();

                while (reader.Read())
                {
                    ocorrencia oco = new ocorrencia();

                    oco.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    oco.Situacao = reader.GetString(reader.GetOrdinal("situacao"));
                    oco.Numero_ocorrencia = reader.GetString(reader.GetOrdinal("numero_ocorrencia"));
                    oco.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    oco.Id_usuario.Id = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                    oco.TipoPublico = reader.GetInt32(reader.GetOrdinal("tipoPublico"));

                    oc.Add(oco);

                }
                return oc;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
