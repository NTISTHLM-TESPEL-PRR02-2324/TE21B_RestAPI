using System.Text.Json;
using RestSharp;
using System.IO;

RestClient client = new("https://pokeapi.co/api/v2/");
Console.WriteLine("Which pokemon?");
string pokeName = Console.ReadLine();
RestRequest request = new($"pokemon/{pokeName}");

RestResponse response = client.GetAsync(request).Result;

if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
  Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);

  Console.WriteLine(p.Weight);
}
else
{
  Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);
// File.WriteAllText("pokemon.json", response.Content);

Console.ReadLine();