namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Represents a conversation context
/// </summary>
public class ConversationContextModel
{
    /// <summary>
    /// Gets or sets the id of the referenced context.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the context system
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a message, that represents a manual context.
    /// If this is set, togehter with Name and Id, both will be passed to the AI
    /// </summary>
    public string? ContextMessage { get; set; }
}
