using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace konzolos_pizza_futar_vizsgaszeru
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<Api> api = new List<Api>();
            api = await futarNyilvantartas();
            feladat1();
            feladat2();
            feladat3();
            Console.ReadLine();
        }

        private static void feladat3()
        {
            Console.WriteLine("\nKézbesített összes érték: ");
        }

        private static void feladat2()
        {
            Console.WriteLine("\nLegkisebb értékben értékesítő futár nevét írja ki: ");
        }

        private static void feladat1()
        {
            Console.WriteLine("Futárok adatai: ");
        }

        private static async Task<List<Api>> futarNyilvantartas()
        {
            List<Api> api = new List<Api>();
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/pizza_futar_vizsgaszeru/index.php?futarok");
            var response = await client.SendAsync(request);
            if(response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                api = Api.FromJson(jsonString).ToList();
            }
            return api;
        }
    }
}
