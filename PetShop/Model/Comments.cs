using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Model
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        public int? AnimalId { get; set; }

        [ForeignKey("AnimalId")]
        public Animal? Animal { get; set; }

        public string? Comment { get; set; }
    }
}
