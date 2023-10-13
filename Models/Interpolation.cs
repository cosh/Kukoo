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
    /// The interpolation operation to be performed on the raw data points. Currently, only sampling of interpolated time series is allowed. Allowed aggregate function - eg: left($value). Can be null if no interpolation needs to be applied.
    /// </summary>
    [DataContract]
    public partial class Interpolation : IEquatable<Interpolation>
    { 
        /// <summary>
        /// The type of interpolation technique : \"Linear\" or \"Step\".
        /// </summary>
        /// <value>The type of interpolation technique : \"Linear\" or \"Step\".</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum KindEnum
        {
            
            /// <summary>
            /// Enum LinearEnum for Linear
            /// </summary>
            [EnumMember(Value = "Linear")]
            LinearEnum = 1,
            
            /// <summary>
            /// Enum StepEnum for Step
            /// </summary>
            [EnumMember(Value = "Step")]
            StepEnum = 2
        }

        /// <summary>
        /// The type of interpolation technique : \&quot;Linear\&quot; or \&quot;Step\&quot;.
        /// </summary>
        /// <value>The type of interpolation technique : \&quot;Linear\&quot; or \&quot;Step\&quot;.</value>

        [DataMember(Name="kind")]
        public KindEnum? Kind { get; set; }

        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>

        [DataMember(Name="boundary")]
        public InterpolationBoundary Boundary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Interpolation {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Interpolation)obj);
        }

        /// <summary>
        /// Returns true if Interpolation instances are equal
        /// </summary>
        /// <param name="other">Instance of Interpolation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Interpolation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Kind == other.Kind ||
                    Kind != null &&
                    Kind.Equals(other.Kind)
                ) && 
                (
                    Boundary == other.Boundary ||
                    Boundary != null &&
                    Boundary.Equals(other.Boundary)
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
                    if (Kind != null)
                    hashCode = hashCode * 59 + Kind.GetHashCode();
                    if (Boundary != null)
                    hashCode = hashCode * 59 + Boundary.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Interpolation left, Interpolation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Interpolation left, Interpolation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
