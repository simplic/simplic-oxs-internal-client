namespace Simplic.OxS.Identity.InternalClient;

/// <summary>
/// Response to check whether an api key is still valid.
/// </summary>
public class ValidateApiKeyResponse
{
    /// <summary>
    /// Gets or sets whether the key is valid.
    /// </summary>
    public bool Valid { get; set; }

    /// <summary>
    /// Gets or sets the id of the user that created the key.
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Gets or sets the id of the organization the key is valid in.
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Gets or sets when the key expires.
    /// </summary>
    public DateTime? ExpiresAt { get; set; }
}