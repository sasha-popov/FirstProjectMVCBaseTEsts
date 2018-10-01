using NLayerApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.Interfaces
{
    public interface ICompanyDTOService
    {
        void Create(CompanyDTO item);
        IEnumerable<CompanyDTO> Find(int id);
    }
}
