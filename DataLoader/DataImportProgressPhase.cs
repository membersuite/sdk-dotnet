using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.DataLoader.Common
{
    [DataContract]
    public enum DataImportProgressPhase
    {
        [EnumMember]
        GenerateXmlFiles = 0,
        [EnumMember]
        ValidateXmlAndCollectMarkers = 1,
        [EnumMember]
        GenerateCleanFile = 2,
        [EnumMember]
        SendFilesToServer = 3,
        [EnumMember]
        GenerateCSV = 4,
        [EnumMember]
        BulkImport = 5
    }
}
