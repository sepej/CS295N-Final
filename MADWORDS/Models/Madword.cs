using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADWORDS.Models
{
    public class Madword
    {
        //this MadwordID will become the primary key
        // Add ID to the key. EF knows the convention and makes it primary key
        public int MadwordID { get; set; }
        public string MadwordTitle { get; set; }
        public string MadwordTopic { get; set; }
        public string AuthorName { get; set; }
        public int MadwordRating { get; set; }

        // Has-a relationship
        // when EF creates the table, it will automatically create foreign key because of this
        public User Author { get; set; }
        public string MadwordText { get; set; }
        public DateTime MadwordDate { get; set; }
    }
}