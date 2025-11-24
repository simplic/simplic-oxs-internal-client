namespace Simplic.OxS.Erp.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a tax rate.
    /// </summary>
    public class TaxRateInternalModel
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
        /// Gets or sets wether the tax rate is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date and time the tax rate is created.
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the user that created the tax rate.
        /// </summary>
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user that created the tax rate.
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the date and time the tax rate is updated.
        /// </summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the user that updated the tax rate.
        /// </summary>
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user that updated the tax rate.
        /// </summary>
        public string UpdateUserName { get; set; }
    }
}
