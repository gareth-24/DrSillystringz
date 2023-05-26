namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }  //primary key
    public int EngineerId { get; set; } //engineer foreign key
    public Engineer Engineer { get; set; }  //reference navigation property
    public int MachineId { get; set; }  //machine foreign key
    public Machine Machine { get; set; }  //reference navigation property
  }
}