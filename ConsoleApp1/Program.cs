using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string endpoint = "https://retoolapi.dev/OEDUXm/member";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(endpoint);
            var jsonBeerkezett = await response.Content.ReadAsStringAsync();
            var jatekosok = JsonSerializer.Deserialize<List<Jatekos>>(jsonBeerkezett);

            Console.WriteLine($"Elemek száma: {jatekosok.Count}"); //első feladat

            //harmadik feladat
            Dictionary<string, int> osszegzes = new Dictionary<string, int>();
            foreach (Jatekos jatekos in jatekosok)
            {
                if (osszegzes.ContainsKey(jatekos.Interest))
                {
                    osszegzes[jatekos.Interest]++;
                }
                else
                {
                    osszegzes.Add(jatekos.Interest, 1);
                }
            }
            Console.WriteLine("Érdeklődési körök per tagok száma:");
            foreach (var elem in osszegzes)
            {
                Console.WriteLine($"{elem.Key}: {elem.Value} tag");
            }
        }
        class Jatekos
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("entry")]
            public string Entry { get; set; }
            [JsonPropertyName("rating")]
            public int Rating { get; set; }
            [JsonPropertyName("fullname")]
            public string Fullname { get; set; }
            [JsonPropertyName("interest")]
            public string Interest { get; set; }
        }
    }
}
