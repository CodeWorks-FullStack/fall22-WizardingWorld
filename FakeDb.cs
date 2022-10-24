using WizardingWorld.Enums;

namespace WizardingWorld.Data;


// EVENTUALLY we should swap this thing out!!!
public class FakeDb
{
  public List<Character> Characters = new List<Character>()
  {
    new Character("Harry ⚡ Potter", 10, false, WizardingHouse.Gryffindor),
    new Character("James Potter", 21, false, WizardingHouse.Gryffindor),
    new Character("Lily Potter", 21, false, WizardingHouse.Gryffindor),
    new Character("Hagrid", 60, true, WizardingHouse.Gryffindor),
    new Character("Dumbledore", 115, false, WizardingHouse.Gryffindor),
    new Character("Tom Riddle", 72, false, WizardingHouse.Slytherin),
    new Character("Jake Overall", 72, false, WizardingHouse.Slytherin),
    new Character("Savannah Temple", 72, false, WizardingHouse.Slytherin),
    new Character("Samantha Dison", 72, false, WizardingHouse.Slytherin),
    new Character("Miles Collins", 72, false, WizardingHouse.Ravenclaw)
  };
}
