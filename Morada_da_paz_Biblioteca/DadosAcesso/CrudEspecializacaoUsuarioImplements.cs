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
    public class CrudEspecializacaoUsuarioImplements : conexaoImplements, CrudEspecializacaoUsuario
    {
        public void inserir(especializacao_usuario eu)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO especializacao_usuario (descricao)";
                insertSql += " values ";
                insertSql += " (@descricao)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@descricao", eu.Descricao);
                comand.ExecuteNonQuery();
                comand.Dispose();
                desconectar(conexao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(especializacao_usuario eu)
        {
            try
            {
                SqlConnection conexao = conectar();
                string updateSql = "UPDATE especializacao_usuario SET descricao = @descricao WHERE id = @id)";

                SqlCommand comand = new SqlCommand(updateSql, conexao);
                comand.Parameters.AddWithValue("@id", eu.Id);
                comand.Parameters.AddWithValue("@descricao", eu.Descricao);
                comand.ExecuteNonQuery();
                comand.Dispose();
                desconectar(conexao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public especializacao_usuario consultar(especializacao_usuario eu)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, descricao FROM especializacao_usuario WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@idpar", eu.Id);
                especializacao_usuario euConsulta = new especializacao_usuario();

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    euConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    euConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                }
                desconectar(conexao);
                return euConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void deletar(especializacao_usuario eu)
        {
            try
            {
                SqlConnection conexao = conectar();
                string deleteSql = "DELETE FROM especializacao_usuario WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(deleteSql, conexao);
                comand.Parameters.AddWithValue("@idpar", eu.Id);

                comand.ExecuteNonQuery();
                comand.Dispose();
                desconectar(conexao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<especializacao_usuario> listar()
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, descricao FROM especializacao_usuario";

                SqlCommand comand = new SqlCommand(querySql, conexao);

                SqlDataReader reader = comand.ExecuteReader();

                List<especializacao_usuario> lista = new List<especializacao_usuario>();
                while (reader.Read())
                {
                    especializacao_usuario euConsulta = new especializacao_usuario();

                    euConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    euConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));

                    lista.Add(euConsulta);
                }
                desconectar(conexao);
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
