namespace Simplic.OxS.Telematic.InternalClient.Model;

/// <summary>
/// Represents the loading aid type internal model.
/// </summary>
public class TelematicWorkflow
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
    /// Gets or sets the value.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Gets or sets the descrition.
    /// </summary>
    public string Description { get; set; }
}