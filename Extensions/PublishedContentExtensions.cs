using Microsoft.CodeAnalysis.CSharp.Syntax;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace umbraco13_tutorial.Extensions;

// static = don't need to create an instance
public static class PublishedContentExtensions
{
    public static HomePage? GetHomePage(this  IPublishedContent publishedContent)
    {
        return publishedContent.AncestorOrSelf<HomePage>();
    }

    // Models/Generated/SiteSettings.cs
    public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent)
    {
        var homePage = GetHomePage(publishedContent);
        if (homePage == null) return null;
        return homePage.FirstChild<SiteSettings>();
    }
}