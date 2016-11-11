using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNunidadeResidencial
    {
        public void verificaPreenchimento(unidade_residencial ur) { 
            if(ur == null){
                throw new Exception("Objeto Vasio!");
            }

            if(ur.Descricao == null){
                throw new Exception("Descrição Vasia!");
            }

            if(ur.Numero_residencia == null){
                throw new Exception("Nu´mero Residencial Vasio!");
            }
        }

        public void chamarInserir(unidade_residencial ur)
        {
            CrudUnidadeResidencial cur = new CrudUnidadeResidencialImplements();
            this.verificaPreenchimento(ur);

            cur.inserir(ur);
        }

        public void chamarAtualizar(unidade_residencial ur)
        {
            CrudUnidadeResidencial cur = new CrudUnidadeResidencialImplements();
            this.verificaPreenchimento(ur);

            cur.atualizar(ur);
        }
        public void chamarDeletar(unidade_residencial ur)
        {
            CrudUnidadeResidencial cur = new CrudUnidadeResidencialImplements();
            this.verificaPreenchimento(ur);

            cur.deletar(ur);
        }
        public unidade_residencial chamarConsulta(unidade_residencial ur)
        {
            CrudUnidadeResidencial cur = new CrudUnidadeResidencialImplements();
            this.verificaPreenchimento(ur);

            return cur.consultar(ur);
        }
        public List<unidade_residencial> chamarListar(unidade_residencial ur)
        {
            CrudUnidadeResidencial cur = new CrudUnidadeResidencialImplements();
            return cur.listar();
        }
    }
}
