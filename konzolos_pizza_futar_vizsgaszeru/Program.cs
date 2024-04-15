using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using konzolos_pizza_futar_vizsgaszeru;

namespace konzolos_pizza_futar_vizsgaszeru
{
    internal class Program
    {
        static Api api = null;
        static async Task Main(string[] args)
        {
            int fazon = 0;
            string fnev = "fnev";
            string ftel = "ftel";
            await futarNyilvantartas(fazon, ftel, fnev);
            Console.WriteLine($"{api.Fazon.ToString().Length}. Futár azonosító: {fazon} + Futár neve: {fnev} + Futár telefonszám: {ftel}");
            /*Console.WriteLine($"{api.Fnev.ToSting()}. Legkisebb értékben értékesítő futár nevét írja ki: ");
            Console.WriteLine($"{api.Ftel.ToSting()}. Mennyi a futárok által kézbesített összes érték: ");*/
            Console.ReadLine();
        }
     
        private static async Task<List<Api>> futarNyilvantartas(string fazon, string fnev, string ftel)
        {
            List<Api> api = new List<Api>();
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost/pizza_futar_vizsgaszeru/index.php?futarok/ + {fazon} + {fnev} + {ftel}");
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
