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
    /// Response of Get Availability operation. When environment has no data, availability property is null.
    /// </summary>
    [DataContract]
    public partial class AvailabilityResponse : IEquatable<AvailabilityResponse>
    { 
        /// <summary>
        /// Event availability information when environment contains events. When environment has no data yet, this property is null or not present.
        /// </summary>
        /// <value>Event availability information when environment contains events. When environment has no data yet, this property is null or not present.</value>

        [DataMember(Name="availability")]
        public Availability Availability { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityResponse {\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailabilityResponse)obj);
        }

        /// <summary>
        /// Returns true if AvailabilityResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Availability == other.Availability ||
                    Availability != null &&
                    Availability.Equals(other.Availability)
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
                    if (Availability != null)
                    hashCode = hashCode * 59 + Availability.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AvailabilityResponse left, AvailabilityResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailabilityResponse left, AvailabilityResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
