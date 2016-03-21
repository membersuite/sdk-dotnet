using System;

namespace MemberSuite.SDK.DuplicateDetection
{
    [Serializable]
    public class DetectionField
    {
        public string Name { get; set; }
        public DuplicateDetectionMatchMode MatchType { get; set; }
    }
}