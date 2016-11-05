using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_morada_da_paz.basicas
{
    public class usuario
    {
        private int id;
        private String email;
        private String login;
        private String senha;
        private String nome_completo;
        private unidade_residencial id_unidade_residencial;
        private especializacao_usuario id_especializacao_usuario;

        public usuario()
        {
            this.id_unidade_residencial = new unidade_residencial();
            this.id_especializacao_usuario = new especializacao_usuario();
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Nome_completo
        {
            get
            {
                return nome_completo;
            }

            set
            {
                nome_completo = value;
            }
        }

        internal unidade_residencial Id_unidade_residencial
        {
            get
            {
                return id_unidade_residencial;
            }

            set
            {
                id_unidade_residencial = value;
            }
        }

        internal especializacao_usuario Id_especializacao_usuario
        {
            get
            {
                return id_especializacao_usuario;
            }

            set
            {
                id_especializacao_usuario = value;
            }
        }
    }
}
