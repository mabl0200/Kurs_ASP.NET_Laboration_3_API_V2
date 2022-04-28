using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb3.Model
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        //Varje person ska kunna vara kopplad till ett valfritt antal länkar
        //One to many
        public ICollection<Link> Links { get; set; }

        /*Varje person ska kunna vara kopplad till ett valfritt antal intressen
         och varje intresse ska kunna vara kopplad till flera personer vilket skapar ett Many-to-Many relationship.
        En kopplingstabell skapas som länk mellan Person och Interest*/
        
        //One to many
        public ICollection<PersonInterest> PersonsInterests { get; set; }

    }
}
