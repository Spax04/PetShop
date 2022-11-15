using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Model
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name: ")]
        [Required(ErrorMessage ="Animal name is required")]
       
        public string? Name { get; set; }

        [DisplayName("Age: ")]
        [Required(ErrorMessage = "Age is required")]
        public int? Age { get; set; }

        [DisplayName("Image URL: ")]
        [Required(ErrorMessage = "Picture URL is required")]
        public string? PictureName { get; set; }

        [DisplayName("Discription: ")]
        [Required(ErrorMessage = "Discription is required")]
        [DataType(DataType.MultilineText)]
        public string? Discription { get; set; }

        //Relationship
        [Required(ErrorMessage = "Category is required")]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        [DisplayName("Count of comments: ")]
        public virtual ICollection<Comments>? Comments { get; set; }
    }
}
