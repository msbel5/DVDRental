using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DVDRental.Dtos;
using DVDRental.Models;

namespace DVDRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<MembershipTypeDto, MembershipType>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<Genre, GenreDto>();
            CreateMap<GenreDto, Genre>().ForMember(x => x.Id, opt => opt.Ignore());

        }
    }
}