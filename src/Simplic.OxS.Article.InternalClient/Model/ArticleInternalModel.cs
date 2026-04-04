namespace Simplic.OxS.Article.InternalClient.Model
{
    /// <summary>
    /// Represents the internal model of an article.
    /// </summary>
    public class ArticleInternalModel
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
        /// Gets or sets the short name.
        /// </summary>
        public string? ShortName { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or sets the corresponding tax rate by ID.
        /// </summary>
        public Guid? TaxRateId { get; set; }

        /// <summary>
        /// Gets or sets the ean.
        /// <para>
        /// EAN is short for european article number.
        /// </para>
        /// </summary>
        public string? EAN { get; set; }

        /// <summary>
        /// Gets or sets the article group.
        /// </summary>
        public ArticleGroupInternalModel ArticleGroup { get; set; }

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
        /// Gets or sets whether the article is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}
