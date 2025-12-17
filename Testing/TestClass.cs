using Umbraco.Cms.Core.Services;
namespace umbraco13_tutorial.Testing;

public class TestClass
{
    private readonly IMediaService _mediaService;
    public TestClass(IMediaService mediaService)
    {
        _mediaService = mediaService;
    }

    public void DoSomething()
    {
        var thing = _mediaService.GetById(1);
    }
}
