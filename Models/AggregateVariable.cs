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
    /// Aggregate variable represents any aggregation calculation. Aggregate Variables does not support interpolation.
    /// </summary>
    [DataContract]
    public partial class AggregateVariable : Variable, IEquatable<AggregateVariable>
    { 
        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>

        [DataMember(Name="aggregation")]
        public Tsx Aggregation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregateVariable {\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((AggregateVariable)obj);
        }

        /// <summary>
        /// Returns true if AggregateVariable instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregateVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateVariable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Aggregation == other.Aggregation ||
                    Aggregation != null &&
                    Aggregation.Equals(other.Aggregation)
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
                    if (Aggregation != null)
                    hashCode = hashCode * 59 + Aggregation.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AggregateVariable left, AggregateVariable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AggregateVariable left, AggregateVariable right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
