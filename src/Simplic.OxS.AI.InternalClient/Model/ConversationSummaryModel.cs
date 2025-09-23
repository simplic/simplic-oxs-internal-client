namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Represents a LLM conversation
/// </summary>
public class ConversationSummaryModel
{
    /// <summary>
    /// Gets or sets the conversation id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the latest message
    /// </summary>
    public MessageModel LastMessage { get; set; }

    /// <summary>
    /// Gets or sets the creation date time
    /// </summary>
    public DateTime CreateDateTime { get; set; }
}
