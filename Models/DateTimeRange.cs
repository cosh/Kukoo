using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kukoo.Models
{ 
    /// <summary>
    /// The range of time. Cannot be null or negative.
    /// </summary>
    [DataContract]
    public partial class DateTimeRange : IEquatable<DateTimeRange>
    { 
        /// <summary>
        /// Start timestamp of the time range. Start timestamp is inclusive when used in time series query requests. Events that have this timestamp are included.
        /// </summary>
        /// <value>Start timestamp of the time range. Start timestamp is inclusive when used in time series query requests. Events that have this timestamp are included.</value>
        [Required]
        
        [DataMember(Name="from")]
        public DateTime? From { get; set; }

        /// <summary>
        /// End timestamp of the time range. End timestamp is exclusive when used in time series query requests. Events that match this timestamp are excluded. Note that end timestamp is inclusive when returned by Get Availability (meaning that there is an event with this exact \&quot;to\&quot; timestamp).
        /// </summary>
        /// <value>End timestamp of the time range. End timestamp is exclusive when used in time series query requests. Events that match this timestamp are excluded. Note that end timestamp is inclusive when returned by Get Availability (meaning that there is an event with this exact \&quot;to\&quot; timestamp).</value>
        [Required]
        
        [DataMember(Name="to")]
        public DateTime? To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeRange {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((DateTimeRange)obj);
        }

        /// <summary>
        /// Returns true if DateTimeRange instances are equal
        /// </summary>
        /// <param name="other">Instance of DateTimeRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTimeRange other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    From == other.From ||
                    From != null &&
                    From.Equals(other.From)
                ) && 
                (
                    To == other.To ||
                    To != null &&
                    To.Equals(other.To)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (From != null)
                    hashCode = hashCode * 59 + From.GetHashCode();
                    if (To != null)
                    hashCode = hashCode * 59 + To.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DateTimeRange left, DateTimeRange right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DateTimeRange left, DateTimeRange right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
