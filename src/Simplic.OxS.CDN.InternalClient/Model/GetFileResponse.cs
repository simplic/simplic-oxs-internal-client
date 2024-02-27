namespace Simplic.OxS.CDN.InternalClient;

/// <summary>
/// Response model for downloading a file.
/// </summary>
public class GetFileResponse
{
    /// <summary>
    /// Gets or sets the file stream.
    /// </summary>
    public Stream FileStream { get; set; }
    
    /// <summary>
    /// Gets or sets the content type.
    /// </summary>
    public string ContentType { get; set; }
    
    /// <summary>
    /// Gets or sets the file download name.
    /// </summary>
    public string FileDownloadName { get; set; }
}