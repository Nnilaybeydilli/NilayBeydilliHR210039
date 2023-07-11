using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using ETicaret.EntityLayer.Concretes;
using System.Linq.Expressions;

namespace Eticaret.Web.Services
{
    public class ShoppingCartApiService
    {

        private readonly HttpClient _httpClient;
        public ShoppingCartApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomResponseDto<ShoppingCart>> AddAsync(ShoppingCart entity)
        {
            var response = await _httpClient.PostAsJsonAsync("ShoppingCart/Add", entity);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ShoppingCart>>();

            return responseBody;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"ShoppingCart/Delete/{id}");

            return response.IsSuccessStatusCode;
        }



        public Task<CustomResponseDto<ShoppingCart>> GetAsync(Expression<Func<ShoppingCart, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<List<ShoppingCart>>> GetListAsync(Expression<Func<ShoppingCart, bool>> filter = null)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ShoppingCart>>>("ShoppingCart/GetList");

            return response;
        }

        public async Task<CustomResponseDto<ShoppingCart>> GetModelByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<ShoppingCart>>($"ShoppingCart/GetById/{id}");

            return response;
        }

        public async Task<bool> UpdateAsync(ShoppingCart entity)
        {
            var response = await _httpClient.PutAsJsonAsync("ShoppingCart/Update", entity);

            return response.IsSuccessStatusCode;
        }
    }
}
