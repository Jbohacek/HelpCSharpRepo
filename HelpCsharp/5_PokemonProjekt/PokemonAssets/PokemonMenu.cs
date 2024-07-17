using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace _5_PokemonProjekt.PokemonAssets
{
    public static class PokemonMenu
    {

        public enum PokemonType
        {
            Normal = 1,
            Fighting = 2,
            Flying = 3,
            Poison = 4,
            Ground = 5,
            Rock = 6,
            Bug = 7,
            Ghost = 8,
            Steel = 9,
            Fire = 10,
            Water = 11,
            Grass = 12,
            Electric = 13,
            Psychic = 14,
            Ice = 15,
            Dragon = 16,
            Dark = 17,
            Fairy = 18,
            Stellar = 19,
            Unknown = 10001
        }



        public static string GetByType(PokemonType type)
        {

            return string.Join(", ", Task.Run(() => GetDruh(type)).GetAwaiter().GetResult());
        }

        public static string GetTypes()
        {
            return string.Join(", ", Enum.GetNames(typeof(PokemonType)));
        }

        public static void OpenWebsite(string pokemonName)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://veekun.com/dex/pokemon/" + pokemonName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        private static async Task<List<string>> GetDruh(PokemonType type)
        {

            string url = @$"https://pokeapi.co/api/v2/type/{(int)type}/";


            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Root? myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseBody);


            List<string> pokemonNames = myDeserializedClass.pokemon.Select(x => x.pokemon.name).ToList();


            return pokemonNames;
        }



        private static int GetNumberFromUrl(string url)
        {
            Regex regex = new Regex(@"/(\d+)/?$");
            Match match = regex.Match(url);

            if (match.Success)
            {

                return int.Parse(match.Groups[1].Value);
            }
            else
            {
                throw new ArgumentException("URL does not contain a number.");
            }
        }
    }
}
