using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models.Requests;
using Yesotronics.Domain.Models.Response;

namespace Yosotronics.Persistence.IRepositories
{
    public interface ISubscribeRepository
    {
        public Response PostSubscribe(SubscribeRequest subscribeRequest);
    }
}
