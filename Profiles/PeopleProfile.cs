using AutoMapper;
using PersonAPI.Dtos;
using PersonAPI.Models;

namespace PersonAPI.Profiles
{
    public class PeopleProfile : Profile
    {
        public PeopleProfile()
        {
            // Source -> Destination
            CreateMap<Person, PersonReadDto>()
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.YearsAlive));

            CreateMap<PersonCreateDto, Person>();
        }
    }
}