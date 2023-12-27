namespace Simplic.OxS.TimeSlot.InternalClient.Model
{
    /// <summary>
    /// Represents the internal site assignment model.
    /// </summary>
    public class SiteAssignmentInternalModel
    {
        /// <summary>
        /// Gets or sets the origanization id.
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the organization site id.
        /// </summary>
        public Guid? OrganizationSiteId { get; set; }
    }
}