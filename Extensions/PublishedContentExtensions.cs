using Microsoft.CodeAnalysis.CSharp.Syntax;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace umbraco13_tutorial.Extensions;

// static = don't need to create an instance
public static class PublishedContentExtensions
{
	// Extension methods for getting the home page or site settings
    public static HomePage? GetHomePage(this  IPublishedContent publishedContent)
    {
        return publishedContent.AncestorOrSelf<HomePage>();
    }

    // Models/Generated/SiteSettings.cs
    // To create an extension method for the IPublishedContent, the first parameter must be IPublishedContent interface,
    // preceded by the this keyword.

    public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent) 
    {
        var homePage = GetHomePage(publishedContent);
        if (homePage == null) return null;
        return homePage.FirstChild<SiteSettings>();
    }
}