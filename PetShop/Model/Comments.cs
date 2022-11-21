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
        public virtual Animal? Animal { get; set; }

        [DataType(DataType.MultilineText)]
        [Required (ErrorMessage ="Comment cannot be empty")]
        [StringLength(1000, ErrorMessage =("Comment shold be between 3 and 1000 chars"), MinimumLength = 3)]
        public string? Comment { get; set; }
    }
}
