using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BLL.DTO
{
   public class CustomerOfferDTO
    {
        public int CustomerOfferId { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }

        public int? CustomerId { get; set; }
        public string UserId { get; set; }

        public int? OfferId { get; set; }

        public string Content { get; set; }
    }
}
