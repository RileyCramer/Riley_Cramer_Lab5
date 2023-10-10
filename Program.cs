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

            List<Thing> Results = new List<Thing>();

            Spells g;
            //Spells spell = new Spells();

            Console.WriteLine("What part of the DND API would you like to see?(do this part in lower case)");
            string answer = Console.ReadLine(); 
            Console.WriteLine("If you want to look for a specific thing in this class you can input it here (if not just hit enter)");
            string answer2 = Console.ReadLine();    
            using var httpClient = new HttpClient();
            string apiUrl = $"https://www.dnd5eapi.co/api/{answer}";

            //var test = JsonConvert.DeserializeObject<List<Spells>>(apiUrl);
            if (answer2 == null)
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);

                        //  dynamic item = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                        // Console.WriteLine(item.name);
                        Console.WriteLine("\n\n\n\n");
                        JsonSerializerOptions options = new JsonSerializerOptions()
                        { PropertyNameCaseInsensitive = true };

                        g = JsonSerializer.Deserialize<ApiProject.Spells>(content, options);

                        //Results.Add(g);

                        // Thing thingy = JsonConvert.DeserializeObject<Thing>(content);

                        //results.Add();

                        // Console.WriteLine($"Thingy: {thingy.ToString()}");

                        Console.WriteLine("\n\n\n\n");

                        foreach (var r in g.Results.Where(n => n.Name == answer2))
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

            }
            else
            {


                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);

                        //  dynamic item = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                        // Console.WriteLine(item.name);
                        Console.WriteLine("\n\n\n\n");
                        JsonSerializerOptions options = new JsonSerializerOptions()
                        { PropertyNameCaseInsensitive = true };

                        g = JsonSerializer.Deserialize<ApiProject.Spells>(content, options);

                        //Results.Add(g);

                        // Thing thingy = JsonConvert.DeserializeObject<Thing>(content);

                        //results.Add();

                        // Console.WriteLine($"Thingy: {thingy.ToString()}");

                        Console.WriteLine("\n\n\n\n");

                        foreach (var r in g.Results)
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
