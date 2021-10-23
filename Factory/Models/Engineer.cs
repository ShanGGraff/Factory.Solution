using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<License>();
        }

        public int EngineerId { get; set; }
        public string EngineerName { get; set; }
        public virtual ICollection<License> JoinEntities { get; set; }
    }
}