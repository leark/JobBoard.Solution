using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContactInfo { get; set; }
    public int Id { get; }
    private static List<JobOpening> _instances = new List<JobOpening> { };
    public JobOpening(string title, string description, string contactInfo)
    {
      Title = title;
      Description = description;
      ContactInfo = contactInfo;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // id starts at 1
    public static JobOpening Find(int id)
    {
      for (int i = 0; i < _instances.Count; i++)
      {
        if (_instances[i].Id == id)
        {
          return _instances[i];
        }
      }
      return null;
    }

    public static void Delete(JobOpening jO)
    {
      // changed implementation to not encounter the problem shown below
      // Find was also altered for this
      // 1 2 3 4 5
      // 1 2 3 4 5
      // x y z
      // inside instances
      // 1 2 3 4 5 x y z
      // 1 2 3 4 5 6 7 8
      // inside instances
      // 3 4 5 x y z
      // 3 4 5 6 7 8 <- ids
      // inside instances
      // 3 4 5 x y z q w
      // 3 4 5 6 7 8 9 10
      // inside show of x
      // delete button -> Model.Id -> 6
      // Destroy(6)
      // JobOpening.Delete(6)
      // _instances.RemoveAt(6 - 1)
      // inside instances
      // 3 4 5 x y z q w
      // 0 1 2 3 4 5 6 7 <- indexes (edited)
      // 3 4 5 6 7 8 9 10 <- ids
      // it would wrongly delete z in this case
      _instances.Remove(jO);
    }
  }
}