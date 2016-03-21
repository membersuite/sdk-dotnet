using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Represents a serializable, transportable file structure
    /// </summary>
    [Serializable]
    [DataContract]
    public class MemberSuiteFile
    {
        [DataMember]
        public byte[] FileContents { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string FileType { get; set; }
    }
}