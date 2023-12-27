namespace Simplic.OxS.TimeSlot.InternalClient.Model
{
    /// <summary>
    /// Represents the internal site model.
    /// </summary>
    public class SiteInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the organization site id.
        /// </summary>
        public Guid? OrganizationSiteId { get; set; }

        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the create date time.
        /// </summary>
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUserName { get; set; }
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
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the assignments.
        /// </summary>
        public IList<SiteAssignmentInternalModel>? Assignments { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        public AddressInternalModel? Adress { get; set; }

        /// <summary>
        /// Gets or sets the logo url.
        /// </summary>
        public string? LogoUrl { get; set; }
    }
}
