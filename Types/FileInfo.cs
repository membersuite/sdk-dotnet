using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public class FileInfo
    {
        public string FileName { get; set; }
        public string FileID { get; set; }
        public int NumberOfBytes { get; set; }
        public string FileSize { get; set; }
        public string FileExtension { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedByName { get; set; }

        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedByName { get; set; }

        public string Description { get; set; }

        public static FileInfo FromFullTextSearchResult(DataRow dr)
        {
            if (dr == null) throw new ArgumentNullException("dr");

            FileInfo fi = new FileInfo();
            fi.FileID = Convert.ToString(dr["ID"]);
            fi.FileName = Convert.ToString( dr["Name"]);
            fi.Description = Convert.ToString( dr["ContainerName"]);
            fi.CreatedByName = Convert.ToString(dr["CreatedBy_Name"]);
            fi.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
            fi.LastModifiedByName = Convert.ToString(dr["LastModifiedBy_Name"]);
            fi.LastModifiedDate = Convert.ToDateTime(dr["LastModifiedDate"]);
            fi.NumberOfBytes= Convert.ToInt32( dr["ContentLength"]);
            fi.FileExtension = Convert.ToString( dr["Extension"]);
            fi.FileSize = Convert.ToString(dr["FileSize"]);

            return fi;

        }
    }
}
