using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINALMVC.BL
{
    public class User
    {
        public string userId { get; set; }
        public string name { get; set; }
        public List<string> childList = new List<string>();
        public List<string> parentList = new List<string>();
        public string accountBalance { get; set; }

        public User()
        {
        }
    }
}
