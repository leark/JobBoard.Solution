using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContatctInfo { get; set; }
    public JobOpening(string title, string description, string contactInfo)
    {
      Title = title;
      Description = description;
      ContatctInfo = contactInfo;
    }
    // public string Description { get; set; }
    // public int Id { get; }
    // private static List<Item> _instances = new List<Item> { };

    // public Item(string description)
    // {
    //   Description = description;
    //   _instances.Add(this);
    //   Id = _instances.Count;
    // }

    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    // public static Item Find(int searchId)
    // {
    //   return _instances[searchId - 1];
    // }
  }
}