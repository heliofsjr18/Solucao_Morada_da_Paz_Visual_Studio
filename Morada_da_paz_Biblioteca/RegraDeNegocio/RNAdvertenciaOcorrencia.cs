using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNAdvertenciaOcorrencia
    {

        private void verificaPreenchimentoAdvertencia(advertencia a)
        {
            if (a == null)
            {
                throw new Exception("Objeto Vazio!");
            }
            if (a.Descricao.Equals(""))
            {
                throw new Exception("Descrição Vazia!");
            }
        }

        private void verificaPreenchimentoOcorrencia(ocorrencia o)
        {
            if (o == null)
            {
                throw new Exception("Objeto vazio!");
            }
            if (o.Descricao == null)
            {
                throw new Exception("Descrição Vazia!");
            }
            if (o.Id_usuario == null)
            {
                throw new Exception("Sem Usuário!");
            }

        }

        public void chamarInserir(advertencia a, ocorrencia o)
        {
            CrudAdvertencia_Ocorrencia cao = new CrudAdvertencia_OcorrenciaImplements();
            this.verificaPreenchimentoAdvertencia(a);
            this.verificaPreenchimentoOcorrencia(o);
            cao.inserir(a, o);
        }

        public List<advertencia> chamaLista(ocorrencia o)
        {
            CrudAdvertencia_Ocorrencia cao = new CrudAdvertencia_OcorrenciaImplements();
            this.verificaPreenchimentoOcorrencia(o);
            return cao.lista(o);
        }
    }
}
