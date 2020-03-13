using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class User
    {
        public string id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Username cannot exceed more than 50 characters")]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }
        [MaxLength(50, ErrorMessage = "Gender cannot exceed more than 50 characters")]
        public string gender { get; set; }
    }
}
