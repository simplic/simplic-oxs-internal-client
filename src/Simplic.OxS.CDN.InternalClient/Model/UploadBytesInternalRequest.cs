using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.OxS.CDN.InternalClient;

/// <summary>
/// Request model for uploading raw byte data.
/// </summary>
public class UploadBytesInternalRequest
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [Required]
    public byte[]? Data { get; set; }

    /// <summary>
    /// Gets or sets the file name.
    /// </summary>
    [Required]
    public string FileName { get; set; } = "";

    /// <summary>
    /// Gets or sets the content type.
    /// Defaults to 'text/plain'.
    /// </summary>
    public string ContentType { get; set; } = "text/plain";
}
