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
    class CrudAdvertenciaImplements : conexaoImplements, CrudAdvertencia
    {
        public void inserir(advertencia a)
        {
            try
            {
                SqlConnection conexao = conectar();
                string insertSql = "INSERT INTO advertencia (descricao)";
                insertSql += " values ";
                insertSql += " (@descricao)";

                SqlCommand comand = new SqlCommand(insertSql, conexao);
                comand.Parameters.AddWithValue("@descricao", a.Descricao);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(advertencia a)
        {
            try
            {
                SqlConnection conexao = conectar();
                string updateSql = "UPDATE advertencia SET descricao = @descricao WHERE id = @id)";

                SqlCommand comand = new SqlCommand(updateSql, conexao);
                comand.Parameters.AddWithValue("@id", a.Id);
                comand.Parameters.AddWithValue("@descricao", a.Descricao);
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public advertencia consultar(advertencia a)
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, descricao FROM advertencia WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(querySql, conexao);
                comand.Parameters.AddWithValue("@idpar", a.Id);
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
        }

        public void deletar(advertencia a)
        {
            try
            {
                SqlConnection conexao = conectar();
                string deleteSql = "DELETE FROM advertencia WHERE id = @idpar";

                SqlCommand comand = new SqlCommand(deleteSql, conexao);
                comand.Parameters.AddWithValue("@idpar", a.Id);

                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<advertencia> listar()
        {
            try
            {
                SqlConnection conexao = conectar();
                string querySql = "SELECT id, descricao FROM advertencia";

                SqlCommand comand = new SqlCommand(querySql, conexao);

                SqlDataReader reader = comand.ExecuteReader();

                List<advertencia> lista = new List<advertencia>();
                while (reader.NextResult())
                {
                    advertencia advertConsulta = new advertencia();

                    advertConsulta.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    advertConsulta.Descricao = reader.GetString(reader.GetOrdinal("descricao"));

                    lista.Add(advertConsulta);
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
