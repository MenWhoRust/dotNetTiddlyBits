namespace ImplicitExplicitConversionShenanigans.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Even though it is possible to do this
        // It is bad practice
        // A Domain Entity should not be responsible for conversions
        // between itself and its DTOs
        public static implicit operator ProductDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public static implicit operator Product(ProductDto productDto)
        {
            return new Product
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price
            };
        }
    }
}