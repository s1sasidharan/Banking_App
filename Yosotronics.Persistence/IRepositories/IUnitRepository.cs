using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models;
using Yesotronics.Domain.Models.Response;

namespace Yosotronics.Persistence.IRepositories
{
    public interface IUnitRepository
    {
        public Response PostUnit(UnitRequest unitRequest);
        public List<Unit> GetUnits();
    }
}
