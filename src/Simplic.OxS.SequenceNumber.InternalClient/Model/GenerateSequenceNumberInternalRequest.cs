using System.ComponentModel.DataAnnotations;

namespace Simplic.OxS.SequenceNumber.InternalClient.Model
{
    /// <summary>
    /// Request model for generating a sequence number
    /// </summary>
    public class GenerateSequenceNumberInternalRequest
    {
        /// <summary>
        /// Gets or sets the sequence number range name
        /// </summary>
        public string SequenceNumberRangeName { get; set; }

        /// <summary>
        /// Gets or sets the time for the sequence number
        /// <para>
        /// If none is set, the current time is used
        /// </para>
        /// </summary>
        public DateTime? TimeForSequenceNumber { get; set; }
    }
}
