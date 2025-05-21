namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class VehicleStatusInternalModel
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
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
    /// Gets or sets whether it is selectable.
    /// </summary>
    public bool? IsSelectable { get; set; }

    /// <summary>
    /// Gets or sets whether it is deleted.
    /// </summary>
    public bool IsDeleted { get; set; }
}
