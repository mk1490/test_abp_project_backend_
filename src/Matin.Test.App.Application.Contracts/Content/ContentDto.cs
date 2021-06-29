using System;
using Volo.Abp.Application.Dtos;

namespace Matin.Test.App.Content
{
    public class ContentDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}