namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents the cleaning station contact reference of a cleaning order.
    /// </summary>
    public class InternalCleaningOrderContactModel
    {
        /// <summary>
        /// Gets or sets the id of the contact.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the company name of the contact.
        /// </summary>
        public string? CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the match code of the contact.
        /// </summary>
        public string? MatchCode { get; set; }
    }
}
