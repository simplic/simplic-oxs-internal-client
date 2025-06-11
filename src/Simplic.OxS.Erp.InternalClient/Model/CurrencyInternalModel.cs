namespace Simplic.OxS.Erp.InternalClient.Model;

/// <summary>
/// Represents an internal currency model
/// </summary>
public class CurrencyInternalModel
{
    /// <summary>
    /// Gets or sets the id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the number
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the short name
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Gets or sets the symbol representing the currency
    /// </summary>
    public string Symbol { get; set; }
}