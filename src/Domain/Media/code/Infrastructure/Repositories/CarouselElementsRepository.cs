namespace Habitat.Media.Infrastructure.Repositories
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Habitat.Framework.SitecoreExtensions.Extensions;
  using Habitat.Media.Infrastructure.Models;
  using Sitecore.Data.Fields;
  using Sitecore.Data.Items;
  using Sitecore.Resources.Media;

  public static class CarouselElementsRepository
  {
    public static IEnumerable<CarouselElement> Get(Item item)
    {
      var active = "active";
      foreach (var child in item.GetMultiListValues(Templates.HasMediaSelector.Fields.MediaSelector).Where(i => i.IsDerived(Templates.HasMedia.ID)))
      {
        yield return new CarouselElement
        {
          Item = child,
          Active = active,
          IsFullScreenImage = IsFullScreenImage(child)
        };
        active = "";
      }
    }

    private static bool IsFullScreenImage(Item child)
    {
      ImageField imageField = child.IsDerived(Templates.HasMediaImage.ID) ? child.Fields[Templates.HasMediaImage.Fields.Image] : child.Fields[Templates.HasMedia.Fields.Thumbnail];
      if (imageField == null)
        return false;
      int width;
      int height;
      if (!int.TryParse(imageField.Width, out width) || !int.TryParse(imageField.Height, out height))
        return false;
      return ((width / height) > (16 / 9));
    }
  }
}