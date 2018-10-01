using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Linq;
using System.Web;

namespace NLayerApp.BLL.DTO
{

    // [DataContract(IsReference =false)]
    [Serializable]
    public class CategoryDTO
    {
        public CategoryDTO()
        {
            Offers = new List<OfferDTO>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //[XmlIgnore]
        public virtual ICollection<OfferDTO> Offers { get; set; }


    }
}