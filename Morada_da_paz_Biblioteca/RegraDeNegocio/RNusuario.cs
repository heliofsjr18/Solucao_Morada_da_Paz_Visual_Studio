using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;

namespace Morada_da_paz_Biblioteca.RegraDeNegocio
{
    public class RNusuario
    {
        private void verificaPreenchimento(usuario u)
        {
            if (u == null)
            {
                throw new Exception("Objeto não inicializado, Imporrível executar a ação");
            }
            if (u.Nome_completo == null)
            {
                throw new Exception("O campo Nome Completo precisa ser preenchido");
            }
            if (u.Id_especializacao_usuario == null)
            {
                throw new Exception("É necessário uma especialização para o cadastro");
            }
            if (u.Id_unidade_residencial ==  null)
            {
                throw new Exception("O cadastro precisa estar vinculado a um cadastro de unidade residencial válido");
            }
            if (u.Login == null)
            {
                throw new Exception("O campo login precisa ser prenchido");
            }
            if (u.Senha == null)
            {
                throw new Exception("O campo senha precisa ser preenchido");
            }            
        }

        private void validaPrenchimento(usuario u)
        {
            if (u.Login.Length < 5)
            {
                throw new Exception("O login precisa ter mais do que 5 caracteres");
            }

            if (u.Senha.Length < 5)
            {
                throw new Exception("A senha precisa ter mais do que 5 caracteres");
            }

            if (u.Nome_completo.Length < 5)
            {
                throw new Exception("Nome Invalido");
            }
        }

        //Chamando as funcionalidades do sistemas
        public void chamarInserir(usuario u)
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            this.verificaPreenchimento(u);
            this.verificaPreenchimento(u);
            cU.inserir(u);
        }

        public void chamarAtualizar(usuario u)
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            this.verificaPreenchimento(u);
            this.verificaPreenchimento(u);
            cU.atualizar(u);
        }
        public void chamarDeletar(usuario u)
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            this.verificaPreenchimento(u);
            this.verificaPreenchimento(u);
            cU.deletar(u);
        }
        public usuario chamarConsulta(usuario u)
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            this.verificaPreenchimento(u);
            this.verificaPreenchimento(u);
            return cU.consultar(u);
        }
        public usuario chamarConsultaLogin(usuario u)
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            this.verificaPreenchimento(u);
            this.verificaPreenchimento(u);
            return cU.consultarLogin(u);
        }        

                
        /*public List<usuario> chamarListar(usuario u)
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            return cU.listar();
        }*/

        public List<usuario> chamarListar()
        {
            CrudUsuario cU = new CrudUsuarioImplements();
            return cU.listar();
        }
    }
}
