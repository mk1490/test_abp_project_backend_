using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Matin.Test.App.Content
{
    public interface IContentService : ICrudAppService<
        ContentDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateContentDto>
    {
        
    }
}