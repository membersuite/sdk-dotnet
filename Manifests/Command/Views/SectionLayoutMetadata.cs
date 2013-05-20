using System.Collections.Generic;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    public interface ISectionLayoutMetadata  
    {
        string Name { get; set; }
        List<ViewMetadata.ControlSection> Sections { get; set; }

        void Clean  ();
    }
}
