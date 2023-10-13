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
    /// Numeric variable represents a single continuous numeric signal that can be reconstructed using interpolation.
    /// </summary>
    [DataContract]
    public partial class NumericVariable : Variable, IEquatable<NumericVariable>
    { 
        /// <summary>
        /// Value time series expression is used to represent the value of the signal that is going to be aggregated or interpolated. For example, temperature values from the event is represented like this: \&quot;$event.Temperature.Double\&quot;.
        /// </summary>
        /// <value>Value time series expression is used to represent the value of the signal that is going to be aggregated or interpolated. For example, temperature values from the event is represented like this: \&quot;$event.Temperature.Double\&quot;.</value>

        [DataMember(Name="value")]
        public Tsx Value { get; set; }

        /// <summary>
        /// Gets or Sets Interpolation
        /// </summary>

        [DataMember(Name="interpolation")]
        public Interpolation Interpolation { get; set; }

        /// <summary>
        /// Aggregation time series expression when kind is \&quot;numeric\&quot; is used to represent the aggregation that needs to be performed on the $value expression. This requires $value to be specified and can only use $value inside the aggregate functions. For example, aggregation for calculating minimum of the $value is written as: \&quot;min($value)\&quot;.
        /// </summary>
        /// <value>Aggregation time series expression when kind is \&quot;numeric\&quot; is used to represent the aggregation that needs to be performed on the $value expression. This requires $value to be specified and can only use $value inside the aggregate functions. For example, aggregation for calculating minimum of the $value is written as: \&quot;min($value)\&quot;.</value>

        [DataMember(Name="aggregation")]
        public Tsx Aggregation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumericVariable {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Interpolation: ").Append(Interpolation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NumericVariable)obj);
        }

        /// <summary>
        /// Returns true if NumericVariable instances are equal
        /// </summary>
        /// <param name="other">Instance of NumericVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumericVariable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Interpolation == other.Interpolation ||
                    Interpolation != null &&
                    Interpolation.Equals(other.Interpolation)
                ) && 
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
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Interpolation != null)
                    hashCode = hashCode * 59 + Interpolation.GetHashCode();
                    if (Aggregation != null)
                    hashCode = hashCode * 59 + Aggregation.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NumericVariable left, NumericVariable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NumericVariable left, NumericVariable right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
