using System.Text.Json.Serialization;
using TE21B_RestAPI;

public class Pokemon
{
  [JsonPropertyName("id")]
  public int Id { get; set; }

  [JsonPropertyName("name")]
  public string Name { get; set; }

  [JsonPropertyName("weight")]
  public int Weight { get; set; }

  public PokemonSpecies species { get; set; }
}
