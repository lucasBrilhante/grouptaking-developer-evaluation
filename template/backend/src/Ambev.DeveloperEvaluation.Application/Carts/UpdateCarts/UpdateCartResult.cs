namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{

    /// <summary>
    /// Represents the response returned after successfully updating a new cart.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly updated cart,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class UpdateCartResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly updated cart.
        /// </summary>
        /// <value>A GUID that uniquely identifies the updated cart in the system.</value>
        public Guid Id { get; set; }
    }
}
