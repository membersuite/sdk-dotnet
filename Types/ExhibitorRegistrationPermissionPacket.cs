using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public class ExhibitorRegistrationPermissionPacket
    {
        public List<ExhibitorRegistationPermission> Permissions { get; set; }
    }

    public class ExhibitorRegistationPermission
    {
        public string EntityID { get; set; }
        public string EntityName { get; set; }
        public string RegistrationWindowID { get; set; }
        public string RegistrationWindowName { get; set; }
        public ExhibitorRegistrationMode RegistrationMode { get; set; }
    }
}
