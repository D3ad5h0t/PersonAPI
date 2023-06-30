using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Dtos
{
    public class PersonCreateDto : PersonBaseDto
    {
        public string? House { get; set; }
    }
}