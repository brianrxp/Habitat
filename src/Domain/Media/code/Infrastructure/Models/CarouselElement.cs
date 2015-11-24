﻿namespace Habitat.Media.Infrastructure.Models
{
  using Sitecore.Data.Items;

  public class CarouselElement
  {
    public Item Item { get; set; }
    public string Active { get; set; }
    public bool IsFullScreenImage { get; set; }
  }
}