using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNmulta
    {
        private void verificaPreenchimento(multa m){
            if (m == null) {
                throw new Exception("Objeto Vasio!");
            }

            if(m.Descricao == null ){
                throw new Exception("Descrição Vasia");
            }

            if(m.Preco == null){
                throw new Exception("Preço vasio!");
            }
        }

        public void chamarInserir(multa m)
        {
            CrudMulta cm = new CrudMultaImplements();
            this.verificaPreenchimento(m);

            cm.inserir(m);
        }

        public void chamarAtualizar(multa m)
        {
            CrudMulta cm = new CrudMultaImplements();
            this.verificaPreenchimento(m);

            cm.atualizar(m);
        }
        public void chamarDeletar(multa m)
        {
            CrudMulta cm = new CrudMultaImplements();
            this.verificaPreenchimento(m);

            cm.deletar(m);
        }
        public multa chamarConsulta(multa m)
        {
            CrudMulta cm = new CrudMultaImplements();
            this.verificaPreenchimento(m);

            return cm.consultar(m);
        }
        public List<multa> chamarListar(multa m)
        {
            CrudMulta cm = new CrudMultaImplements();
            return cm.listar();
        }
    }
}
