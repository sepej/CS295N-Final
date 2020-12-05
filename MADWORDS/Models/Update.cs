using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADWORDS.Models
{
    public class Update
    {
        //this MadwordID will become the primary key
        // Add ID to the key. EF knows the convention and makes it primary key
        public int UpdateID { get; set; }
        public string UpdateTitle { get; set; }

        // Has-a relationship
        // when EF creates the table, it will automatically create foreign key because of this
        public string UpdateText { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
