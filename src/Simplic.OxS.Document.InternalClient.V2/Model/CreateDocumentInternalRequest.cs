using System.ComponentModel.DataAnnotations;

namespace Simplic.OxS.Document.InternalClient.V2.Model;

/// <summary>
/// Request model for posting a <see cref="Document"/>.
/// </summary>
public class CreateDocumentInternalRequest
{
    /// <summary>
    /// Gets or sets the file name.
    /// </summary>
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the datetime.
    /// </summary>
    public DateTime DateTime { get; set; }

    /// <summary>
    /// Gets or sets the version.
    /// </summary>
    [Required]
    public PostDocumentVersionRequest? Version { get; set; }

    /// <summary>
    /// Gets or sets the reference.
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Gets or sets the bar code.
    /// </summary>
    public string? Barcode { get; set; }

    public Guid? PrimaryClassificationId { get; set; }

    /// <summary>
    /// Gets or sets the raw data url. 
    /// </summary>
    public string? RawDataUrl { get; set; }

    /// <summary>
    /// Get or set the raw data provider
    /// </summary>
    public string? RawDataProvider { get; set; }

    /// <summary>
    /// Gets or sets a list od documents paths to add
    /// </summary>
    public IList<AddDocumentPathRequest>? Paths { get; set; } = [];
}
