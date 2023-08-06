using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.Repositories
{
    public class SubscribeRepository : ISubscribeRepository
    {
        private readonly YosotronicsDbContext _context;
        public SubscribeRepository(YosotronicsDbContext context)
        {
            _context = context;
        }
            public Response PostSubscribe(SubscribeRequest subscribeRequest)
        {
            Response response = new Response();
            SubscribeDTO subscribeDTO = new SubscribeDTO();
            subscribeDTO.Email = subscribeRequest.Email;
            subscribeDTO.CreatedBy = 1;
            subscribeDTO.CreatedDate = DateTime.Now;
            subscribeDTO.IsActive = true;
            subscribeDTO.IsDeleted = false;

            _context.Subscribes.Add(subscribeDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;
        }
    }
}
