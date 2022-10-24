using System.Text.Json.Serialization;

namespace WizardingWorld.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WizardingHouse
{
  Gryffindor,
  Hufflepuff,
  Ravenclaw,
  Slytherin
}