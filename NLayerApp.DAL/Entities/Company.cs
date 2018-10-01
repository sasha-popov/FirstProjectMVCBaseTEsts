using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Adress { get; set; }

        public string UserId { get; set; }
        public virtual ICollection<Executer> Executers { get; set; }
        public virtual ICollection<CompanyOffer> CompanyOffers { get; set; }
        public Company()
        {
            Executers = new List<Executer>();
            CompanyOffers = new List<CompanyOffer>();
        }

    }
}