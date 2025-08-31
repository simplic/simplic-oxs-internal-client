namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Represents a conversation message
/// </summary>
public class MessageModel
{
    /// <summary>
    /// Gets or sets the message id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the sender. Ox user id, null for llm model
    /// </summary>
    public Guid? SenderId { get; set; }

    /// <summary>
    /// Gets or sets the datetime the message was created
    /// </summary>
    public DateTime DateTime { get; set; }

    /// <summary>
    /// Gets or sets the message body
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Gets or sets an optional model reference for the message
    /// </summary>
    public string? ModelReference { get; set; }

    /// <summary>
    /// Gets or sets the message type
    /// </summary>
    public MessageType Type { get; set; }
}