namespace Simplic.OxS.Article.InternalClient.Model;

/// <summary>
/// Represents a lightweight reference to a tax rate.
/// </summary>
public class TaxRateSubsetInternalModel
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the numeric identifier.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string? Name { get; set; }
}