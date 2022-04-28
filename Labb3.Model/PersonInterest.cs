using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb3.Model
{
    public class PersonInterest
    {
        [Key]
        public int PersonInterestId { get; set; }

        [Required]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        [Required]
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
