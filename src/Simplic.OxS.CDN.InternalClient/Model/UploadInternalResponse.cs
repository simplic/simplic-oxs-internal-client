using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.CDN.InternalClient;

/// <summary>
/// Response model for a single upload.
/// </summary>
public class UploadInternalResponse
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the size in bytes.
    /// </summary>
    public long Size { get; set; }

    /// <summary>
    /// Gets or sets the time of upload.
    /// </summary>
    public DateTime TimeOfUpload { get; set; }

    /// <summary>
    /// Gets or sets the blob id.
    /// </summary>
    public Guid BlobId { get; set; }
}