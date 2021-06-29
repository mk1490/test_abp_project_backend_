using System;
using System.ComponentModel.DataAnnotations;
using Matin.Test.App.Contents;

namespace Matin.Test.App.Content
{
    public class CreateUpdateContentDto
    {
        [Required] [StringLength(128)] public string Title { get; set; }


        [Required] [StringLength(128)] public string Content { get; set; }

        [Required] public ContentType TypeOfContent { set; get; }
        [Required] public string Author { get; set; }

    }
}