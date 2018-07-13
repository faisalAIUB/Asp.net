using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectRepository
{
   public class Thana
    {
        [Key]
        public int ThanaId { get; set; }
        public string ThanaName { get; set; }
        public int DistrictId { get; set; }
    }
}
