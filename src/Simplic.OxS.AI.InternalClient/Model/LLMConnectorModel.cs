namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Contains the settings for the llm connector
/// </summary>
public class LLMConnectorModel
{
    /// <summary>
    /// Gets or sets whether disabling the embedding model
    /// </summary>
    public bool Disable { get; set; } = true;
}