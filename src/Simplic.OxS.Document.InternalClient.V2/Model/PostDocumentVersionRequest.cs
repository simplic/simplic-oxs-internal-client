using System.ComponentModel.DataAnnotations;

namespace Simplic.OxS.Document.InternalClient.V2.Model;

/// <summary>
/// Request model for posting a <see cref="DocumentVersion"/>.
/// </summary>
public class PostDocumentVersionRequest
{
    /// <summary>
    /// Gets or sets the url of the blob.
    /// </summary>
    [Required]
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the file extension.
    /// </summary>
    public string FileExtension { get; set; } = "";

    /// <summary>
    /// Gets or sets the mime type.
    /// </summary>
    [Required]
    public string MimeType { get; set; } = "";

    /// <summary>
    /// Gets or sets the comment for this version.
    /// </summary>
    public string Comment { get; set; } = "";

    /// <summary>
    /// Gets or sets the size of the blob.
    /// </summary>
    [Required]
    public long FileSize { get; set; }
}
