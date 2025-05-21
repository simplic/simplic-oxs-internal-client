namespace Simplic.OxS.Vehicle.InternalClient;

public class AppointmentInternalModel
{
    /// <summary>
    /// Gets or sets the id of the appointment.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The id of the appointment type.
    /// </summary>
    public AppointmentTypeInternalModel AppointmentType { get; set; }

    /// <summary>
    /// The last date for the appointment.
    /// </summary>
    public DateTime? LastDate { get; set; }

    /// <summary>
    /// The next date for the appointment.
    /// </summary>
    public DateTime? NextDate { get; set; }

    /// <summary>
    /// The remark for the appointment.
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// The potential supplier for the appointment.
    /// </summary>
    public Guid? SupplierGuid { get; set; }

    /// <summary>
    /// The last value for the appointment.
    /// </summary>
    public int? LastValue { get; set; }

    /// <summary>
    /// The next value for the appointment.
    /// </summary>
    public int? NextValue { get; set; }

    public int CheckType { get; set; }
}