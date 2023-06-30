using AutoMapper;
using PersonAPI.Dtos;
using PersonAPI.Models;

namespace PersonAPI.Profiles
{
    public class FullNameResolver : IValueResolver<PersonBaseDto, Person, string>
    {
        public string Resolve(PersonBaseDto source, Person destination, string destMember, ResolutionContext context)
        {
            return source.FirstName + ' ' + source.LastName;
        }
    }
}