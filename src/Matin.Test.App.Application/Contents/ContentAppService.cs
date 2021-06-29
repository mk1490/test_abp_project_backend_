using System;
using System.Threading.Tasks;
using Matin.Test.App.Content;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Matin.Test.App.Contents
{
    public class ContentAppService : CrudAppService<
            AppContent,
            ContentDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateContentDto>,
        IContentService
    {
        private IContentRepository _contentRepository;

        public ContentAppService(IRepository<AppContent, Guid> repository, IContentRepository contentRepository) :
            base(repository)
        {
            _contentRepository = contentRepository;
        }

        public override async Task<ContentDto> GetAsync(Guid id)
        {
            var content = await Repository.GetAsync(id);
            var contentDto = ObjectMapper.Map<AppContent, ContentDto>(content);

            return contentDto;
        }
    }
}