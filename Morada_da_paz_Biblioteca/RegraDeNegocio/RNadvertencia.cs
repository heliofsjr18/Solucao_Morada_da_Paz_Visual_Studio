using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNadvertencia
    {

        private void verificaPreenchimento(advertencia a) {
            if (a == null)
            {
                throw new Exception("Objeto Vasio!");
            }
            if (a.Id == null)
            {
                throw new Exception("Id Vasio!");
            }
            if (a.Descricao == null) 
            {
                throw new Exception("Descrição Vasia!");
            }
        }

        public void chamarInserir(advertencia a)
        {
            CrudAdvertencia ca = new CrudAdvertenciaImplements();
            this.verificaPreenchimento(a);
            
            ca.inserir(a);
        }

        public void chamarAtualizar(advertencia a)
        {
            CrudAdvertencia ca = new CrudAdvertenciaImplements();
            this.verificaPreenchimento(a);
            
            ca.atualizar(a);
        }
        public void chamarDeletar(advertencia a)
        {
            CrudAdvertencia ca = new CrudAdvertenciaImplements();
            this.verificaPreenchimento(a);
            
            ca.deletar(a);
        }
        public advertencia chamarConsulta(advertencia a)
        {
            CrudAdvertencia ca = new CrudAdvertenciaImplements();
            this.verificaPreenchimento(a);
            
            return ca.consultar(a);
        }
        public List<advertencia> chamarListar(advertencia a)
        {
            CrudAdvertencia ca = new CrudAdvertenciaImplements();
            return ca.listar();
        }
    }
}
