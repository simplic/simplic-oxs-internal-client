namespace Simplic.OxS.Document.InternalClient.V2.Model;

public class DocumentResponse
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the file name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the datetime.
    /// </summary>
    public DateTime DateTime { get; set; }

    /// <summary>
    /// Gets or sets the versions.
    /// </summary>
    public IEnumerable<DocumentVersionResponse>? Versions { get; set; }

    /// <summary>
    /// Gets or sets the current version.
    /// </summary>
    public DocumentVersionResponse CurrentVersion { get; set; } = new();

    /// <summary>
    /// Gets or sets the reference.
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Gets or sets the bar code.
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Gets or sets the primary classification.
    /// </summary>
    public ClassificationResponse? PrimaryClassification { get; set; }

    /// <summary>
    /// Gets or sets a list of paths, to connect this document with other entities
    /// </summary>
    public IList<DocumentPathResponse> Paths { get; set; } = [];
}

/// <summary>
/// Document path, to connect the document with other entities
/// </summary>
public class DocumentPathResponse
{
    /// <summary>
    /// Gets or sets the id of the target. E.g. a shipment, contact, ...
    /// </summary>
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

public class DocumentVersionResponse
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the version number.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets the url of the blob.
    /// </summary>
    public string Url { get; set; } = "";

    /// <summary>
    /// Gets or sets the file extension.
    /// </summary>
    public string FileExtension { get; set; } = "";

    /// <summary>
    /// Gets or sets the mime type.
    /// </summary>
    public string MimeType { get; set; } = "";

    /// <summary>
    /// Gets or sets the comment for this version.
    /// </summary>
    public string Comment { get; set; } = "";

    /// <summary>
    /// Gets or sets the size of the blob.
    /// </summary>
    public long FileSize { get; set; }
}

public class ClassificationResponse
{
    /// <summary>
    /// Gets or sets eh guid.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the file name.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Request model for getting documents by path ids and attributes.
/// </summary>
public class GetDocumentsByPathsRequest
{
    /// <summary>
    /// Gets or sets the list of path ids to filter by.
    /// </summary>
    public IList<Guid>? PathIds { get; set; }

    /// <summary>
    /// Gets or sets the attribute key to filter by.
    /// </summary>
    public string? AttributeKey { get; set; }

    /// <summary>
    /// Gets or sets the attribute value to filter by.
    /// </summary>
    public string? AttributeValue { get; set; }
}
