using asp.netcore_airplane_restapi.Dtos;
using asp.netcore_airplane_restapi.Models;
using AutoMapper;

namespace asp.netcore_airplane_restapi.Profiles
{
    public class ProfilesData : Profile
    {
        public ProfilesData()
        {
            CreateMap<AirplaneCreateDto, Airplane>();
            CreateMap<PersonCreateDto, Person>();
        }
    }
}
