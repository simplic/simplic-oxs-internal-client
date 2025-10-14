namespace Simplic.OxS.SequenceNumber.InternalClient.Model
{
    /// <summary>
    /// Represents the internal sequence number model
    /// </summary>
    public class SequenceNumberInternalModel
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the rendered sequence number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the numeric part of the sequence number which also is the current counting position
        /// </summary>
        public int CountingPosition { get; set; }

        /// <summary>
        /// Gets or sets the counting range the sequence number belongs to
        /// </summary>
        public Guid SequenceNumberCountingRangeId { get; set; }

        /// <summary>
        /// Gets or sets an identifier for the reservation so it can't be used by another client while the reservation is active
        /// </summary>
        public Guid ReservationId { get; set; }
    }
}
