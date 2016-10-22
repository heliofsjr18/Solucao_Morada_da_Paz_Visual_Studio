using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_morada_da_paz.conexaodb;
using projeto_morada_da_paz.basicas;

namespace projeto_morada_da_paz.DadosAcesso
{
    public interface CrudUsuario
    {
        void inserir(usuario u);
        void atualizar(usuario u);
        void deletar(usuario u);
        usuario consultar(usuario u);
        List<usuario> listar();
    }
}
