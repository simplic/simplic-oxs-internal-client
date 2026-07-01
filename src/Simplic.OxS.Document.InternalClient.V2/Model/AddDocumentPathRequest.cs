using System.ComponentModel.DataAnnotations;

namespace Simplic.OxS.Document.InternalClient.V2.Model;

/// <summary>
/// Add document path to existing document
/// </summary>
public class AddDocumentPathRequest
{
    /// <summary>
    /// Gets or sets the id of the target. E.g. a shipment, contact, ...
    /// </summary>
    [Required]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the path. E.g. shipment, contact, ...
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets a list of attributes, attached to this document path
    /// </summary>
    public IDictionary<string, string>? Attributes { get; set; }
}
