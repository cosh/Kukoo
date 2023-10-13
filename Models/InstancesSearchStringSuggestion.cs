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
    /// Suggested search string to be used for further search for time series instances.
    /// </summary>
    [DataContract]
    public partial class InstancesSearchStringSuggestion : IEquatable<InstancesSearchStringSuggestion>
    { 
        /// <summary>
        /// Suggested search string. Can be used for further search for time series instances.
        /// </summary>
        /// <value>Suggested search string. Can be used for further search for time series instances.</value>

        [DataMember(Name="searchString")]
        public string SearchString { get; private set; }

        /// <summary>
        /// Highlighted suggested search string to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use highlighted search string to do further search calls.
        /// </summary>
        /// <value>Highlighted suggested search string to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use highlighted search string to do further search calls.</value>

        [DataMember(Name="highlightedSearchString")]
        public string HighlightedSearchString { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesSearchStringSuggestion {\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  HighlightedSearchString: ").Append(HighlightedSearchString).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstancesSearchStringSuggestion)obj);
        }

        /// <summary>
        /// Returns true if InstancesSearchStringSuggestion instances are equal
        /// </summary>
        /// <param name="other">Instance of InstancesSearchStringSuggestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesSearchStringSuggestion other)
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
                    HighlightedSearchString == other.HighlightedSearchString ||
                    HighlightedSearchString != null &&
                    HighlightedSearchString.Equals(other.HighlightedSearchString)
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
                    if (HighlightedSearchString != null)
                    hashCode = hashCode * 59 + HighlightedSearchString.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstancesSearchStringSuggestion left, InstancesSearchStringSuggestion right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstancesSearchStringSuggestion left, InstancesSearchStringSuggestion right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
