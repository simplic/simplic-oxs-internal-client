namespace Simplic.OxS.Logistics.InternalClient.Model
{
    /// <summary>
    /// Represents the loading aid type internal model.
    /// </summary>
    public class LoadingAidTypeInternalModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets the short text.
        /// </summary>
        public string? ShortText { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the storage position.
        /// </summary>
        public decimal? StoragePosition { get; set; }
    }
}