using Inventory.Api.Contracts.Items.Requests;
using Inventory.Api.Contracts.Items.Responses;
using Inventory.Application.Models;

namespace Inventory.Api.Mapping
{
    public static class ContractMapping
    {
        public static ItemResponse MapToResponse(this Item item)
        {
            return new ItemResponse()
            {
                Id = item.Id,
                PurchaseDate = item.PurchaseDate,
                Quantity = item.Quantity,
                PurchasePrice= item.PurchasePrice,
                SoldDate = item.SoldDate,
                IsOnSale= item.IsOnSale,
                Name = item.Name,
                CurrentOrFinalPrice= item.CurrentOrFinalPrice,
                Description= item.Description
            };
        }

    public static Item MapToItem(this CreateItemRequest request)
    {
            return new Item()
            {
                Name = request.Name,
                Description = request.Description,
                CurrentOrFinalPrice = request.CurrentOrFinalPrice,
                Quantity = request.Quantity,
                PurchasePrice = request.PurchasePrice,
                PurchaseDate = request.PurchaseDate,
                SoldDate = request.SoldDate,
                IsOnSale = request.IsOnSale,
                Notes = request.Notes,
                isActive = request.isActive
                
            };
    }
     public static GetAllItemsResponse MapToResponse(this IEnumerable<Item> items)
        {
            return new GetAllItemsResponse()
            {
                Items = items.Select(i => i.MapToResponse())
            };
        }

    }
}
