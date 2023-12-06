namespace FilmesApi.Profile;
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

public class FilmesProfile : Profile
{ 
    public FilmesProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();

    }

}
