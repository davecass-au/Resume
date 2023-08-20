using Microsoft.AspNetCore.Components;
using Resume.Extensions;
using System.Net.Http.Json;
using System.Text.Json;

namespace Resume.Pages
{
    public class BasePage<T> : ComponentBase
    {       
        [Inject]
        HttpClient? Client { get; set; } 

        public List<T>? Data = new();

        protected virtual string? DataFileName { get; }

        protected override async Task OnInitializedAsync()
        {
            


            if (Client != null)
            {
                try
                {
                    // TODO Custom converter to handle dates
                    Data = await Client.GetFromJsonAsync<List<T>>($"data/{DataFileName}.json");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }            
        }
    }

    
}
