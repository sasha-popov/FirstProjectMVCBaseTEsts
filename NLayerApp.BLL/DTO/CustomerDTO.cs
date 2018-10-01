using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.DTO
{
    public class CustomerDTO
    {
 
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public string UserId { get; set; }

        public string Adress { get; set; }

        public virtual ICollection<CustomerOfferDTO> CustomerOffers { get; set; }

        public CustomerDTO()
        {
            CustomerOffers = new List<CustomerOfferDTO>();
        }
    }
}
