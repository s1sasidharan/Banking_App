using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;

namespace Yesotronics.Service.IServices
{
    public interface IUserService
    {
        public Response PostUser(UserRequest userRequest);
    }
}
