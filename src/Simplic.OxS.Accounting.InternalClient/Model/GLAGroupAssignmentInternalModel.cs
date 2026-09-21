namespace Simplic.OxS.Accounting.InternalClient;

/// <summary>
/// Represents a GLA group assignment of a billing line. Unlike cost center/cost object
/// assignments, GLA group assignments are not percentage-split.
/// </summary>
public class GLAGroupAssignmentInternalModel
{
    /// <summary>
    /// Gets or sets the GLA group to assign.
    /// </summary>
    public Guid GLAGroupId { get; set; }
}