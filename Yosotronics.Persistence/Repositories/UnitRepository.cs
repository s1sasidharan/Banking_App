using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesotronics.Domain.Models.Request;
using Yesotronics.Domain.Models;
using Yosotronics.Persistence.Models;
using Yosotronics.Persistence.IRepositories;
using Yesotronics.Domain.Models.Response;

namespace Yosotronics.Persistence.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        private readonly IMapper _mapper;
        private readonly YosotronicsDbContext _context;

        public UnitRepository(YosotronicsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Unit> GetUnits()
        {
            List<Unit> units = new List<Unit>();
            List<UnitDTO> unitsDTO = new List<UnitDTO>();
            unitsDTO = _context.Units.ToList();
            units = _mapper.Map<List<Unit>>(unitsDTO);
            return units;
        }

        public Response PostUnit(UnitRequest unitRequest)
        {
            Response response = new Response();

            UnitDTO unitDTO = new UnitDTO();
            unitDTO = _mapper.Map<UnitDTO>(unitRequest);
            unitDTO.CreatedBy = 1;
            unitDTO.CreatedDate = DateTime.Now;
            unitDTO.IsActive = true;
            unitDTO.IsDeleted = false;

            _context.Units.Add(unitDTO);
            _context.SaveChanges();
            response.Status = "Success";
            response.Message = "Record Saved";
            return response;

        }
    }
}
