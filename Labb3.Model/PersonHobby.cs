﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb3.Model
{
    public class PersonHobby
    {
        [Key]
        public int PersonHobbyId { get; set; }

        [Required]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        [Required]
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }
    }
}
