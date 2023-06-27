using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? Telephone { get; set; }

        [Required]
        public string? DoB { get; set; }

        public int YearsAlive
        {
            get
            {
                var today = DateTime.Today;
                var splidDob = DoB!.Split("-");

                return today.Year - int.Parse(splidDob[0]);
            }
        }
    }
}