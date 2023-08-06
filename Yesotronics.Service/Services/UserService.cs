using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yosotronics.Persistence.IRepositories;

namespace Yesotronics.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public Response PostUser(UserRequest userRequest)
        {
            return _userRepository.PostUser(userRequest);
        }
    }
}
