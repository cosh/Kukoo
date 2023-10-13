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
    /// Represents the default category.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesDefaultCategory : IEquatable<TimeSeriesDefaultCategory>
    { 
        /// <summary>
        /// The name of the default category which will be assigned to the values that does not match any of those that are defined in the &#39;categories&#39;.
        /// </summary>
        /// <value>The name of the default category which will be assigned to the values that does not match any of those that are defined in the &#39;categories&#39;.</value>
        [Required]
        
        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesDefaultCategory {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesDefaultCategory)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesDefaultCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesDefaultCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesDefaultCategory other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
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
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesDefaultCategory left, TimeSeriesDefaultCategory right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesDefaultCategory left, TimeSeriesDefaultCategory right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
