using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSample.Models
{
    public class Lead
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Birthdate { get; set; }
        [Required]
        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }
    }
}