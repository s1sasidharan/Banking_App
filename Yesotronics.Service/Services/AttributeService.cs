using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yosotronics.Persistence.IRepositories;

namespace Yesotronics.Service.Services
{
    public class AttributeService : IAttributeService
    {
        private readonly IAttributeRepository _attributeRepository;
        public AttributeService(IAttributeRepository attributeRepository)
        {
            _attributeRepository = attributeRepository;
        }

        public Response PostAttribute(AttributeRequest attributeRequest)
        {
            return _attributeRepository.PostAttribute(attributeRequest);
        }
    }
}
