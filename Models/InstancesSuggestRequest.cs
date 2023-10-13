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
    /// Request to get search string suggestions for time series instances search based on prefix text.
    /// </summary>
    [DataContract]
    public partial class InstancesSuggestRequest : IEquatable<InstancesSuggestRequest>
    { 
        /// <summary>
        /// Search string for which suggestions are required. Empty is allowed, but not null.
        /// </summary>
        /// <value>Search string for which suggestions are required. Empty is allowed, but not null.</value>
        [Required]
        
        [DataMember(Name="searchString")]
        public string SearchString { get; set; }

        /// <summary>
        /// Maximum number of suggestions expected in the result. Defaults to 10 when not set.
        /// </summary>
        /// <value>Maximum number of suggestions expected in the result. Defaults to 10 when not set.</value>

        [DataMember(Name="take")]
        public int? Take { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesSuggestRequest {\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  Take: ").Append(Take).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstancesSuggestRequest)obj);
        }

        /// <summary>
        /// Returns true if InstancesSuggestRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InstancesSuggestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesSuggestRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SearchString == other.SearchString ||
                    SearchString != null &&
                    SearchString.Equals(other.SearchString)
                ) && 
                (
                    Take == other.Take ||
                    Take != null &&
                    Take.Equals(other.Take)
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
                    if (SearchString != null)
                    hashCode = hashCode * 59 + SearchString.GetHashCode();
                    if (Take != null)
                    hashCode = hashCode * 59 + Take.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstancesSuggestRequest left, InstancesSuggestRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstancesSuggestRequest left, InstancesSuggestRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
