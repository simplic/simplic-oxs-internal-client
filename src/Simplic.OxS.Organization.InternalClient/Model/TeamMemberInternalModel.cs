
namespace Simplic.OxS.Organization.InternalClient.Model
{
    /// <summary>
    /// Represents a sub user object.
    /// </summary>
    public class TeamMemberInternalModel
    {
        /// <summary>
        /// Gets or sets the user guid.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public string EMail { get; set; }
    }
}
