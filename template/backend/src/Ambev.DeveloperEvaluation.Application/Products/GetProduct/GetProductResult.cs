using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;


/// <summary>
/// Represents the response returned after successfully creating a new product.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created product,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class GetProductResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created product.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created product in the system.</value>
    public Guid? Id { get; set; }
    /// <summary>
    /// Gets or sets the Title of the product to be created.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Price of the product to be created.
    /// </summary>
    public double Price { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Description of the product to be created.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Category of the product to be created.
    /// </summary>
    public ProductCategory Category { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Image of the product to be created.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the RatingCount of the product to be created.
    /// </summary>
    public int RatingCount { get; set; } = 0;

    /// <summary>
    /// Gets or sets the RatingStars of the product to be created.
    /// </summary>
    public float RatingStars { get; set; } = 0;
}

