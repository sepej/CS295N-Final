using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADWORDS.Models
{
    public class User
    {
        // userID will become primary key
        public int UserID { get; set; }
        public string Name { get; set; }
    }
}
