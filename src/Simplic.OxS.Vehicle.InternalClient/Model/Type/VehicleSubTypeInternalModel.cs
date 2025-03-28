namespace Simplic.OxS.Vehicle.InternalClient;

/// <summary>
/// Represents an internal vehicle sub type model.
/// </summary>
public class VehicleSubTypeInternalModel
{
    /// <summary>
    /// Gets or sets the sub type id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the sub type name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the display name.
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the alias name from webfleet or others.
    /// </summary>
    public string? Alias { get; set; }
}
