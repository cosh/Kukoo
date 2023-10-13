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
    /// Parameter of how to return time series instance hierarchies by search instances call.
    /// </summary>
    [DataContract]
    public partial class SearchInstancesHierarchiesParameters : IEquatable<SearchInstancesHierarchiesParameters>
    { 
        /// <summary>
        /// Gets or Sets Expand
        /// </summary>

        [DataMember(Name="expand")]
        public HierarchiesExpandParameter Expand { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>

        [DataMember(Name="sort")]
        public HierarchiesSortParameter Sort { get; set; }

        /// <summary>
        /// Maximum number of hierarchies in the same level to return in the same page. Optional, default is 10 when not set. Range is from 1 to 100. If there are results beyond the page size, the continuation token can be used to fetch the next page.
        /// </summary>
        /// <value>Maximum number of hierarchies in the same level to return in the same page. Optional, default is 10 when not set. Range is from 1 to 100. If there are results beyond the page size, the continuation token can be used to fetch the next page.</value>

        [DataMember(Name="pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchInstancesHierarchiesParameters {\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchInstancesHierarchiesParameters)obj);
        }

        /// <summary>
        /// Returns true if SearchInstancesHierarchiesParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchInstancesHierarchiesParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchInstancesHierarchiesParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Expand == other.Expand ||
                    Expand != null &&
                    Expand.Equals(other.Expand)
                ) && 
                (
                    Sort == other.Sort ||
                    Sort != null &&
                    Sort.Equals(other.Sort)
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
                    if (Expand != null)
                    hashCode = hashCode * 59 + Expand.GetHashCode();
                    if (Sort != null)
                    hashCode = hashCode * 59 + Sort.GetHashCode();
                    if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchInstancesHierarchiesParameters left, SearchInstancesHierarchiesParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchInstancesHierarchiesParameters left, SearchInstancesHierarchiesParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
