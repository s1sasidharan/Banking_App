using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly YosotronicsDbContext _context;

        public UserRepository(YosotronicsDbContext context)
        {
            _context = context;
        }
        public Response PostUser(UserRequest userRequest)
        {
            Response response = new Response();
            
            UserDTO userDTO = new UserDTO();
            userDTO.FName = userRequest.FName;
            userDTO.LName = userRequest.LName;  
            userDTO.Email = userRequest.Email;  
            userDTO.Password = userRequest.Password;    
            userDTO.MobileNo = userRequest.MobileNo;
            userDTO.CreatedBy = 1;
            userDTO.CreatedDate= DateTime.Now;
            userDTO.IsActive = true;
            userDTO.IsDeleted = false; 

            _context.Users.Add(userDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;    
            
        }
    }
}
