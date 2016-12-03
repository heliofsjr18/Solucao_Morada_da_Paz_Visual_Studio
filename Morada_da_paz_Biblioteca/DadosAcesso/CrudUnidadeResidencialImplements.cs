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
    public class CrudUnidadeResidencialImplements : conexaoImplements, CrudUnidadeResidencial
    {
        public void inserir(unidade_residencial ur)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO unidade_residencial (numero_unidade, descricao)";
                insertSql += " values ";
                insertSql += " (@numero_unidade, @descricao)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@numero_unidade", ur.Numero_residencia);
                comand.Parameters.AddWithValue("@descricao", ur.Descricao);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(unidade_residencial ur)
        {
            try
            {
                SqlConnection conexao = conectar();
                string updateSql = "UPDATE unidade_residencial SET numero_unidade = @numero_unidade, descricao = @descricao WHERE id = @id)";

                SqlCommand comand = new SqlCommand(updateSql, conexao);
                comand.Parameters.AddWithValue("@id", ur.Id);
                comand.Parameters.AddWithValue("@numero_unidade", ur.Numero_residencia);
                comand.Parameters.AddWithValue("@descricao", ur.Descricao);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public unidade_residencial consultar(unidade_residencial ur)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, numero_unidade, descricao FROM unidade_residencial WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@idpar", ur.Id);
                unidade_residencial urConsulta = new unidade_residencial();

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    urConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    urConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    urConsulta.Numero_residencia = reader.GetString(reader.GetOrdinal("numero_unidade"));
                }

                return urConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void deletar(unidade_residencial ur)
        {
            try
            {
                SqlConnection conexao = conectar();
                string deleteSql = "DELETE FROM unidade_residencial WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(deleteSql, conexao);
                comand.Parameters.AddWithValue("@idpar", ur.Id);

                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<unidade_residencial> listar()
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, numero_unidade, descricao FROM unidade_residencial";

                SqlCommand comand = new SqlCommand(querySql, conexao);

                SqlDataReader reader = comand.ExecuteReader();

                List<unidade_residencial> lista = new List<unidade_residencial>();
                while (reader.Read())
                {
                    unidade_residencial urConsulta = new unidade_residencial();

                    urConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    urConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    urConsulta.Numero_residencia = reader.GetString(reader.GetOrdinal("numero_unidade"));

                    lista.Add(urConsulta);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
