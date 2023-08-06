using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;
using Yosotronics.Persistence.IRepositories;
using Yosotronics.Persistence.Repositories;

namespace Yesotronics.Service.Services
{
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository _subscribeRepository;
        public SubscribeService(ISubscribeRepository subscribeRepository)
        {
            _subscribeRepository = subscribeRepository;
        }
        public Response PostSubscribe(SubscribeRequest subscribeRequest)
        {
            return _subscribeRepository.PostSubscribe(subscribeRequest);
        }
    }
}
