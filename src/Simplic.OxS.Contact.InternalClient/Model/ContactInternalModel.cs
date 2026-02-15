namespace Simplic.OxS.Contact.InternalClient.Model;

/// <summary>
/// Represents the internal model of a contact.
/// </summary>
public class ContactInternalModel
{
    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    public AddressInternalModel Address { get; set; } = new AddressInternalModel();

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets whether the contact is deleted.
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets the create date time.
    /// </summary>
    public DateTime CreateDateTime { get; set; }

    /// <summary>
    /// Gets or sets the create user id.
    /// </summary>
    public Guid? CreateUserId { get; set; }

    /// <summary>
    /// Gets or sets the create user name.
    /// </summary>
    public string CreateUserName { get; set; }

    /// <summary>
    /// Gets or sets the update date time.
    /// </summary>
    public DateTime UpdateDateTime { get; set; }

    /// <summary>
    /// Gets or sets the update user id.
    /// </summary>
    public Guid? UpdateUserId { get; set; }

    /// <summary>
    /// Gets or sets the update user name.
    /// </summary>
    public string UpdateUserName { get; set; }

    /// <summary>
    /// Gets or sets the organization id for the contact.
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Gets or sets the contact match-code
    /// </summary>
    public string? MatchCode { get; set; }

    /// <summary>
    /// Gets or sets a list of contact functions (e.g. carrier)
    /// </summary>
    public IList<string> Functions { get; set; } = new List<string>();

    /// <summary>
    /// Gets or sets the opening hours for the contact.
    /// </summary>
    public IList<OpeningHoursModel>? OpeningHours { get; set; } = new List<OpeningHoursModel>();


    /// <summary>
    /// Gets or sets the closed days when the contact is not reachable.
    /// </summary>
    public IList<ClosedDayModel>? ClosedDays { get; set; } = new List<ClosedDayModel>();
}

/// <summary>
/// Represents the server model for opening hours.
/// </summary>
public class OpeningHoursModel
{
    /// <summary>
    /// Gets or sets the day of week.
    /// </summary>
    public DayOfWeek DayOfWeek { get; set; }

    /// <summary>
    /// Gets or sets the opening time.
    /// </summary>
    public TimeSpan? OpenTime { get; set; }

    /// <summary>
    /// Gets or sets the closing time.
    /// </summary>
    public TimeSpan? CloseTime { get; set; }

    /// <summary>
    /// Gets or sets whether the contact is closed on this day.
    /// </summary>
    public bool IsClosed { get; set; }
}

/// <summary>
/// Represents the server model for a closed day.
/// </summary>
public class ClosedDayModel
{
    /// <summary>
    /// Gets or sets the date when the contact is not reachable.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the reason for the closure (e.g., "Holiday", "Vacation", "Special Event").
    /// </summary>
    public string? Reason { get; set; }
}