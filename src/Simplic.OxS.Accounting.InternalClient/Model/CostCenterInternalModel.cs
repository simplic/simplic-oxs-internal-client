namespace Simplic.OxS.Accounting.InternalClient;

/// <summary>
/// Represents an internal costcenter model.
/// </summary>
public class CostCenterInternalModel
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the cost center.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the unique number of the cost center.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the valid from date
    /// </summary>
    public DateTime? ValidFrom { get; set; }

    /// <summary>
    /// Gets or sets the valid to date
    /// </summary>
    public DateTime? ValidTo { get; set; }
}