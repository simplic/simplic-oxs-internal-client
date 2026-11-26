namespace Simplic.OxS.Accounting.InternalClient;

/// <summary>
/// Base class for billing line resolution configuration internal models.
/// </summary>
/// <typeparam name="TAssignment">Type of the assignment contained in the configuration.</typeparam>
public abstract class ResolutionConfigurationInternalModelBase<TAssignment>
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the billing line context (e.g. tour, shipment) this configuration applies to.
    /// </summary>
    public string BillingLineContext { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this configuration is active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Gets or sets the valid from date.
    /// </summary>
    public DateTime? ValidFrom { get; set; }

    /// <summary>
    /// Gets or sets the valid to date.
    /// </summary>
    public DateTime? ValidTo { get; set; }

    /// <summary>
    /// Gets or sets the assignments of this configuration.
    /// </summary>
    public IList<TAssignment> Assignments { get; set; } = new List<TAssignment>();
}