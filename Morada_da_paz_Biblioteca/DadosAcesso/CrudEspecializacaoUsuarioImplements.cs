using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_morada_da_paz.basicas;
using projeto_morada_da_paz.conexaodb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    class CrudEspecializacaoUsuarioImplements : conexaoImplements, CrudEspecializacaoUsuario
    {
        public void inserir(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public void atualizar(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public especializacao_usuario consultar(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public void deletar(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }


        public List<especializacao_usuario> listar()
        {
            throw new NotImplementedException();
        }
    }
}
