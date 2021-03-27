using AutoMapper;
using MapperProfileExample.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MapperProfileExample
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, _dbUser>().ReverseMap()
                .ForMember(x=>x.JsonString, opt=>opt.MapFrom(
                   x=>JsonConvert.DeserializeObject(x.JsonString)
                    ))
                  .ForMember(dest => dest.Age, opt => opt
          .MapFrom(src => (DateTime.Now.Year - src.BirthDate.Year)

          ));
                  
        }
    }
}
