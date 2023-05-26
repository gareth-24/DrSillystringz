using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; } //primary key
    [Required(ErrorMessage = "The machines's name can't be empty!")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "The machines's description can't be emtpy")]
    public string Description { get; set; }
    public List<EngineerMachine> JoinEntities { get;} //collection navigation property
  }
}