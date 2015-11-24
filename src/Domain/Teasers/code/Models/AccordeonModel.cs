namespace Habitat.Teasers.Models
{
  using System;
  using System.Collections.Generic;
  using Sitecore.Data.Items;

  public class AccordeonModel
  {
    public AccordeonModel(Item item)
    {
      this.Id = $"accordion-{Guid.NewGuid().ToString("N")}";
    }

    public string Id { get; private set; }

    public IEnumerable<AccordeonElement> Elements => new[]
    {
      new AccordeonElement("Section 1"), new AccordeonElement("Section 2"), new AccordeonElement("Section 3")
    };
  }

  public class AccordeonElement
  {
    public AccordeonElement(string title)
    {
      this.Title = title;
      this.HeaderId = $"accordion-header-{Guid.NewGuid().ToString("N")}";
      this.PanelId = $"accordion-panel-{Guid.NewGuid().ToString("N")}";
    }

    public string HeaderId { get; private set; }
    public string PanelId { get; private set; }
    public string Title { get; private set; }
  }
}