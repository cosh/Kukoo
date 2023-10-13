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
    /// The hierarchy nodes which contains the instances matching the query based on the input. May be empty or null.
    /// </summary>
    [DataContract]
    public partial class SearchHierarchyNodesResponse : IEquatable<SearchHierarchyNodesResponse>
    { 
        /// <summary>
        /// The list of hierarchy nodes which contains the instances matching the query based on the input. May be empty.
        /// </summary>
        /// <value>The list of hierarchy nodes which contains the instances matching the query based on the input. May be empty.</value>

        [DataMember(Name="hits")]
        public List<HierarchyHit> Hits { get; private set; }

        /// <summary>
        /// Total number of hierarchy nodes which contains the instances matching the query based on the input.
        /// </summary>
        /// <value>Total number of hierarchy nodes which contains the instances matching the query based on the input.</value>

        [DataMember(Name="hitCount")]
        public int? HitCount { get; private set; }

        /// <summary>
        /// If returned, this means that current results represent a partial result. Continuation token allows to get the next page of results. To get the next page of query results, send the same request with continuation token parameter in \&quot;x-ms-continuation\&quot; HTTP header.
        /// </summary>
        /// <value>If returned, this means that current results represent a partial result. Continuation token allows to get the next page of results. To get the next page of query results, send the same request with continuation token parameter in \&quot;x-ms-continuation\&quot; HTTP header.</value>

        [DataMember(Name="continuationToken")]
        public string ContinuationToken { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchHierarchyNodesResponse {\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  HitCount: ").Append(HitCount).Append("\n");
            sb.Append("  ContinuationToken: ").Append(ContinuationToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchHierarchyNodesResponse)obj);
        }

        /// <summary>
        /// Returns true if SearchHierarchyNodesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchHierarchyNodesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchHierarchyNodesResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Hits == other.Hits ||
                    Hits != null &&
                    Hits.SequenceEqual(other.Hits)
                ) && 
                (
                    HitCount == other.HitCount ||
                    HitCount != null &&
                    HitCount.Equals(other.HitCount)
                ) && 
                (
                    ContinuationToken == other.ContinuationToken ||
                    ContinuationToken != null &&
                    ContinuationToken.Equals(other.ContinuationToken)
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
                    if (Hits != null)
                    hashCode = hashCode * 59 + Hits.GetHashCode();
                    if (HitCount != null)
                    hashCode = hashCode * 59 + HitCount.GetHashCode();
                    if (ContinuationToken != null)
                    hashCode = hashCode * 59 + ContinuationToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchHierarchyNodesResponse left, SearchHierarchyNodesResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchHierarchyNodesResponse left, SearchHierarchyNodesResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
