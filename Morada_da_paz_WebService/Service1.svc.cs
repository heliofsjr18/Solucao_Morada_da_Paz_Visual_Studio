using Morada_da_paz_Biblioteca.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Morada_da_paz_WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
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
        public void inseirUsuario(Morada_da_paz_Biblioteca.basicas.usuario u)
        {
            RNusuario rnu = new RNusuario();
            rnu.chamarInserir(u);
        }

        public void editarUsuario(Morada_da_paz_Biblioteca.basicas.usuario u)
        {
            RNusuario rnu = new RNusuario();
            rnu.chamarAtualizar(u);
        }

        public List<Morada_da_paz_Biblioteca.basicas.usuario> listarUsuarios()
        {
            RNusuario rnu = new RNusuario();
            return rnu.chamarListar();
        }

        public Morada_da_paz_Biblioteca.basicas.usuario pesquisaUsuario(Morada_da_paz_Biblioteca.basicas.usuario u)
        {
            RNusuario rnu = new RNusuario();
            return rnu.chamarConsulta(u);
        }

        //Service Unidade Residencial
        public void inseirUnidadeResidencial(Morada_da_paz_Biblioteca.basicas.unidade_residencial ur)
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            rnund.chamarInserir(ur);
        }

        public void editaUnidadeResisencial(Morada_da_paz_Biblioteca.basicas.unidade_residencial ur)
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            rnund.chamarAtualizar(ur);
        }

        public List<Morada_da_paz_Biblioteca.basicas.unidade_residencial> listarUnidades()
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            return rnund.chamarListar();
        }

        public Morada_da_paz_Biblioteca.basicas.unidade_residencial pesquisaUnidade(Morada_da_paz_Biblioteca.basicas.unidade_residencial ur)
        {
            RNunidadeResidencial rnund = new RNunidadeResidencial();
            return rnund.chamarConsulta(ur);
        }

        //Service Advertencia
        public void inserirAdvertencia(Morada_da_paz_Biblioteca.basicas.advertencia a)
        {
            throw new NotImplementedException();
        }

        public void editarAdvertencia(Morada_da_paz_Biblioteca.basicas.advertencia a)
        {
            throw new NotImplementedException();
        }

        public List<Morada_da_paz_Biblioteca.basicas.advertencia> listarAdvertencias()
        {
            throw new NotImplementedException();
        }

        public Morada_da_paz_Biblioteca.basicas.advertencia pesquisaAdvertencia(Morada_da_paz_Biblioteca.basicas.advertencia a)
        {
            throw new NotImplementedException();
        }

        //Service Especialização do Usuario
        public void inserirEspecializacao(Morada_da_paz_Biblioteca.basicas.especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public void editarEspecializacao(Morada_da_paz_Biblioteca.basicas.especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        public List<Morada_da_paz_Biblioteca.basicas.especializacao_usuario> listarEspecializacao()
        {
            throw new NotImplementedException();
        }

        public Morada_da_paz_Biblioteca.basicas.especializacao_usuario pesquisaEspecializacao(Morada_da_paz_Biblioteca.basicas.especializacao_usuario eu)
        {
            throw new NotImplementedException();
        }

        //Service Multa
        public void inserirMulta(Morada_da_paz_Biblioteca.basicas.multa m)
        {
            throw new NotImplementedException();
        }

        public void editarMulta(Morada_da_paz_Biblioteca.basicas.multa m)
        {
            throw new NotImplementedException();
        }

        public List<Morada_da_paz_Biblioteca.basicas.multa> listarMulta()
        {
            throw new NotImplementedException();
        }

        public Morada_da_paz_Biblioteca.basicas.multa pesquisaMulta(Morada_da_paz_Biblioteca.basicas.multa m)
        {
            throw new NotImplementedException();
        }

        //Service Ocorrencia
        public void inserirOcorrencia(Morada_da_paz_Biblioteca.basicas.ocorrencia o)
        {
            throw new NotImplementedException();
        }

        public void editarOcorrencia(Morada_da_paz_Biblioteca.basicas.ocorrencia o)
        {
            throw new NotImplementedException();
        }

        public List<Morada_da_paz_Biblioteca.basicas.ocorrencia> listarOcorrencias()
        {
            throw new NotImplementedException();
        }

        public Morada_da_paz_Biblioteca.basicas.ocorrencia pesquisaOcorrencia(Morada_da_paz_Biblioteca.basicas.ocorrencia o)
        {
            throw new NotImplementedException();
        }
    }
}
