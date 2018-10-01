using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{

    // [DataContract(IsReference =false)]
    [Serializable]
    public class Category
    {
        public Category()
        {
            Offers = new List<Offer>();
        }
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }

        //[XmlIgnore]
        [XmlIgnore]
        public virtual ICollection<Offer> Offers { get; set; }


    }
}