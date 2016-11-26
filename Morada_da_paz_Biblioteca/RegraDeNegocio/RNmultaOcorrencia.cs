using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNmultaOcorrencia
    {
        private void verificaPreenchimentoMulta(multa m)
        {
            if (m == null)
            {
                throw new Exception("Objeto Vasio!");
            }

            if (m.Descricao == null)
            {
                throw new Exception("Descrição Vasia");
            }

        }

        private void verificaPreenchimentoOcorrencia(ocorrencia o)
        {
            if (o == null)
            {
                throw new Exception("Objeto vasio!");
            }
            if (o.Descricao == null)
            {
                throw new Exception("Descrição Vasia!");
            }
            if (o.Id_usuario == null)
            {
                throw new Exception("Sem Usuário!");
            }

        }

        public void chamarInserir(multa m, ocorrencia o)
        {
            CrudMulta_Ocorrencia cmo = new CrudMulta_OcorrenciaImplements();
            this.verificaPreenchimentoMulta(m);
            this.verificaPreenchimentoOcorrencia(o);
            cmo.inserir(m, o);
        }
    }
}
