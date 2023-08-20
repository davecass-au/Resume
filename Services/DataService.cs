using Resume.Models;
using System.Net.Http.Json;

namespace Resume.Services
{
    public class DataService
    {
        private HttpClient Client { get; set; }
        public ResumeData Resume { get; private set; } = new ResumeData();
        
        public DataService(HttpClient client)
        {
            Client = client;            
        }

        public async Task LoadDataAsync()
        {
            Resume = await Client.GetFromJsonAsync<ResumeData>($"data/resume-data.json") ?? new ResumeData();
        }    
    }
}
