namespace Simplic.OxS.Accounting.InternalClient;

/// <summary>
/// Represents a cost object assignment of a billing line.
/// </summary>
public class CostObjectAssignmentInternalModel
{
    /// <summary>
    /// Gets or sets the cost center to assign.
    /// </summary>
    public Guid CostCenterId { get; set; }

    /// <summary>
    /// Gets or sets the percentage to assign.
    /// </summary>
    public decimal Percentage { get; set; }
}