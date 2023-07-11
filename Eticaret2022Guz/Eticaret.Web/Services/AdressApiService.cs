using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using System.Linq.Expressions;

namespace Eticaret.Web.Services
{
    public class AdressApiService
    {

        private readonly HttpClient _httpClient;
        public AdressApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomResponseDto<Adress>> AddAsync(Adress entity)
        {
            var response = await _httpClient.PostAsJsonAsync("Adress/Add", entity);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<Adress>>();

            return responseBody;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"Adress/Delete/{id}");

            return response.IsSuccessStatusCode;
        }

       

        public Task<CustomResponseDto<Adress>> GetAsync(Expression<Func<Adress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<List<Adress>>> GetListAsync(Expression<Func<Adress, bool>> filter = null)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<Adress>>>("Adress/GetList");

            return response;
        }

        public async Task<CustomResponseDto<Adress>> GetModelByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<Adress>>($"Adress/GetById/{id}");

            return response;
        }

        public async Task<bool> UpdateAsync(Adress entity)
        {
            var response = await _httpClient.PutAsJsonAsync("Adress/Update", entity);

            return response.IsSuccessStatusCode;
        }
    }
}
