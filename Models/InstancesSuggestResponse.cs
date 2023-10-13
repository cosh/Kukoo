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
    /// Response of getting suggestions for search for time series instances.
    /// </summary>
    [DataContract]
    public partial class InstancesSuggestResponse : IEquatable<InstancesSuggestResponse>
    { 
        /// <summary>
        /// List of instance suggestions for searching time series models.
        /// </summary>
        /// <value>List of instance suggestions for searching time series models.</value>

        [DataMember(Name="suggestions")]
        public List<InstancesSearchStringSuggestion> Suggestions { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesSuggestResponse {\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstancesSuggestResponse)obj);
        }

        /// <summary>
        /// Returns true if InstancesSuggestResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of InstancesSuggestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesSuggestResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Suggestions == other.Suggestions ||
                    Suggestions != null &&
                    Suggestions.SequenceEqual(other.Suggestions)
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
                    if (Suggestions != null)
                    hashCode = hashCode * 59 + Suggestions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstancesSuggestResponse left, InstancesSuggestResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstancesSuggestResponse left, InstancesSuggestResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
