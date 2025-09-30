using AutoMapper;
using Backend.Dtos;
using Backend.Models;

namespace Backend.Data;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Entity -> DTO
        CreateMap<Horse, HorseDto>();
        CreateMap<RaceResults, RaceResultDto>();
            // .ForSourceMember(d => d.RaceId, o => o.DoNotValidate());
        CreateMap<Race, RaceDto>();
        CreateMap<Trainer, TrainerDto>();
        CreateMap<Stable,StableDto>();
        CreateMap<Track, TrackDto>();
        CreateMap<Owner, OwnerDto>();

        // DTO -> Entity (if you need it for POST/PUT)
        CreateMap<HorseDto, Horse>();
        CreateMap<RaceResultDto, RaceResults>();
        CreateMap<RaceDto, Race>();
        CreateMap<TrainerDto, Trainer>();
        CreateMap<StableDto,Stable>();
        CreateMap<TrackDto, Track>();
        CreateMap<OwnerDto, Owner>();

    }
    
}