namespace WizardingWorld.Services;

public class CharactersService
{
  private readonly FakeDb _db;

  public List<Character> GetCharacters()
  {
    // This will get a bit more complicated later....
    return _db.Characters;
  }

  public Character GetCharacter(string id)
  {
    var character = _db.Characters.Find(c => c.Id == id);
    if (character == null)
    {
      throw new Exception("Invalid Id");
    }

    return character;

  }


  public Character AddCharacter(Character characterData)
  {
    // this does get more complex.... tomorrow ☀️ 🌈
    _db.Characters.Add(characterData);
    return characterData;
  }

  // Every single service will follow a similar pattern... which means you could
  // probably use something like inheritance to simplify it....!?!?!?!!?
  public CharactersService(FakeDb db)
  {
    _db = db;
  }


}