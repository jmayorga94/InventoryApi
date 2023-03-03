namespace Inventory.Api.Contracts.Items.Responses
{
    public class GetAllItemsResponse
    {
        public IEnumerable<ItemResponse> Items { get; set; } = Enumerable.Empty<ItemResponse>();

    }
}
