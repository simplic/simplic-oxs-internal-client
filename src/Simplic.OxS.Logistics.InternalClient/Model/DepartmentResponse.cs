namespace Simplic.OxS.Logistics.InternalClient.Model;

/// <summary>
/// Response model for <see cref="Department"/>.
/// </summary>
public class DepartmentResponse
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the order id.
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Gets or sets the hex color.
    /// </summary>
    public string HexColor { get; set; } = "";
}