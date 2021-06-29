using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace Matin.Test.App.Contents
{
    public class ContentDataSeederContributor : IDataSeedContributor,
        ITransientDependency
    {
        private IRepository<AppContent, Guid> _repository;
        private IGuidGenerator _guidGenerator;
        private ICurrentTenant _currentTenant;

        public ContentDataSeederContributor(ICurrentTenant currentTenant, IGuidGenerator guidGenerator,
            IRepository<AppContent, Guid> repository)
        {
            _currentTenant = currentTenant;
            _guidGenerator = guidGenerator;
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            using (_currentTenant.Change(context?.TenantId))
            {
                if (await _repository.GetCountAsync() > 0)
                {
                    return;
                }

                var content = new AppContent
                {
                    CreatorId = _guidGenerator.Create(),
                    ContentId = _guidGenerator.Create(),
                    Title = "Salam; this is a title",
                    Content = "The content",
                    Duration = 20000,
                    TypeOfContent = ContentType.Video,
                };
                await _repository.InsertAsync(content, autoSave: true);
            }
        }
    }
}