﻿using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Product: BaseEntity
{
    /// <summary>
    /// Gets the product's title.
    /// Must not be null or empty.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Gets the product's selling price.
    /// Must not be zero or negative.
    /// </summary>
    public double Price { get; set; }
    /// <summary>
    /// Gets the product's description, with more information.
    /// Must not be null or empty.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Gets the product's category
    /// Must be one of the predetermined categories and cannot be zero.
    /// </summary>
    public ProductCategory Category { get; set; }
    /// <summary>
    /// Gets the product's image url.
    /// Must not be null or empty.
    /// </summary>
    public string Image { get; set; }
    /// <summary>
    /// Gets the product's number of times it was rated.
    /// Cannot be negative.
    /// </summary>
    public int RatingCount { get; set; }
    /// <summary>
    /// Gets the product's rating considering all the ratings.
    /// Cannot be negative or bigger than 5.
    /// </summary>
    public float RatingStars { get; set; }

    public List<Cart> Carts { get; set; }


}

