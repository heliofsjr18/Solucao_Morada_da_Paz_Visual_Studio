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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceMoradaDaPaz" in both code and config file together.
    [ServiceContract]
    public interface IServiceMoradaDaPaz
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        // ------------- Service Usuario ----------
        [OperationContract]
        void inseirUsuario(usuario u);

        [OperationContract]
        void editarUsuario(usuario u);

        [OperationContract]
        List<usuario> listarUsuarios();

        [OperationContract]
        usuario pesquisaUsuario(usuario u);

        [OperationContract]
        usuario pesquisaUsuarioLogin(usuario u);

        // ------------ Service Unidade Residencial ------------
        [OperationContract]
        void inseirUnidadeResidencial(unidade_residencial ur);

        [OperationContract]
        void editaUnidadeResisencial(unidade_residencial ur);

        [OperationContract]
        List<unidade_residencial> listarUnidades();

        [OperationContract]
        unidade_residencial pesquisaUnidade(unidade_residencial ur);

        // -------------- Service advertencia ---------------
        [OperationContract]
        void inserirAdvertencia(advertencia a);

        [OperationContract]
        void editarAdvertencia(advertencia a);

        [OperationContract]
        List<advertencia> listarAdvertencias();

        [OperationContract]
        advertencia pesquisaAdvertencia(advertencia a);

        // ------------- Service Especialização Usuario ------------
        [OperationContract]
        void inserirEspecializacao(especializacao_usuario eu);

        [OperationContract]
        void editarEspecializacao(especializacao_usuario eu);

        [OperationContract]
        List<especializacao_usuario> listarEspecializacao();

        [OperationContract]
        especializacao_usuario pesquisaEspecializacao(especializacao_usuario eu);

        // ------------ Service Multa ----------------------
        [OperationContract]
        void inserirMulta(multa m);

        [OperationContract]
        void editarMulta(multa m);

        [OperationContract]
        List<multa> listarMulta();

        [OperationContract]
        multa pesquisaMulta(multa m);


        // --------- Service Ocorrencia ----------------
        [OperationContract]
        void inserirOcorrencia(ocorrencia o);

        [OperationContract]
        void editarOcorrencia(ocorrencia o);

        [OperationContract]
        List<ocorrencia> listarOcorrencias();

        [OperationContract]
        ocorrencia pesquisaOcorrencia(ocorrencia o);

        [OperationContract]
        List<ocorrencia> listarOcorrenciasPorUsuario(usuario u);

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
