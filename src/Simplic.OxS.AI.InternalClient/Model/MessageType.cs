namespace Simplic.OxS.AI.InternalClient.Model;

/// <summary>
/// Represents a message type
/// </summary>
public enum MessageType
{
    /// <summary>
    /// Message source is user
    /// </summary>
    User = 0,

    /// <summary>
    /// Message source is generated context information
    /// </summary>
    Context = 1,

    /// <summary>
    /// Message generated from an LLM
    /// </summary>
    LLM = 2
}
