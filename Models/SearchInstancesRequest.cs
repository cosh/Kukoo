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
    /// Request to execute a search query against time series instances and return matching time series instances.
    /// </summary>
    [DataContract]
    public partial class SearchInstancesRequest : IEquatable<SearchInstancesRequest>
    { 
        /// <summary>
        /// Query search string that will be matched to the attributes of time series instances. Example: \&quot;floor 100\&quot;. Case-insensitive, must be present, but can be empty string.
        /// </summary>
        /// <value>Query search string that will be matched to the attributes of time series instances. Example: \&quot;floor 100\&quot;. Case-insensitive, must be present, but can be empty string.</value>
        [Required]
        
        [DataMember(Name="searchString")]
        public string SearchString { get; set; }

        /// <summary>
        /// Filter on hierarchy path of time series instances. Path is represented as array of string path segments. First element should be hierarchy name. Example: [\&quot;Location\&quot;, \&quot;California\&quot;]. Optional, case sensitive, never empty and can be null.
        /// </summary>
        /// <value>Filter on hierarchy path of time series instances. Path is represented as array of string path segments. First element should be hierarchy name. Example: [\&quot;Location\&quot;, \&quot;California\&quot;]. Optional, case sensitive, never empty and can be null.</value>

        [DataMember(Name="path")]
        public List<string> Path { get; set; }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>

        [DataMember(Name="instances")]
        public SearchInstancesParameters Instances { get; set; }

        /// <summary>
        /// Gets or Sets Hierarchies
        /// </summary>

        [DataMember(Name="hierarchies")]
        public SearchInstancesHierarchiesParameters Hierarchies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchInstancesRequest {\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  Hierarchies: ").Append(Hierarchies).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchInstancesRequest)obj);
        }

        /// <summary>
        /// Returns true if SearchInstancesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchInstancesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchInstancesRequest other)
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
                    Path == other.Path ||
                    Path != null &&
                    Path.SequenceEqual(other.Path)
                ) && 
                (
                    Instances == other.Instances ||
                    Instances != null &&
                    Instances.Equals(other.Instances)
                ) && 
                (
                    Hierarchies == other.Hierarchies ||
                    Hierarchies != null &&
                    Hierarchies.Equals(other.Hierarchies)
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
                    if (Path != null)
                    hashCode = hashCode * 59 + Path.GetHashCode();
                    if (Instances != null)
                    hashCode = hashCode * 59 + Instances.GetHashCode();
                    if (Hierarchies != null)
                    hashCode = hashCode * 59 + Hierarchies.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchInstancesRequest left, SearchInstancesRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchInstancesRequest left, SearchInstancesRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
