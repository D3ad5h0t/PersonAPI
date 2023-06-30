using PersonAPI.Models;
using AutoMapper;
using PersonAPI.Dtos;

namespace PersonAPI.Profiles
{
    public class AgeResolver : IValueResolver<Person, PersonReadDto, int>
    {
        public int Resolve(Person source, PersonReadDto destination, int destMember, ResolutionContext context)
        {
            var today = DateTime.Today;
            var splidDob = source.DoB!.Split("-");

            return today.Year - int.Parse(splidDob[0]);
        }
    }
}