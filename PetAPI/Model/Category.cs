﻿using System.ComponentModel.DataAnnotations;

namespace PetAPI.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<Animal>? Animals { get; set; }



    }
}
