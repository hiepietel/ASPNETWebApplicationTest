using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETWebApplicationTest.Models
{
    public class User
    {
        public int UserId { get; set; }
        [System.ComponentModel.DisplayName("User Name")]
        [Required(ErrorMessage ="This field is required.")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required.")]
        public string Password {get; set; }
    }
}