using AutoMapper;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Interfaces;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.Services
{
    public class CompanyDTOService : ICompanyDTOService
    {
        IUnitOfWork Database { get; set; }

        public CompanyDTOService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public IEnumerable<CompanyDTO> Find(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Company, CompanyDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Company>, List<CompanyDTO>>(Database.Companies.FindWithCompanyOffer(x => x.Offers.Any(y => y.OfferId == id)));
        }

        public void Create(CompanyDTO company)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CompanyDTO, Company>()).CreateMapper();
            var companyDal = mapper.Map<CompanyDTO, Company>(company);
            Database.Companies.Create(companyDal);
            Database.Save();
        }
    }
}
