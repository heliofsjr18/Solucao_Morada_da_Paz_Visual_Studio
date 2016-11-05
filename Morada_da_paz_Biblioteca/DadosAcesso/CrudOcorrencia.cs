﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.conexaodb;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public interface CrudOcorrencia
    {
        void inserir(ocorrencia o);

        void excluir(ocorrencia o);

        void alterar(ocorrencia o);

        ocorrencia pesquisar(ocorrencia o);

        List<ocorrencia> listar(); 
    }
}
