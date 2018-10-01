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
    public class CustomerDTOService: ICustomerDTOService
    {
        IUnitOfWork Database { get; set; }

        public CustomerDTOService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(CustomerDTO customer)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, Customer>()).CreateMapper();
            var customerDal = mapper.Map<CustomerDTO, Customer>(customer);
            Database.Customers.Create(customerDal);
            Database.Save();
        }
    }
}
