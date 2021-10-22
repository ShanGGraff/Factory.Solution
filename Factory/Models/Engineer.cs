using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<License>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<License> JoinEntities { get; set; }
    }
}