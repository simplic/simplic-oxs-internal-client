
namespace Simplic.OxS.Organization.InternalClient.Model
{
    public class TeamInternalModel
    {

        /// <summary>
        /// Gets or sets the unique id of the team.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the users list.
        /// </summary>
        public IList<TeamMemberInternalModel> TeamMember { get; set; } = new List<TeamMemberInternalModel>();
    }
}
