using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectRepository
{
    public  class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public int Deactive { get; set; }

    }
}
