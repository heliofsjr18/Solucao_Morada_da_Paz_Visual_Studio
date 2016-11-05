using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morada_da_paz_Biblioteca.basicas
{
    public class unidade_residencial
    {
        private int id;
        private String numero_residencia;
        private String descricao;
        private ocorrencia id_ocorrencia;

        public unidade_residencial()
        {
           // this.id_ocorrencia = new ocorrencia();
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

        public string Numero_residencia
        {
            get
            {
                return numero_residencia;
            }

            set
            {
                numero_residencia = value;
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

        internal ocorrencia Id_ocorrencia
        {
            get
            {
                return id_ocorrencia;
            }

            set
            {
                id_ocorrencia = value;
            }
        }
    }
}
