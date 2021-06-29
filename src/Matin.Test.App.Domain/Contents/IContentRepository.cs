using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Matin.Test.App.Contents
{
    public interface IContentRepository : IRepository<AppContent, Guid>
    {
        Task<AppContent> FindByNameAsync(string name);

        Task<List<AppContent>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}