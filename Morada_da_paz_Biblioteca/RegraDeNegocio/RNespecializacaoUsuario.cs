using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNespecializacaoUsuario
    {
        private void verificaPreenchimento(especializacao_usuario eu) { 
            if(eu == null){
                throw new Exception("Objeto Vasio!");
            }

            if(eu.Descricao == null){
                throw new Exception("Descrição Vasia!");
            }
        }


        public void chamarInserir(especializacao_usuario eu)
        {
            
            CrudEspecializacaoUsuario ceu = new CrudEspecializacaoUsuarioImplements();
            this.verificaPreenchimento(eu);

            ceu.inserir(eu);
        }

        public void chamarAtualizar(especializacao_usuario eu)
        {
            CrudEspecializacaoUsuario ceu = new CrudEspecializacaoUsuarioImplements();
            this.verificaPreenchimento(eu);

            ceu.atualizar(eu);
        }
        public void chamarDeletar(especializacao_usuario eu)
        {
            CrudEspecializacaoUsuario ceu = new CrudEspecializacaoUsuarioImplements();
            this.verificaPreenchimento(eu);

            ceu.deletar(eu);
        }
        public especializacao_usuario chamarConsulta(especializacao_usuario eu)
        {
            CrudEspecializacaoUsuario ceu = new CrudEspecializacaoUsuarioImplements();
            this.verificaPreenchimento(eu);

            return ceu.consultar(eu);
        }
        public List<especializacao_usuario> chamarListar()
        {
            CrudEspecializacaoUsuario ceu = new CrudEspecializacaoUsuarioImplements();
            return ceu.listar();
        }
    }
}
