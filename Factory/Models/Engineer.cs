using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
    {
        public Category()
        {
            this.JoinEntities = new HashSet<License>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<License> JoinEntities { get; set; }
    }
}