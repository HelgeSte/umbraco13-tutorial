using Umbraco.Cms.Core.Models;

namespace umbraco13_tutorial.Extensions
{
    public static class MediaWithCropsExtensions
    {
        public static string GetAltText(this MediaWithCrops mediaItem, string altTextAlias = "altText")
        {
            var altText = mediaItem.Value<string>(altTextAlias); // return value that is associated with the alias from the mediaItem object
            if (string.IsNullOrWhiteSpace(altText)) return string.Empty;

            return altText;
        }

        public static string GetLocation(this MediaWithCrops mediaItem, string locationAlias = "location")
        {
            var location = mediaItem.Value<string>(locationAlias);
            if (string.IsNullOrWhiteSpace(location)) return string.Empty;

            return location;
        }
    }
}
