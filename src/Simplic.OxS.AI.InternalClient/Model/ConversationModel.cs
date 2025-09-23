namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Represents a LLM conversation
/// </summary>
public class ConversationModel
{
    /// <summary>
    /// Gets or sets the conversation id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the user the llm conversation is attached to
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Gets or sets the LLM model, e.g. gpt-4o-mini, gpt-4
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Gets or sets the conversation context.
    /// </summary>
    public ConversationContextModel? Context { get; set; }

    /// <summary>
    /// Gets or sets the messages inside the conversation
    /// </summary>
    public IList<MessageModel> Messages { get; set; } = new List<MessageModel>();

    /// <summary>
    /// Gets or sets the creation date time
    /// </summary>
    public DateTime CreateDateTime { get; set; }
}
