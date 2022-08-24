namespace Simplic.OxS.Article.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of a quantity unit.
    /// </summary>
    public class QuantityUnitInternalModel
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
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the numeric identifier.
        /// </summary>
        public int Ident { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// <para>
        /// A short name for the quantity unit. E.g. kg for Kilogramm.
        /// </para>
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the defualt decimal digits of the quantity.
        /// </summary>
        public int Digits { get; set; }

        /// <summary>
        /// Gets or sets the create date time of the quanitity unit.
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
        /// Gets or sets whether the quantity unit is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
