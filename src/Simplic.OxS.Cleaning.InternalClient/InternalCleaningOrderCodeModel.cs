namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents a cleaning code frozen at a cleaning order.
    /// </summary>
    public class InternalCleaningOrderCodeModel
    {
        /// <summary>
        /// Gets or sets the id of the entry.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the id of the cleaning code master data record.
        /// </summary>
        public Guid CleaningCodeId { get; set; }

        /// <summary>
        /// Gets or sets the code (e.g. "E17").
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the captured value of the code (e.g. a temperature).
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// Gets or sets the order number of the code within the order.
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the origin of the code.
        /// </summary>
        public InternalCleaningOrderCodeOrigin Origin { get; set; }
    }
}
