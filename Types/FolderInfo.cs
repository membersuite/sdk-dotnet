using System.Collections.Generic;

namespace MemberSuite.SDK.Types
{
    public class PartialFolderInfo
    {
        public string FolderName { get; set; }
        public string FolderID { get; set; }
        public FileFolderType FolderType { get; set; }
        public int TotalNumberOfFiles { get; set; }
        public int TotalFileSize { get; set; }
        public int TotalNumberOfSubFolders { get; set; }
        public bool RestrictedAccess { get; set; }
    }

    public class FolderInfo : PartialFolderInfo
    {
        public List<PartialFolderInfo> ParentFolders { get; set; }
        public List<PartialFolderInfo> SubFolders { get; set; }
        public List<FileInfo> Files { get; set; }
        public string FileCabinetID { get; set; }
        public string FileCabinetName { get; set; }
        public string FolderDescription { get; set; }
    }
}