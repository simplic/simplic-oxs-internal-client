namespace Simplic.OxS.Reporting.InternalClient.Model;

/// <summary>
/// Response of a render-and-upload operation containing the blob id and the mail template id.
/// </summary>
public class RenderAndUploadReportResponse
{
    /// <summary>
    /// Gets or sets the id of the uploaded blob on the CDN.
    /// </summary>
    public Guid BlobId { get; set; }

    /// <summary>
    /// Gets or sets the mail template of the used send option.
    /// </summary>
    public string MailTemplate { get; set; }
}

