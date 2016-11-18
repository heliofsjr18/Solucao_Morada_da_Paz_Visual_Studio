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
            throw new NotImplementedException();
        }

        public void editarAdvertencia(advertencia a)
        {
            throw new NotImplementedException();
        }

        public List<advertencia> listarAdvertencias()
        {
            throw new NotImplementedException();
        }

        public advertencia pesquisaAdvertencia(advertencia a)
        {
            throw new NotImplementedException();
        }

        //Service Especialização do Usuario
        public void inserirEspecializacao(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public void editarEspecializacao(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public List<especializacao_usuario> listarEspecializacao()
        {
            RNespecializacaoUsuario rneu = new RNespecializacaoUsuario();
            return rneu.chamarListar();
        }

        public especializacao_usuario pesquisaEspecializacao(especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        //Service Multa
        public void inserirMulta(multa m)
        {
            throw new NotImplementedException();
        }

        public void editarMulta(multa m)
        {
            throw new NotImplementedException();
        }

        public List<multa> listarMulta()
        {
            throw new NotImplementedException();
        }

        public multa pesquisaMulta(multa m)
        {
            throw new NotImplementedException();
        }

        //Service Ocorrencia
        public void inserirOcorrencia(ocorrencia o)
        {
            throw new NotImplementedException();
        }

        public void editarOcorrencia(ocorrencia o)
        {
            throw new NotImplementedException();
        }

        public List<ocorrencia> listarOcorrencias()
        {
            throw new NotImplementedException();
        }

        public ocorrencia pesquisaOcorrencia(ocorrencia o)
        {
            throw new NotImplementedException();
        }

    }
}
