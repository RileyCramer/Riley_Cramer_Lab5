
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace ApiProject
{
    
    class Program 
    {
        
        static async Task Main()
        {
            List<Spells> results = new List<Spells>();
            Spells g;
            //Spells spell = new Spells();
            using var httpClient = new HttpClient();
            string apiUrl = "https://www.dnd5eapi.co/api/spells";
           
            //var test = JsonConvert.DeserializeObject<List<Spells>>(apiUrl);

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);              
                    
                    dynamic item = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                    Console.WriteLine(item.name);
                    Console.WriteLine("\n\n\n\n");
                    JsonSerializerOptions options = new JsonSerializerOptions() 
                    { PropertyNameCaseInsensitive = true };

                    //g = JsonSerializer.Deserialize<ApiProject.Spells>(content, options);

                    Thing thingy = JsonConvert.DeserializeObject<Thing>(content);

                    //results.Add();

                    Console.WriteLine($"Thingy: {thingy.ToString()}");

                    Console.WriteLine("\n\n\n\n");

                    foreach (var r in results)
                    {
                        Console.WriteLine(r.ToString());
                    }

                    // g contains a list of Thing objects called Results
                }

                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Request Error: {e.Message}");
            }
            
          
            //Console.WriteLine("\n\n\n\n");


                // Console.WriteLine(SpellsCall());
        }
        /*
        public static async Task SpellsCall()
    {
        // sending our request to https://www.dnd5eapi.co/api/Spellss/{index}

        // json for all of these Spellss
        var SpellsNames = new string[] { "Acid Arrow", "Acid Splash", "Aid", "Animate Objects" };

        // create a HttpClient object to use to send the request
        var client = new HttpClient();

        foreach (var spellsName in SpellsNames)
        {
            // Receive a response and store it in a variable
            // use 'await' when accessing an async method / resource
            HttpResponseMessage response = await client.GetAsync($"https://www.dnd5eapi.co/api/Spells/{spellsName}");

            // store body of the response in a variable (this is our json)
            string json = await response.Content.ReadAsStringAsync();

            // Deserialize = pulling a .NET object out of json
            // Serialize = create json from a .NET object

            // capitalization of properties doesn't matter with this option, as long as the prop names
            // match the json keys
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            Spells spells = System.Text.Json.JsonSerializer.Deserialize<Spells>(json, options);
            Console.WriteLine(spells + "\n");
        }
        */
    }
    
}