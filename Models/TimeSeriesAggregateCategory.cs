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
    /// Category used in categorical variables. A category is defined by &#39;label&#39; and the &#39;values&#39; that are assigned this label.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesAggregateCategory : IEquatable<TimeSeriesAggregateCategory>
    { 
        /// <summary>
        /// The name of the category which will be used in constructing the output variable names.
        /// </summary>
        /// <value>The name of the category which will be used in constructing the output variable names.</value>
        [Required]
        
        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// The list of values that a category maps to. Can be either a unique list of string or list of long.
        /// </summary>
        /// <value>The list of values that a category maps to. Can be either a unique list of string or list of long.</value>
        [Required]
        
        [DataMember(Name="values")]
        public List<Object> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesAggregateCategory {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesAggregateCategory)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesAggregateCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesAggregateCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesAggregateCategory other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Values == other.Values ||
                    Values != null &&
                    Values.SequenceEqual(other.Values)
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
                    if (Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesAggregateCategory left, TimeSeriesAggregateCategory right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesAggregateCategory left, TimeSeriesAggregateCategory right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
