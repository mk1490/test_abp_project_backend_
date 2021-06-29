using AutoMapper;
using Matin.Test.App.Content;
using Matin.Test.App.Contents;

namespace Matin.Test.App
{
    public class AppApplicationAutoMapperProfile : Profile
    {
        public AppApplicationAutoMapperProfile()
        {
            CreateMap<AppContent, ContentDto>();
        }
    }
}