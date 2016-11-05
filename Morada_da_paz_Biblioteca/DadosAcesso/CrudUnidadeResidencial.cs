using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.basicas;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    interface CrudUnidadeResidencial
    {
        void inserir(unidade_residencial ur);
        void atualizar(unidade_residencial ur);
        void deletar(unidade_residencial ur);
        unidade_residencial consultar(unidade_residencial ur);
        List<unidade_residencial> listar();
    }
}
