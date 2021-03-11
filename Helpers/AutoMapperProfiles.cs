using AutoMapper;
using qrnick_api.DTOs;
using qrnick_api.Entities;

namespace qrnick_api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
           CreateMap<RegisterDto, AppUser>();
        }
    }
}