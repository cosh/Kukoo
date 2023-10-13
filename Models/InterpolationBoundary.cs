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
    /// The time range to the left and right of the search span to be used for Interpolation. This is helpful in scenarios where the data points are missing close to the start or end of the input search span. Can be null.
    /// </summary>
    [DataContract]
    public partial class InterpolationBoundary : IEquatable<InterpolationBoundary>
    { 
        /// <summary>
        /// &lt;Need description here&gt;
        /// </summary>
        /// <value>&lt;Need description here&gt;</value>

        [DataMember(Name="span")]
        public string Span { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterpolationBoundary {\n");
            sb.Append("  Span: ").Append(Span).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InterpolationBoundary)obj);
        }

        /// <summary>
        /// Returns true if InterpolationBoundary instances are equal
        /// </summary>
        /// <param name="other">Instance of InterpolationBoundary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterpolationBoundary other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Span == other.Span ||
                    Span != null &&
                    Span.Equals(other.Span)
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
                    if (Span != null)
                    hashCode = hashCode * 59 + Span.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InterpolationBoundary left, InterpolationBoundary right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InterpolationBoundary left, InterpolationBoundary right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
