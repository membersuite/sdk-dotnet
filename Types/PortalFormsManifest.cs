using System.Collections.Generic;

namespace MemberSuite.SDK.Types
{
    public class PortalFormsManifest
    {
        public List<PortalFormInfo> Forms { get; set; }
    }

    public class PortalFormInfo
    {
        public string FormID { get; set; }
        public string FormName { get; set; }
        public string Module { get; set; }
        public string UnderlyingObjectName { get; set; }
        public bool CanCreate { get; set; }
        public bool CanView { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public string CreateLink { get; set; }
        public string ManageLink { get; set; }
        public int NumberOfExistingSubmissions { get; set; }
        public bool DisplayOnLoginScreen { get; set; }
        public bool DisplayOnHomeScreen { get; set; }
    }
}