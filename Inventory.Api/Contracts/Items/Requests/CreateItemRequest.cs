namespace Inventory.Api.Contracts.Items.Requests
{
    public class CreateItemRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool IsOnSale { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? SoldDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? CurrentOrFinalPrice { get; set; }
        public string Notes { get; set; }
        public bool isActive { get; set; }
    }
}
