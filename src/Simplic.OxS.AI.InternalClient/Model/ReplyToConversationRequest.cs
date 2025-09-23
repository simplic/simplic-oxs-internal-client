namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Model for interacting with a conversation
/// </summary>
public class ReplyToConversationRequest
{
    /// <summary>
    /// Gets or sets the conversation id
    /// </summary>
    public Guid ConversationId { get; set; }

    /// <summary>
    /// Gets or sets the initial message
    /// </summary>
    public string? Message { get; set; }
}
