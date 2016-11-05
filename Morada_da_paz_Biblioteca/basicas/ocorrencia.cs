using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_morada_da_paz.basicas
{
    public class ocorrencia
    {
        private int id;
        private String situacao;
        private String numero_ocorrencia;
        private String descricao;
        private usuario id_usuario;
        private bool tipoPublico;
        private unidade_residencial id_unidade_residencial;
        private List<advertencia> lista_id_advertencia;
        private List<multa> lista_id_multa;

        public ocorrencia()
        {
            this.id_usuario = new usuario();
            this.Id_unidade_residencial = new unidade_residencial();
            this.lista_id_advertencia = new List<advertencia>();
            this.lista_id_multa = new List<multa>();
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

        public string Situacao
        {
            get
            {
                return situacao;
            }

            set
            {
                situacao = value;
            }
        }

        public string Numero_ocorrencia
        {
            get
            {
                return numero_ocorrencia;
            }

            set
            {
                numero_ocorrencia = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        internal usuario Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
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

        internal List<multa> Lista_id_multa
        {
            get
            {
                return lista_id_multa;
            }

            set
            {
                lista_id_multa = value;
            }
        }

        internal List<advertencia> Lista_id_advertencia
        {
            get
            {
                return lista_id_advertencia;
            }

            set
            {
                lista_id_advertencia = value;
            }
        }
    }
}
