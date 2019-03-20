using System.Linq;
using Sdl.Community.EmbeddedContentProcessor.Processor;
using Sdl.FileTypeSupport.Framework.IntegrationApi;

namespace Sdl.Community.EmbeddedContentProcessor
{
    [FileTypeComponentBuilderExtension(Id = "XliffEmbeddedContentExtension2_Id",
        Name = "XliffEmbeddedContentExtension_Name",
        Description = "XliffEmbeddedContentExtension_Description",
        OriginalFileType = "XLIFF2 1.1-1.2 v 2.0.0.0")]
    public class XliffEmbeddedContentExentsionBuilder2 : XliffEmbeddedContentExentsionBuilder
	{
    }
}
