namespace WizardingWorld.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharactersController : ControllerBase
{
  private readonly CharactersService _cs;

  [HttpGet]
  public ActionResult<List<Character>> Get()
  {
    try
    {
      var characters = _cs.GetCharacters();
      return Ok(characters);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Character> GetCharacter(string id)
  {
    try
    {
      var character = _cs.GetCharacter(id);
      return Ok(character);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPost]
  public ActionResult<Character> Create([FromBody] Character characterData)
  {
    try
    {

      Character character = _cs.AddCharacter(characterData);

      return Ok(character);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  public CharactersController(CharactersService cs)
  {
    _cs = cs;
  }

}
