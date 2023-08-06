using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models;
using Yosotronics.Persistence.IRepositories;
using Yesotronics.Domain.Models.Response;
using Yesotronics.Service.IServices;

namespace Yesotronics.Service.Services
{
    public class UnitService : IUnitService
    {
        private readonly IUnitRepository _unitRepository;
        public UnitService(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public Response PostUnit(UnitRequest unitRequest)
        {
            return _unitRepository.PostUnit(unitRequest);
        }
        public List<Unit> GetUnits()
        {
            return _unitRepository.GetUnits();
        }
    }
}
