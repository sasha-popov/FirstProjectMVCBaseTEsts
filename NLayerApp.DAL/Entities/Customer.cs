using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }

        public string UserId { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<CustomerOffer> CustomerOffers { get; set; }

        public Customer()
        {
            CustomerOffers = new List<CustomerOffer>();
        }
    }
}