using ApiAiBlazorLab.Models;
using System.Net.Http.Json;

namespace ApiAiBlazorLab.Services {
    public class CatFactService {

        private readonly HttpClient _http;

        public CatFactService(HttpClient http) {
            _http = http;
        } // End method

        public async Task<string> GetRandomFactAsync() {
            var url = "https://catfact.ninja/fact";
            var json = await _http.GetFromJsonAsync<CatFact>(url);

            return json?.fact ?? "No cat fact received.";

        } // End method

    } // End class

} // End namespace
