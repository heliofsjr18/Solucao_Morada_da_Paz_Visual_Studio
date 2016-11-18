using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNocorrencia
    {
        private void verificaPreenchimento(ocorrencia o) {
            if (o == null) {
                throw new Exception("Objeto vasio!");
            }
            if (o.Descricao == null) {
                throw new Exception("Descrição Vasia!");
            }
            if(o.Id_usuario == null){
                throw new Exception("Sem Usuário!");
            }
            
        }

        public void chamarInseriro(ocorrencia o)
        {
            CrudOcorrencia co = new CrudOcorrenciaImplements();
            this.verificaPreenchimento(o);

            co.inserir(o);
        }

        public void chamarAtualizar(ocorrencia o)
        {
            CrudOcorrencia co = new CrudOcorrenciaImplements();
            this.verificaPreenchimento(o);

            co.alterar(o);
        }
        public void chamarDeletar(ocorrencia o)
        {
            CrudOcorrencia co = new CrudOcorrenciaImplements();
            this.verificaPreenchimento(o);

            co.excluir(o);
        }
        public ocorrencia chamarConsulta(ocorrencia o)
        {
            CrudOcorrencia co = new CrudOcorrenciaImplements();
            this.verificaPreenchimento(o);

            return co.pesquisar(o);
        }
       

        public List<ocorrencia> chamarListar()
        {
            CrudOcorrencia co = new CrudOcorrenciaImplements();
            return co.listar();
        }
    }
}
