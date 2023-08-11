namespace Simplic.OxS.Vehicle.InternalClient.Model;

public class LoadingSlotInternalModel
{
    /// <summary>
    /// Gets or sets the id of the loading slot.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the name of the loading slot.
    /// <para>
    /// This should be used as a short human readable identifier for the loading slot.
    /// </para>
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// <para>
    /// This could be used to notate the size or exact location of the loading slot.
    /// </para>
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the id of the resource this loading slot is assigned to.
    /// </summary>
    public Guid ResourceId { get; set; }
}
