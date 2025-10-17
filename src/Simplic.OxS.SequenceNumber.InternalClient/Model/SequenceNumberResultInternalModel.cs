namespace Simplic.OxS.SequenceNumber.InternalClient.Model
{
    /// <summary>
    /// Represents the internal sequence number result model
    /// </summary>
    public class SequenceNumberResultInternalModel
    {
        /// <summary>
        /// Gets or sets the sequence number
        /// </summary>
        public SequenceNumberInternalModel? SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the valid from date of the counting range the sequence number was generated from
        /// </summary>
        public DateTime CountingRangeValidFrom { get; set; }

        /// <summary>
        /// Gets or sets the valid to date of the counting range the sequence number was generated from
        /// </summary>
        public DateTime CountingRangeValidTo { get; set; }

        /// <summary>
        /// Gets or sets the set of errors that occured while trying to generate the sequence number
        /// </summary>
        public IList<string> Errors { get; set; } = new List<string>();
    }
}
