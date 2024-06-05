using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class LoginRequest
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string UserName { get; set; } = "";

        [Required]
        [StringLength(30, MinimumLength = 6)]
        public string Password { get; set; } = "";
    }
}
