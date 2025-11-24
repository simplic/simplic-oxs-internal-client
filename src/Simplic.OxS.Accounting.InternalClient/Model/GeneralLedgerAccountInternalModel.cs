namespace Simplic.OxS.Accounting.InternalClient.Model
{
    /// <summary>
    /// Represents the internal general ledger account model
    /// </summary>
    public class GeneralLedgerAccountInternalModel
    {
        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the corresponding tax rate by ID.
        /// </summary>
        public Guid? TaxRateId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets whether the accounting is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

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
        /// Gets or sets the update user name.
        /// </summary>
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets the organization id for the accounting.
        /// </summary>
        public Guid OrganizationId { get; set; }
    }
}
