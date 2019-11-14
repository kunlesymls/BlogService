using AutoMapper;
using Blog.Models;
using Blog.ViewModels;

namespace UnifiedLMS.WebApi.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryListVm>().ReverseMap();           

        }
    }
}
