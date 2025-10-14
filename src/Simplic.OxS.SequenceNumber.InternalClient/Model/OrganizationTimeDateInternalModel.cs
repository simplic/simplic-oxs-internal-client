namespace Simplic.OxS.SequenceNumber.InternalClient.Model
{
    /// <summary>
    /// Custom date object for dates in the organization time zone
    /// <para>
    /// There is no fitting .NET DateOnly equivalent in JavaScript, so we use this custom object to represent dates without time
    /// </para>
    /// </summary>
    public class OrganizationTimeDateInternalModel
    {
        /// <summary>
        /// Gets or sets the day
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// Gets or sets the month
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Gets or sets the year
        /// </summary>
        public int Year { get; set; }
    }
}
