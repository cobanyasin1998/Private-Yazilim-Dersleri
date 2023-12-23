using ETicaretAPI.Application.ViewModels.Baskets;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Abstractions.Services
{
    public interface  IBasketService
    {
        public Task<List<BasketItem>> GetBasketItemAsync();
        public Task AddItemToBasketAsync(VM_Create_Basket_Item basketItem);

        public Task UpdateQuantityAsync(VM_Update_BasketItem basketItem);

        public Task RemoveBasketItemAsync(string basketItemId);

        public Basket? GetUserActiveBasket { get; }




    }
}
