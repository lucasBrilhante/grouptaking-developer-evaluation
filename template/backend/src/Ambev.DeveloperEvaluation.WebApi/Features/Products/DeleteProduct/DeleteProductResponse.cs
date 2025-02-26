using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// API response model for CreateProduct operation
/// </summary>
public class DeleteProductResponse
{
    /// <summary>
    /// The unique identifier of the created product
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Gets or sets the Title of the product to be created. Must not be null or empty and have length between 3 and 100. 
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Price of the product to be created. Must be higher than 0.
    /// </summary>
    public double Price { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Description of the product to be created. Must not be null or empty and have length between 3 and 200. 
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Category of the product to be created. Must be one of the existing categories.
    /// </summary>
    public ProductCategory Category { get; set; } = 0;

    /// <summary>
    /// Gets or sets the Image of the product to be created. Must not be null or empty and have length between 3 and 1000. 
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the RatingCount of the product to be created. Must be higher or equal to 0.
    /// </summary>
    public int RatingCount { get; set; } = 0;

    /// <summary>
    /// Gets or sets the RatingStars of the product to be created. Must be 0 or higher and smaller or equal to 5.
    /// </summary>
    public float RatingStars { get; set; } = 0;
}

