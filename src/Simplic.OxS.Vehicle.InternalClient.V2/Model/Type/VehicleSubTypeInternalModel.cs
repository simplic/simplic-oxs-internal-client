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
    /// Gets or sets the display key.
    /// </summary>
    public string DisplayKey { get; set; }

    /// <summary>
    /// Gets or sets a list of alias names.
    /// This could be an internal name from a third party system like webfleet.
    /// </summary>
    public IList<string>? Alias { get; set; }
}
