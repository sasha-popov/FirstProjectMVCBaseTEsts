using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{
    public class CompanyOffer
    {
        [Key]
        public int CompanyOfferId { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        public int Duration { get; set; }

        public int Price { get; set; }

        public CompanyOffer()
        {
            Offers = new List<Offer>();
            Companies = new List<Company>();
        }
    }
}