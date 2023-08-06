using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesotronics.Domain.Models.Requests
{
    public class UserRequest
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
    }
}
