using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models.ModelsVM
{
    public class ExecuterOfferViewModel
    {
        [Key]
        public int ExecuterId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public int? CompanyId { get; set; }
       // public virtual Company Company { get; set; }

        public int? OfferId { get; set; }
       // public virtual Offer Offer { get; set; }

    }
}