using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
 

namespace MemberSuite.DataLoader.Common
{
    public interface IDataLoaderServiceCallback
    {
        
        [OperationContract(IsOneWay=true)]
        void ReportProgressMessage(  string msg , params object[] args );

        [OperationContract(IsOneWay = true)]
        void ReportProgressPercentage(decimal percentage, string msg );

        [OperationContract(IsOneWay = true)]
         void ReportNewPhase(DataImportProgressPhase phase, string msg );

        [OperationContract(IsOneWay = true)]
         void ReportClosePhase(DataImportProgressPhase phase, string msg );

        [OperationContract(IsOneWay = true)]
         void ReportValidationError(string file, int recordNumber, string msg);
        
    }
}
