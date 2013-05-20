using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using MemberSuite.SDK.Types;


namespace MemberSuite.DataLoader.Common
{
    [ServiceContract(CallbackContract = typeof(IDataLoaderServiceCallback))]
    public interface IDataLoaderService
    {
     
       
        [OperationContract]
        List<NameValueStringPair> DownloadSchemas( string associationID, string userID );

        [OperationContract]
        FileTransmissionInstructions GetFileTransmissionInstructions();

        [OperationContract]
        bool InitiateImport(string associationID, string userID, string sessionID, string name, Dictionary<string,long> recordCounts);

        [OperationContract]
        void RollbackDataImport(string associationID, string userID, string dataImportID);
        
        [OperationContract]
        void WipeData(string associationID, string userID);

        [OperationContract]
        MarkerCache ResolveReferenceMarkers(string associationID, string userID,
            MarkerCache referencesToResolve);

        [OperationContract]
        Dictionary<string, List<string>> GenerateIdentifiers(string associationID, string userID, 
            Dictionary<string, int> identifiersToGenerate);

        [OperationContract( IsOneWay=true )]
        void KeepAlive();
    }
}