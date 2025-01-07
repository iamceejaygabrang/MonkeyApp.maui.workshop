using MonkeyApp.maui.nav.Models;
using System.Net.Http.Json;

namespace MonkeyApp.maui.nav.Services
{
    public class MonkeyService
    {
        HttpClient client;
        public MonkeyService()
        {
            client = new HttpClient();
        }
        List<Monkey> monkeyList = new();
        public async Task<List<Monkey>> GetMonkeys()
        {
            if (monkeyList?.Count > 0)
                return monkeyList;

            var url = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            return monkeyList;
        }
    }
}
