using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Models;

namespace Yosotronics.Persistence.Repositories
{
    public class AttributeRepository : IAttributeRepository
    {
        private readonly YosotronicsDbContext _context;

        public AttributeRepository(YosotronicsDbContext context)
        {
            _context = context;
        }

        public Response PostAttribute(AttributeRequest attributeRequest)
        {
            Response response = new Response();

            AttributeDTO attributeDTO = new AttributeDTO();
            attributeDTO.Name = attributeRequest.Name;
            attributeDTO.Value = attributeRequest.Value;
            attributeDTO.CreatedBy = 1;
            attributeDTO.CreatedDate = DateTime.Now;
            attributeDTO.IsActive = true;
            attributeDTO.IsDeleted = false;

            _context.Attributes.Add(attributeDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
