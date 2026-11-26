namespace Simplic.OxS.Accounting.InternalClient;

/// <summary>
/// Represents a cost center assignment of a billing line.
/// </summary>
public class CostCenterAssignmentInternalModel
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