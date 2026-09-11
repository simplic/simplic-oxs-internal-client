namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents a cleaning resource of a cleaning order.
    /// </summary>
    public class InternalCleaningOrderResourceModel
    {
        /// <summary>
        /// Gets or sets the id of the entry.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        public InternalCleaningResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets the id of the own vehicle. Null for external resources.
        /// </summary>
        public Guid? VehicleId { get; set; }

        /// <summary>
        /// Gets or sets the match code (e.g. license plate) of the resource.
        /// </summary>
        public string? MatchCode { get; set; }

        /// <summary>
        /// Gets or sets whether this resource is the resource to clean.
        /// </summary>
        public bool IsCleaningResource { get; set; }
    }
}
