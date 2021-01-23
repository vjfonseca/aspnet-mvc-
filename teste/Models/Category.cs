using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required ]
        public string Name { get; set; }
        // [Range(1, int.MaxValue, ErrorMessage = "Valor maior que 1")]
    }
}