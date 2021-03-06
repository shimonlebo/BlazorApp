using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.UI.Data
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First Name is too long.")]
        [MinLength(2, ErrorMessage = "First Name is too short.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last Name is too long.")]
        [MinLength(2, ErrorMessage = "Last Name is too short.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
