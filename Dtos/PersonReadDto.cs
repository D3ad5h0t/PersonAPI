using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Dtos
{
    public class PersonReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? Telephone { get; set; }

        public int Age { get; set; }
    }
}