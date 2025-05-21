namespace Simplic.OxS.Vehicle.InternalClient;

/// <summary>
/// Represents an internal vehicle type.
/// </summary>
public class VehicleTypeInternalModel
{
    /// <summary>
    /// Gets or sets the id of the vehicle type.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the vehicle type name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the display name.
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the display key.
    /// </summary>
    public string? DisplayKey { get; set; }

    /// <summary>
    /// Gets or sets the vehicle sub types.
    /// </summary>
    public IList<VehicleSubTypeInternalModel> VehicleSubType { get; set; }
}