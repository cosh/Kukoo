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
    /// Single page of the search results.
    /// </summary>
    [DataContract]
    public partial class SearchInstancesResponsePage : IEquatable<SearchInstancesResponsePage>
    { 
        /// <summary>
        /// Gets or Sets Instances
        /// </summary>

        [DataMember(Name="instances")]
        public SearchInstancesResponse Instances { get; set; }

        /// <summary>
        /// Gets or Sets HierarchyNodes
        /// </summary>

        [DataMember(Name="hierarchyNodes")]
        public SearchHierarchyNodesResponse HierarchyNodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchInstancesResponsePage {\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  HierarchyNodes: ").Append(HierarchyNodes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchInstancesResponsePage)obj);
        }

        /// <summary>
        /// Returns true if SearchInstancesResponsePage instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchInstancesResponsePage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchInstancesResponsePage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Instances == other.Instances ||
                    Instances != null &&
                    Instances.Equals(other.Instances)
                ) && 
                (
                    HierarchyNodes == other.HierarchyNodes ||
                    HierarchyNodes != null &&
                    HierarchyNodes.Equals(other.HierarchyNodes)
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
                    if (Instances != null)
                    hashCode = hashCode * 59 + Instances.GetHashCode();
                    if (HierarchyNodes != null)
                    hashCode = hashCode * 59 + HierarchyNodes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchInstancesResponsePage left, SearchInstancesResponsePage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchInstancesResponsePage left, SearchInstancesResponsePage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
