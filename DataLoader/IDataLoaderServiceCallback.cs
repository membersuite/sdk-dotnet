using System.ServiceModel;

namespace MemberSuite.SDK.DataLoader
{
    public interface IDataLoaderServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReportProgressMessage(string msg, params object[] args);

        [OperationContract(IsOneWay = true)]
        void ReportProgressPercentage(decimal percentage, string msg);

        [OperationContract(IsOneWay = true)]
        void ReportNewPhase(DataImportProgressPhase phase, string msg);

        [OperationContract(IsOneWay = true)]
        void ReportClosePhase(DataImportProgressPhase phase, string msg);

        [OperationContract(IsOneWay = true)]
        void ReportValidationError(string file, int recordNumber, string msg);
    }
}