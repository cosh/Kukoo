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
    /// The hierarchy node which contains the instances matching the query based on the input. May be empty or null.
    /// </summary>
    [DataContract]
    public partial class HierarchyHit : IEquatable<HierarchyHit>
    { 
        /// <summary>
        /// Name of the hierarchy node. May be empty, cannot be null.
        /// </summary>
        /// <value>Name of the hierarchy node. May be empty, cannot be null.</value>

        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Total number of instances that belong to this node and it&#39;s subtrees matching the query.
        /// </summary>
        /// <value>Total number of instances that belong to this node and it&#39;s subtrees matching the query.</value>

        [DataMember(Name="cumulativeInstanceCount")]
        public int? CumulativeInstanceCount { get; private set; }

        /// <summary>
        /// Child hierarchy nodes of this node. May be empty or null.
        /// </summary>
        /// <value>Child hierarchy nodes of this node. May be empty or null.</value>

        [DataMember(Name="hierarchyNodes")]
        public SearchHierarchyNodesResponse HierarchyNodes { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HierarchyHit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CumulativeInstanceCount: ").Append(CumulativeInstanceCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HierarchyHit)obj);
        }

        /// <summary>
        /// Returns true if HierarchyHit instances are equal
        /// </summary>
        /// <param name="other">Instance of HierarchyHit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HierarchyHit other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    CumulativeInstanceCount == other.CumulativeInstanceCount ||
                    CumulativeInstanceCount != null &&
                    CumulativeInstanceCount.Equals(other.CumulativeInstanceCount)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (CumulativeInstanceCount != null)
                    hashCode = hashCode * 59 + CumulativeInstanceCount.GetHashCode();
                    if (HierarchyNodes != null)
                    hashCode = hashCode * 59 + HierarchyNodes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HierarchyHit left, HierarchyHit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HierarchyHit left, HierarchyHit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
