namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class VehicleEmissionClassInternalModel
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
    /// Gets or sets whether the emission class is a toll emission class.
    /// </summary>
    public bool IsTollEmissionClass { get; set; }
}