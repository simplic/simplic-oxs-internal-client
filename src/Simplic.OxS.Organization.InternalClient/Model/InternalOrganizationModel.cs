namespace Simplic.OxS.Organization.InternalClient.Model
{
    /// <summary>
    /// Reprensents a organization member
    /// </summary>
    public class OrganizationMemberModel
    {
        /// <summary>
        /// Gets or sets the id of the membership
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization id, which the user belongs to
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or seta the organization name, which the user belongs to
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the user id of the member
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the e-mail address of the member/user
        /// </summary>
        public string UserEmailAddress { get; set; }
        
        /// <summary>
        /// Gets or sets a list of roles, that belongs to the member (user-organization)
        /// </summary>
        public IList<string> Roles { get; set; } = new List<string>();
    }
}
