using Umbraco.Cms.Core.Services;
namespace umbraco13_tutorial.Testing;

public class TestClass(IMediaService mediaService)
{
    private readonly IMediaService _mediaService = mediaService;

    public void DoSomething()
    {
        var thing = _mediaService.GetById(1);
    }
}
