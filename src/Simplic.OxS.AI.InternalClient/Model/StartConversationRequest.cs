using System.ComponentModel.DataAnnotations;

namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Model for starting conversation
/// </summary>
public class StartConversationRequest
{
    /// <summary>
    /// Gets or sets the LLM model, e.g. gpt-4o-mini, gpt-4
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Gets or sets the conversation context.
    /// </summary>
    public ConversationContextModel? Context { get; set; }

    /// <summary>
    /// Gets or sets the embedding model settings
    /// </summary>
    public EmbeddingModel? Embedding { get; set; } = new EmbeddingModel();

    /// <summary>
    /// Gets or sets the llm connector settings/instructions
    /// </summary>
    public LLMConnectorModel Connector { get; set; } = new LLMConnectorModel();

    /// <summary>
    /// Gets or sets the initial message
    /// </summary>
    public string? Message { get; set; }
}
