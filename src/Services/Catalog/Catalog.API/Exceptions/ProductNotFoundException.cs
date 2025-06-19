using BuildingBlocks.Exceptions;

namespace Catalog.API.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException() : base("Products not found!")
        {
            
        }
        public ProductNotFoundException(Guid Id) : base("Product", Id)
        {
        }
    }
}
