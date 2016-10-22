using projeto_morada_da_paz.basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public interface CrudMulta
    {
        void inserir(multa m);
        void atualizar(multa m);
        void deletar(multa m);
        multa consultar(multa m);
        List<multa> listar();
    }
}
