using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;

namespace Yosotronics.Persistence.IRepositories
{
    public interface IUserRepository
    {
        public Response PostUser(UserRequest userRequest);
    }
}
