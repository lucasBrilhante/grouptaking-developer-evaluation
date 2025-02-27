﻿using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart;


/// <summary>
/// Represents the response returned after successfully retrieving a new cart.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly retrieved cart,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class GetCartResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly retrieved cart.
    /// </summary>
    /// <value>A GUID that uniquely identifies the retrieved cart in the system.</value>
    public Guid? Id { get; set; }
   
}

