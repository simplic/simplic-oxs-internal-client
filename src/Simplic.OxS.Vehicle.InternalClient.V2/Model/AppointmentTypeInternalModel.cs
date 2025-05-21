namespace Simplic.OxS.Vehicle.InternalClient;

public class AppointmentTypeInternalModel
{
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the display name of the appointment type.
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the display key of the appointment type.
    /// </summary>
    public string DisplayKey { get; set; }

    /// <summary>
    /// Gets or sets the interval type of the appointment type.
    /// <para>Allowed values: "none", "month" "year", "mileage", "operating_hours"</para>
    /// </summary>
    public string IntervalType { get; set; }

    /// <summary>
    /// Gets or sets the interval.
    /// </summary>
    public int Interval { get; set; }
}