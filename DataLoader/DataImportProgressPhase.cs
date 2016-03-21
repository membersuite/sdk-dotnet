using System.Runtime.Serialization;

namespace MemberSuite.SDK.DataLoader
{
    [DataContract]
    public enum DataImportProgressPhase
    {
        [EnumMember] GenerateXmlFiles = 0,
        [EnumMember] ValidateXmlAndCollectMarkers = 1,
        [EnumMember] GenerateCleanFile = 2,
        [EnumMember] SendFilesToServer = 3,
        [EnumMember] GenerateCSV = 4,
        [EnumMember] BulkImport = 5
    }
}