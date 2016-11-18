using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morada_da_paz_Biblioteca.conexaodb;
using Morada_da_paz_Biblioteca.basicas;

namespace Morada_da_paz_Biblioteca.DadosAcesso
{
    public interface CrudUsuario
    {
        void inserir(usuario u);
        void atualizar(usuario u);
        void deletar(usuario u);
        usuario consultar(usuario u);
        usuario consultarLogin(usuario u);
        List<usuario> listar();
    }
}
