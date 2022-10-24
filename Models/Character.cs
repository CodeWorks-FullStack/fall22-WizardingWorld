using WizardingWorld.Enums;

namespace WizardingWorld.Models;

public class Character
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public int Age { get; private set; }
  public bool IsAlive { get; private set; }
  public List<string> Aliases { get; private set; } = new List<string>();

  public WizardingHouse House { get; private set; }


  public void ChangeName(string name)
  {
    Name = name;
  }

  public int HappyBirthday()
  {
    Age++;
    return Age;
  }


  public Character(string name, int age, bool isAlive, WizardingHouse house)
  {

    Id = Guid.NewGuid().ToString();
    Name = name;
    Age = age;
    IsAlive = isAlive;
    House = house;
  }

}


