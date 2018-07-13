using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectRepository
{
    public class RentAd
    {
        [Key]
        public int RentId { get; set; }
        [Required(ErrorMessage = "FlatNo is required")]
        public string FlatNo { get; set; }
        [Required(ErrorMessage = "HouseNo is required")]
        public string HouseNo { get; set; }
        [Required(ErrorMessage = "RoadNo is required")]
        public string RoadNo { get; set; }
        [Required(ErrorMessage = "AreaNo is required")]
        public string Area { get; set; }
        public int ThanaId { get; set; }
        public int DistrictId { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Rent Amount is required")]
        public int RentAmount { get; set; }
        public string Date { get; set; }
        public int HidePost { get; set; }
        public int UserId { get; set; }
        
    }
}
