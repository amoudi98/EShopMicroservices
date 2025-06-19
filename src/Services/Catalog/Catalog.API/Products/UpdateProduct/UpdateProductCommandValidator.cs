namespace Catalog.API.Products.UpdateProduct;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Product ID is required");
        RuleFor(x => x.Name).NotEmpty().Length(2, 150).WithMessage("Name is required");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Name is required");
    }
}
