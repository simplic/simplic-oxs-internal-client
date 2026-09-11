namespace Simplic.OxS.Cleaning.InternalClient
{
    /// <summary>
    /// Represents the status of a cleaning order.
    /// </summary>
    public class InternalCleaningOrderStatusModel
    {
        /// <summary>
        /// Gets or sets the id of the status.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the status.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the status.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the display key of the status.
        /// </summary>
        public string? DisplayKey { get; set; }

        /// <summary>
        /// Gets or sets the number of the status.
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or sets the roles of the status.
        /// </summary>
        public IList<string> Roles { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the hex color of the status.
        /// </summary>
        public string? HexColor { get; set; }

        /// <summary>
        /// Gets or sets the order number of the status.
        /// </summary>
        public int OrderNr { get; set; }

        /// <summary>
        /// Gets or sets the name of the resolver of the status.
        /// </summary>
        public string? Resolver { get; set; }

        /// <summary>
        /// Gets or sets whether the status is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
