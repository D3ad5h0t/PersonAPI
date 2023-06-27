using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Dtos
{
    public class PersonCreateDto
    {
        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? Telephone { get; set; }

        [Required]
        public string? DoB { get; set; }
    }
}