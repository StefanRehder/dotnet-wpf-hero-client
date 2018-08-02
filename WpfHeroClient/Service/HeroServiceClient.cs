using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using WpfHeroClient.Models;

namespace WpfHeroClient.Service
{
    class HeroServiceClient
    {
        private static HttpClient client;

        public static void ConfigureClient()
        {
            string url = "http://localhost:8210";
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static IEnumerable<Hero> GetHeroes()
        {
            HttpResponseMessage response = client.GetAsync("/hero/list").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Hero>>().Result; // executed synchronously
            }
            else
            {
                // TODO: Inform that get request failed
                return null;
            }
        }

        public static Hero GetHero(string name)
        {
            HttpResponseMessage response = client.GetAsync($"/hero/{name}").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Hero>().Result; // executed synchronously
            }
            else
            {
                // TODO: Inform that get request failed
                return null;
            }
        }

        public static void CreateOrUpdateHero(Hero hero)
        {
            HttpResponseMessage response = client.PutAsJsonAsync<Hero>("/hero", hero).Result; // executed synchronously
            if (!response.IsSuccessStatusCode)
            {
                // TODO: Inform that put request failed
            }
        }

        public static void DeleteHero(string name)
        {
            HttpResponseMessage response = client.DeleteAsync($"/hero/{name}").Result; // executed synchronously
            if (!response.IsSuccessStatusCode)
            {
                // TODO: Inform that delete request failed
            }
        }
    }
}
