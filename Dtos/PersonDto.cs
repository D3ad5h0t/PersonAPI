using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Dtos
{
    public class PersonDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? Telephone { get; set; }
    }
}