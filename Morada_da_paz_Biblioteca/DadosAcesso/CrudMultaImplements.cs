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
    class CrudMultaImplements : conexaoImplements, CrudMulta
    {
        public void inserir(multa m)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO multa (descricao, preco)";
                insertSql += " values ";
                insertSql += " (@descricao, @preco)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@descricao", m.Descricao);
                comand.Parameters.AddWithValue("@preco", m.Preco);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(multa m)
        {
            try
            {
                SqlConnection conexao = conectar();
                string updateSql = "UPDATE multa SET descricao = @descricao, preco = @preco WHERE id = @id)";

                SqlCommand comand = new SqlCommand(updateSql, conexao);
                comand.Parameters.AddWithValue("@id", m.Id);
                comand.Parameters.AddWithValue("@descricao", m.Descricao);
                comand.Parameters.AddWithValue("@preco", m.Preco);               
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public multa consultar(multa m)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, descricao, preco FROM multa WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@idpar", m.Id);
                multa multConsulta = new multa();

                SqlDataReader reader = comand.ExecuteReader();

                multConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                multConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                multConsulta.Preco = reader.GetDouble(reader.GetOrdinal("preco"));

                return multConsulta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void deletar(multa m)
        {
            try
            {
                SqlConnection conexao = conectar();
                string deleteSql = "DELETE FROM multa WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(deleteSql, conexao);
                comand.Parameters.AddWithValue("@idpar", m.Id);

                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<multa> listar()
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, descricao, preco FROM multa";

                SqlCommand comand = new SqlCommand(querySql, conexao);

                SqlDataReader reader = comand.ExecuteReader();

                List<multa> lista = new List<multa>();
                while (reader.NextResult())
                {
                    multa multConsulta = new multa();

                    multConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    multConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    multConsulta.Preco = reader.GetDouble(reader.GetOrdinal("preco"));

                    lista.Add(multConsulta);
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
