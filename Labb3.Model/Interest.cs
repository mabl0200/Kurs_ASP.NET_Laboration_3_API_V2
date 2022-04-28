using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb3.Model
{
    public class Interest
    {
        //Varje intresse ska ha en titel och en kort beskrivning
        [Key]
        public int InterestId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        //Ska gå att lagra ett obegränsat antal länkar
        public ICollection<Link> Links { get; set; }

        /*Varje person ska kunna vara kopplad till ett valfritt antal intressen
         och varje intresse ska kunna vara kopplad till flera personer vilket skapar ett Many-to-Many relationship.
        En kopplingstabell skapas som länk mellan Person och Interest*/
        public ICollection<PersonInterest> PersonInterests { get; set; }
    }
}
