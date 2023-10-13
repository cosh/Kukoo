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
    /// Parameters of how to return time series instances by search instances call.
    /// </summary>
    [DataContract]
    public partial class SearchInstancesParameters : IEquatable<SearchInstancesParameters>
    { 
        /// <summary>
        /// Definition of which instances are returned. When recursive is set to &#39;true&#39;, all instances that have the path that starts with path the path parameter are returned. When recursive is set to &#39;false&#39;, only instances that have the path that exactly matches the path parameter are returned. Using recursive search allows to implement search user experience, while using non-recursive search allows to implement navigation experience. Optional, default is &#39;true&#39;.
        /// </summary>
        /// <value>Definition of which instances are returned. When recursive is set to &#39;true&#39;, all instances that have the path that starts with path the path parameter are returned. When recursive is set to &#39;false&#39;, only instances that have the path that exactly matches the path parameter are returned. Using recursive search allows to implement search user experience, while using non-recursive search allows to implement navigation experience. Optional, default is &#39;true&#39;.</value>

        [DataMember(Name="recursive")]
        public bool? Recursive { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>

        [DataMember(Name="sort")]
        public InstancesSortParameter Sort { get; set; }

        /// <summary>
        /// Definition of highlighted search results or not. When it is set to &#39;true&#39;, the highlighted search results are returned. When it is set to &#39;false&#39;, the highlighted search results are not returned. Default is &#39;true&#39;.
        /// </summary>
        /// <value>Definition of highlighted search results or not. When it is set to &#39;true&#39;, the highlighted search results are returned. When it is set to &#39;false&#39;, the highlighted search results are not returned. Default is &#39;true&#39;.</value>

        [DataMember(Name="highlights")]
        public bool? Highlights { get; set; }

        /// <summary>
        /// Maximum number of instances expected in each page of the result. Defaults to 10 when not set. Ranges from 1 to 100. If there are results beyond the page size, the user can use the continuation token to fetch the next page.
        /// </summary>
        /// <value>Maximum number of instances expected in each page of the result. Defaults to 10 when not set. Ranges from 1 to 100. If there are results beyond the page size, the user can use the continuation token to fetch the next page.</value>

        [DataMember(Name="pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchInstancesParameters {\n");
            sb.Append("  Recursive: ").Append(Recursive).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Highlights: ").Append(Highlights).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchInstancesParameters)obj);
        }

        /// <summary>
        /// Returns true if SearchInstancesParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchInstancesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchInstancesParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Recursive == other.Recursive ||
                    Recursive != null &&
                    Recursive.Equals(other.Recursive)
                ) && 
                (
                    Sort == other.Sort ||
                    Sort != null &&
                    Sort.Equals(other.Sort)
                ) && 
                (
                    Highlights == other.Highlights ||
                    Highlights != null &&
                    Highlights.Equals(other.Highlights)
                ) && 
                (
                    PageSize == other.PageSize ||
                    PageSize != null &&
                    PageSize.Equals(other.PageSize)
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
                    if (Recursive != null)
                    hashCode = hashCode * 59 + Recursive.GetHashCode();
                    if (Sort != null)
                    hashCode = hashCode * 59 + Sort.GetHashCode();
                    if (Highlights != null)
                    hashCode = hashCode * 59 + Highlights.GetHashCode();
                    if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchInstancesParameters left, SearchInstancesParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchInstancesParameters left, SearchInstancesParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
