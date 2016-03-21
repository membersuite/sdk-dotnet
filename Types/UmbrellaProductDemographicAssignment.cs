using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    public class UmbrellaProductDemographicAssignment : IMemberSuiteComponent
    {
        public UmbrellaProductDemographicAssignment()
        {
            ValueMappings = new List<UmbrellaProductDemographicAssignmentValueMapping>();
        }

        public List<UmbrellaProductDemographicAssignmentValueMapping> ValueMappings { get; set; }
    }

    [Serializable]
    public class UmbrellaProductDemographicAssignmentValueMapping
    {
        public string DemographicID { get; set; }
        public List<string> Values { get; set; }

    }
}
