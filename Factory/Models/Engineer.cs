using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; } //primary key
    [Required(ErrorMessage = "The engineer's name can't be empty!")]
    public string EngineerName { get; set; }
    public List<EngineerMachine> JoinEntities { get;} //collection navigation property
  }
}