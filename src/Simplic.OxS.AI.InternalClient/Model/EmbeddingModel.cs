namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Contains embedding settings
/// </summary>
public class EmbeddingModel
{
    /// <summary>
    /// Gets or sets whether disabling the embedding model
    /// </summary>
    public bool Disable { get; set; } = false;

    /// <summary>
    /// Gets or sets the data type (null/empty string will search everywhere)
    /// </summary>
    public string DataType { get; set; } = "";

    /// <summary>
    /// Gets or sets the used documents (count)
    /// </summary>
    public int Count { get; set; } = 5;
}