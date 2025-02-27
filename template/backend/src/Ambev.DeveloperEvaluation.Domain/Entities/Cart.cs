using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Cart: BaseEntity
{
    /// <summary>
    /// Gets the product's title.
    /// Must not be null or empty.
    /// </summary>
    public User User { get; }
    public Guid UserId { get; }

    /// <summary>
    /// Gets the product's selling price.
    /// Must not be zero or negative.
    /// </summary>
    //public DateTime Date { get; set; }
    /// <summary>
    /// Gets the product's description, with more information.
    /// Must not be null or empty.
    /// </summary>
    public Product[] Products { get; set; }
   

}