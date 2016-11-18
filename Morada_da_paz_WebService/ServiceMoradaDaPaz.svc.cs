using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Morada_da_paz_Biblioteca.basicas;
using Morada_da_paz_Biblioteca.DadosAcesso;
using Morada_da_paz_Biblioteca.RegraDeNegocio;

namespace Morada_da_paz_WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceMoradaDaPaz" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceMoradaDaPaz.svc or ServiceMoradaDaPaz.svc.cs at the Solution Explorer and start debugging.
    public class ServiceMoradaDaPaz : IServiceMoradaDaPaz
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        // Service Usuario
        public void inseirUsuario(usuario u)
        {
            RNusuario rnu = new RNusuario();
            rnu.chamarInserir(u);
        }

        public void editarUsuario(usuario u)
        {
            RNusuario rnu = new RNusuario();
            rnu.chamarAtualizar(u);
        }

        public List<usuario> listarUsuarios()
        {
            RNusuario rnu = new RNusuario();
            return rnu.chamarListar();
        }

        public usuario pesquisaUsuario(usuario u)
        {
            RNusuario rnu = new RNusuario();
            return rnu.chamarConsulta(u);
        }
        public usuario pesquisaUsuarioLogin(usuario u)
        {
            RNusuario rnu = new RNusuario();
            return rnu.chamarConsultaLogin(u);
        }

        //Service Unidade Residencial
        public void inseirUnidadeResidencial(unidade_residencial ur)
        {

            RNunidadeResidencial rnund = new RNunidadeResidencial();
            rnund.chamarInserir(ur);

        }

        public void editaUnidadeResisencial(unidade_residencial ur)
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            rnund.chamarAtualizar(ur);
        }

        public List<unidade_residencial> listarUnidades()
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            return rnund.chamarListar();
        }

        public unidade_residencial pesquisaUnidade(unidade_residencial ur)
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            return rnund.chamarConsulta(ur);
        }

        //Service Advertencia
        public void inserirAdvertencia(advertencia a)
        {
            RNadvertencia rna = new RNadvertencia();
            rna.chamarInserir(a);
        }

        public void editarAdvertencia(advertencia a)
        {
            RNadvertencia rna = new RNadvertencia();
            rna.chamarAtualizar(a);
        }

        public List<advertencia> listarAdvertencias()
        {
            RNadvertencia rna = new RNadvertencia();
            return rna.chamarListar();
        }

        public advertencia pesquisaAdvertencia(advertencia a)
        {
            RNadvertencia rna = new RNadvertencia();
            return rna.chamarConsulta(a);
        }

        //Service Especialização do Usuario
        public void inserirEspecializacao(especializacao_usuario eu)
        {
            RNespecializacaoUsuario rneu = new RNespecializacaoUsuario();
            rneu.chamarInserir(eu);
        }

        public void editarEspecializacao(especializacao_usuario eu)
        {
            RNespecializacaoUsuario rneu = new RNespecializacaoUsuario();
            rneu.chamarAtualizar(eu);
        }

        public List<especializacao_usuario> listarEspecializacao()
        {
            RNespecializacaoUsuario rneu = new RNespecializacaoUsuario();
            return rneu.chamarListar();
        }

        public especializacao_usuario pesquisaEspecializacao(especializacao_usuario eu)
        {
            RNespecializacaoUsuario rneu = new RNespecializacaoUsuario();
            return rneu.chamarConsulta(eu);
        }

        //Service Multa
        public void inserirMulta(multa m)
        {
            RNmulta rnm = new RNmulta();
            rnm.chamarInserir(m);
        }

        public void editarMulta(multa m)
        {
            RNmulta rnm = new RNmulta();
            rnm.chamarAtualizar(m);
        }

        public List<multa> listarMulta()
        {
            RNmulta rnm = new RNmulta();
            return rnm.chamarListar();
        }

        public multa pesquisaMulta(multa m)
        {
            RNmulta rnm = new RNmulta();
            return rnm.chamarConsulta(m);
        }

        //Service Ocorrencia
        public void inserirOcorrencia(ocorrencia o)
        {
            RNocorrencia rno = new RNocorrencia();
            rno.chamarInseriro(o);
        }

        public void editarOcorrencia(ocorrencia o)
        {
            RNocorrencia rno = new RNocorrencia();
            rno.chamarAtualizar(o);
        }

        public List<ocorrencia> listarOcorrencias()
        {
            RNocorrencia rno = new RNocorrencia();
            return rno.chamarListar();
        }

        public ocorrencia pesquisaOcorrencia(ocorrencia o)
        {
            RNocorrencia rno = new RNocorrencia();
            return rno.chamarConsulta(o);
        }

    }
}
