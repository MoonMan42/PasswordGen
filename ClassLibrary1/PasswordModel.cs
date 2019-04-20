using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLibrary2
{
    public class PasswordModel
    {
        public int ID { get; set; }
        public string Password { get; set; }

        public string DisplayPassword
        {
            get
            {
                return $"{Password}";
            }
        }
    }
}
