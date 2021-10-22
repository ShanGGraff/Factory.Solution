using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<Engineer>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }

    public virtual ICollection<Registrar> JoinEntities { get;}
  }
}