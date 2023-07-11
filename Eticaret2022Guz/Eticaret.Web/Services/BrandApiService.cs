using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using System.Linq.Expressions;

namespace Eticaret.Web.Services
{
    public class BrandApiService
    {

        private readonly HttpClient _httpClient;
        public BrandApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomResponseDto<Brand>> AddAsync(Brand entity)
        {
            var response = await _httpClient.PostAsJsonAsync("Category/Add", entity);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<Brand>>();

            return responseBody;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"Brand/Delete/{id}");

            return response.IsSuccessStatusCode;
        }

       

        public Task<CustomResponseDto<Brand>> GetAsync(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<List<Brand>>> GetListAsync(Expression<Func<Brand, bool>> filter = null)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<Brand>>>("Brand/GetList");

            return response;
        }

        public async Task<CustomResponseDto<Brand>> GetModelByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<Brand>>($"Brand/GetById/{id}");

            return response;
        }

        public async Task<bool> UpdateAsync(Brand entity)
        {
            var response = await _httpClient.PutAsJsonAsync("Brand/Update", entity);

            return response.IsSuccessStatusCode;
        }
    }
}
