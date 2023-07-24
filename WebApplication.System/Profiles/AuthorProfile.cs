using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services.ViewModels;

namespace WebApplication2.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Adress,
                opt => opt.MapFrom(src => $"{src.AdderssNo},{src.Street},{src.City}"));
        }

    }
}
