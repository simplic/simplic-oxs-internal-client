namespace Simplic.OxS.Mail.InternalClient;

/// <summary>
/// Base model for email messages containing common email properties.
/// </summary>
public class MailBaseInternalModel
{
    /// <summary>
    /// Gets or sets the sender(s) of the email.
    /// </summary>
    public IList<MailBoxInternalModel> From { get; set; }

    /// <summary>
    /// Gets or sets the primary recipient(s) of the email.
    /// </summary>
    public IList<MailBoxInternalModel> To { get; set; }

    /// <summary>
    /// Gets or sets the carbon copy (CC) recipient(s) of the email.
    /// </summary>
    public IList<MailBoxInternalModel> Cc { get; set; }

    /// <summary>
    /// Gets or sets the blind carbon copy (BCC) recipient(s) of the email.
    /// </summary>
    public IList<MailBoxInternalModel> Bcc { get; set; }

    /// <summary>
    /// Gets or sets the subject line of the email.
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Gets or sets the body content of the email.
    /// </summary>
    public MailBodyInternalModel Body { get; set; }

    /// <summary>
    /// Gets or sets the list of attachments for the email.
    /// </summary>
    public IList<AttachmentInternalModel> Attachments { get; set; }
}

/// <summary>
/// Represents the body content of an email message.
/// </summary>
public class MailBodyInternalModel
{
    /// <summary>
    /// Gets or sets the text content of the email body.
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the body content is HTML formatted.
    /// </summary>
    public bool IsBodyHtml { get; set; }
}

/// <summary>
/// Represents an email attachment.
/// </summarya>
public class AttachmentInternalModel
{
    /// <summary>
    /// Gets or sets the name of the attachment file.
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the blob containing the attachment data.
    /// </summary>
    public Guid BlobId { get; set; }
}

/// <summary>
/// Represents an email address in a mailbox.
/// </summary>
public class MailBoxInternalModel
{
    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    public string Address { get; set; }
}
