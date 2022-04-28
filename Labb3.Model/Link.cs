using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb3.Model
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string URL { get; set; }

        //En länk ska vara kopplad till en person...
        [Required]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        //..och till ett visst intresse
        [Required]
        public int InterestId { get; set; }
        public Interest Interest { get; set; }

        
    }
}
