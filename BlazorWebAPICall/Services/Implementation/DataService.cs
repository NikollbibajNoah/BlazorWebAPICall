using System.Net;
using System.Net.Http.Json;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace BlazorWebAPICall.Services.Implementation
{
    public class DataService(HttpClient http) : IDataService
    {
        public async Task<StoreItem[]> GetStoreItems(string Endpoint)
        {
            return await http.GetFromJsonAsync<StoreItem[]>(Endpoint);
        }

        public async Task<StoreItem> GetStoreItemById(string Endpoint, int Id)
        {
            return await http.GetFromJsonAsync<StoreItem>(Endpoint + "/" + Id);
        }

        public async Task<HttpResponseMessage> CreateStoreItem(string Endpoint, StoreItem NewItem)
        {
            return await http.PostAsJsonAsync<StoreItem>(Endpoint, NewItem);
        }

        public async Task<HttpResponseMessage> UpdateStoreItem(string Endpoint, int Id, StoreItem UpdatedItem)
        {
            return await http.PutAsJsonAsync<StoreItem>(Endpoint + "/" + Id, UpdatedItem);
        }

        public async Task<StoreItem> DeleteStoreItem(string Endpoint, int Id)
        {
            return await http.DeleteFromJsonAsync<StoreItem>(Endpoint + "/" + Id);
        }
    }
}
