namespace Simplic.OxS.Auth.InternalClient.Model
{
    /// <summary>
    /// Result of a successfully requested user
    /// </summary>
    public class RequestUserResponse
    {
        /// <summary>
        /// Gets or sets the id of the requested user
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the mail address for the request user
        /// </summary>
        public string? EMail { get; set; }

        /// <summary>
        /// Gets or sets the name for the requested user.
        /// </summary>
        public string? UserName { get; set; }
    }
}
