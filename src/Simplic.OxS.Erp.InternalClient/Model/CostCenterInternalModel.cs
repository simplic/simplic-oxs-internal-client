namespace Simplic.OxS.Erp.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a cost center.
    /// </summary>
    public class CostCenterInternalModel
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
        /// Gets or sets the name of the cost center.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique number of the cost center.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the valid from date
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets the valid to date
        /// </summary>
        public DateTime? ValidTo { get; set; }

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
        /// Gets or sets the udate user name.
        /// </summary>
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets whether the cost center is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}