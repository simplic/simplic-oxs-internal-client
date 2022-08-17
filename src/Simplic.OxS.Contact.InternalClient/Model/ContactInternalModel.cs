namespace Simplic.OxS.Contact.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a contact.
    /// </summary>
    public class ContactInternalModel
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public AddressInternalModel Address { get; set; } = new AddressInternalModel();

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets whether the contact is deleted.
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
        /// Gets or sets the organization id for the contact.
        /// </summary>
        public Guid OrganizationId { get; set; }
    }
}
