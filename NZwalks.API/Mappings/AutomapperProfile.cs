﻿using AutoMapper;
using NZwalks.API.Models.Domain;
using NZwalks.API.Models.DTO;

namespace NZwalks.API.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Region,RegionDto>().ReverseMap();
            CreateMap<AddREgionRequestDTo,Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDTO, Region>().ReverseMap();
            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<WalkDTO,Walk>().ReverseMap();
            CreateMap<DIfficultyDTO,Difficulty>().ReverseMap();
            CreateMap<UpdateWalkRequestDTO, Walk>().ReverseMap();
        }
    }
}
