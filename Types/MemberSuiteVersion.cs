using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class MemberSuiteVersion
    {
        public MemberSuiteVersion()
        {
        }

        public MemberSuiteVersion(AssemblyName nameOfAssembly)
        {
            Major = nameOfAssembly.Version.Major;
            Minor = nameOfAssembly.Version.Minor;
            Revision = nameOfAssembly.Version.Revision;
            BuildNumber = nameOfAssembly.Version.Build;
        }

        [DataMember]
        public long Major { get; set; }

        [DataMember]
        public long Minor { get; set; }

        [DataMember]
        public long Revision { get; set; }

        [DataMember]
        public long BuildNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}.{3}",
                Major, Minor, Revision, BuildNumber);
        }
    }
}