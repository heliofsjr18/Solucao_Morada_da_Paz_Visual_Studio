using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.conexaodb;
using Morada_da_paz_Biblioteca.basicas;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public class CrudUsuarioImplements : conexaoImplements, CrudUsuario
    {
        public void inserir(usuario u)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO usuario (nome_completo, email, login_, senha, id_unidade_residencial, id_especializacao)";
                insertSql += " values ";
                insertSql += " (@nome_completo, @email, @login, @senha, @id_unidade_residencial, @id_especializacao_usuario)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@nome_completo", u.Nome_completo);
                comand.Parameters.AddWithValue("@email", u.Email);
                comand.Parameters.AddWithValue("@login", u.Login);
                comand.Parameters.AddWithValue("@senha", u.Senha);
                comand.Parameters.AddWithValue("@id_unidade_residencial", u.Id_unidade_residencial.Id);
                comand.Parameters.AddWithValue("@id_especializacao_usuario", u.Id_especializacao_usuario.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void atualizar(usuario u)
        {
            try
            {
                SqlConnection conexao = conectar();
                string updateSql = "UPDATE usuario SET nome_completo = @nome_completo, email = @email,  id_unidade_residencial = @id_unidade_residencial, id_especializacao_usuario = @id_especializacao_usuario WHERE id = @id)";

                SqlCommand comand = new SqlCommand(updateSql, conexao);
                comand.Parameters.AddWithValue("@id", u.Id);
                comand.Parameters.AddWithValue("@nome_completo", u.Nome_completo);
                comand.Parameters.AddWithValue("@email", u.Email);
                comand.Parameters.AddWithValue("@id_unidade_residencial", u.Id_unidade_residencial.Id);
                comand.Parameters.AddWithValue("@id_especializacao_usuario", u.Id_especializacao_usuario.Id);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void deletar(usuario u)
        {
            try
            {
                SqlConnection conexao = conectar();
                string deleteSql = "DELETE FROM usuario WHERE id = @idpar";                

                SqlCommand comand = new SqlCommand(deleteSql, conexao);
                comand.Parameters.AddWithValue("@idpar", u.Id);

                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public usuario consultar(usuario u)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT nome_completo, email, login, senha, id_unidade_residencial, id_especializacao_usuario FROM usuario WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@idpar", u.Id);
                usuario usuConsulta = new usuario();

                SqlDataReader reader = comand.ExecuteReader();

                usuConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                usuConsulta.Nome_completo = reader.GetString(reader.GetOrdinal("nome_completo"));
                usuConsulta.Email = reader.GetString(reader.GetOrdinal("email"));
                usuConsulta.Login = reader.GetString(reader.GetOrdinal("login"));
                usuConsulta.Senha = reader.GetString(reader.GetOrdinal("senha"));
                usuConsulta.Id_unidade_residencial.Id = reader.GetInt32(reader.GetOrdinal("id_unidade_residencial"));
                usuConsulta.Id_especializacao_usuario.Id = reader.GetInt32(reader.GetOrdinal("id_especializacao_usuario"));

                return usuConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        public List<usuario> listar()
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, nome_completo, email, login, senha, id_unidade_residencial, id_especializacao_usuario FROM usuario";

                SqlCommand comand = new SqlCommand(querySql, conexao);

                SqlDataReader reader = comand.ExecuteReader();

                List<usuario> lista = new List<usuario>();
                while (reader.NextResult())
                {
                    usuario usuConsulta = new usuario();

                    usuConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    usuConsulta.Nome_completo = reader.GetString(reader.GetOrdinal("nome_completo"));
                    usuConsulta.Email = reader.GetString(reader.GetOrdinal("email"));
                    usuConsulta.Login = reader.GetString(reader.GetOrdinal("login"));
                    usuConsulta.Senha = reader.GetString(reader.GetOrdinal("senha"));
                    usuConsulta.Id_unidade_residencial.Id = reader.GetInt32(reader.GetOrdinal("id_unidade_residencial"));
                    usuConsulta.Id_especializacao_usuario.Id = reader.GetInt32(reader.GetOrdinal("id_especializacao_usuario"));

                    lista.Add(usuConsulta);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public usuario consultarLogin(usuario u)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, login, senha, id_especializacao_usuario FROM usuario WHERE login = @login";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@login", u.Login);
                usuario usuConsulta = new usuario();

                SqlDataReader reader = comand.ExecuteReader();

                usuConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                usuConsulta.Login = reader.GetString(reader.GetOrdinal("login"));
                usuConsulta.Senha = reader.GetString(reader.GetOrdinal("senha"));
                usuConsulta.Id_especializacao_usuario.Id = reader.GetInt32(reader.GetOrdinal("id_especializacao_usuario"));

                return usuConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
