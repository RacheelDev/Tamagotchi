using Newtonsoft.Json;
using RestSharp;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Obter a lista de espécies de Pokémons 
        // teste
        var client = new RestClient("https://pokeapi.co/api/v2/pokemon-species/");
        var request = new RestRequest(Method.GET);
        IRestResponse response = client.Execute(request);
    }
}