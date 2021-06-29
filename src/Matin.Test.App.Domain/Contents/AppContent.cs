using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Matin.Test.App.Contents
{
    public class AppContent : AuditedAggregateRoot<Guid>
    {
        public Guid ContentId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public long Duration { get; set; }
        public string Background { get; set; }
        public string TextColor { get; set; }
        public string Author { get; set; }
        public ContentType TypeOfContent { get; set; }
    }
}