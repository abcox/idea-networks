using AutoMapper;
using proquote.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proquote.Models
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<TblQuoteMain, Quote>()
                .ForMember(to => to.Id, opt => opt.MapFrom(from => from.QuoteId))
                .ForMember(to => to.Name, opt => opt.MapFrom(from => from.Name));
        }
    }
}
