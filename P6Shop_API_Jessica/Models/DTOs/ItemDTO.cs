namespace P6Shop_API_Jessica.Models.DTOs
{
    public class ItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string MainImageUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? SKU { get; set; }
        public string? ManufacturerNumber { get; set; }
        public string? UPC { get; set; }
        public bool? IsActive { get; set; }
        public int IDstore { get; set; }
        public int IDCurrency { get; set; }

    }
}
