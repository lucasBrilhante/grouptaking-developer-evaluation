using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;


/// <summary>
/// Represents the response returned after successfully deleting a new product.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly deleted product,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class DeleteProductResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly deleted product.
    /// </summary>
    /// <value>A GUID that uniquely identifies the deleted product in the system.</value>
    public Guid? Id { get; set; }
    /// <summary>
    /// Gets or sets the Title of the product to be deleted.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Price of the product to be deleted.
    /// </summary>
    public double Price { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Description of the product to be deleted.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Category of the product to be deleted.
    /// </summary>
    public ProductCategory Category { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Image of the product to be deleted.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the RatingCount of the product to be deleted.
    /// </summary>
    public int RatingCount { get; set; } = 0;

    /// <summary>
    /// Gets or sets the RatingStars of the product to be deleted.
    /// </summary>
    public float RatingStars { get; set; } = 0;
}

