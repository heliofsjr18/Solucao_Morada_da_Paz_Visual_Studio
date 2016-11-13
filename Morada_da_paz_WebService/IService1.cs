using Morada_da_paz_Biblioteca.basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Morada_da_paz_WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        
        // ------------- Service Usuario ----------

        void inseirUsuario(usuario u);

        void editarUsuario(usuario u);

        List<usuario> listarUsuarios();

        usuario pesquisaUsuario(usuario u);

        // ------------ Service Unidade Residencial ------------

        void inseirUnidadeResidencial(unidade_residencial ur);

        void editaUnidadeResisencial(unidade_residencial ur);

        List<unidade_residencial> listarUnidades();

        unidade_residencial pesquisaUnidade(unidade_residencial ur);

        // -------------- Service advertencia ---------------

        void inserirAdvertencia(advertencia a);

        void editarAdvertencia(advertencia a);

        List<advertencia> listarAdvertencias();

        advertencia pesquisaAdvertencia(advertencia a);

        // ------------- Service Especialização Usuario ------------

        void inserirEspecializacao(especializacao_usuario eu);

        void editarEspecializacao(especializacao_usuario eu);

        List<especializacao_usuario> listarEspecializacao();

        especializacao_usuario pesquisaEspecializacao(especializacao_usuario eu);

        // ------------ Service Multa ----------------------

        void inserirMulta(multa m);

        void editarMulta(multa m);

        List<multa> listarMulta();

        multa pesquisaMulta(multa m);


        // --------- Service Ocorrencia ----------------

        void inserirOcorrencia(ocorrencia o);

        void editarOcorrencia(ocorrencia o);

        List<ocorrencia> listarOcorrencias();

        ocorrencia pesquisaOcorrencia(ocorrencia o);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
