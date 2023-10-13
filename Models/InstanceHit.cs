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
    /// Time series instance that is returned by instances search call. Returned instance matched the search request and contains highlighted text to be displayed to the user if it is set to &#39;true&#39;.
    /// </summary>
    [DataContract]
    public partial class InstanceHit : IEquatable<InstanceHit>
    { 
        /// <summary>
        /// Gets or Sets TimeSeriesId
        /// </summary>

        [DataMember(Name="timeSeriesId")]
        public TimeSeriesId TimeSeriesId { get; set; }

        /// <summary>
        /// Name of the time series instance that matched the search request. May be null.
        /// </summary>
        /// <value>Name of the time series instance that matched the search request. May be null.</value>

        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Represents the type that time series instance which matched the search request belongs to. Never null.
        /// </summary>
        /// <value>Represents the type that time series instance which matched the search request belongs to. Never null.</value>

        [DataMember(Name="typeId")]
        public string TypeId { get; private set; }

        /// <summary>
        /// List of time series hierarchy IDs that time series instance which matched the search request belongs to. Cannot be used to lookup hierarchies. May be null.
        /// </summary>
        /// <value>List of time series hierarchy IDs that time series instance which matched the search request belongs to. Cannot be used to lookup hierarchies. May be null.</value>

        [DataMember(Name="hierarchyIds")]
        public List<string> HierarchyIds { get; private set; }

        /// <summary>
        /// Gets or Sets Highlights
        /// </summary>

        [DataMember(Name="highlights")]
        public InstanceHitHighlights Highlights { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceHit {\n");
            sb.Append("  TimeSeriesId: ").Append(TimeSeriesId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  HierarchyIds: ").Append(HierarchyIds).Append("\n");
            sb.Append("  Highlights: ").Append(Highlights).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstanceHit)obj);
        }

        /// <summary>
        /// Returns true if InstanceHit instances are equal
        /// </summary>
        /// <param name="other">Instance of InstanceHit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceHit other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeSeriesId == other.TimeSeriesId ||
                    TimeSeriesId != null &&
                    TimeSeriesId.Equals(other.TimeSeriesId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    TypeId == other.TypeId ||
                    TypeId != null &&
                    TypeId.Equals(other.TypeId)
                ) && 
                (
                    HierarchyIds == other.HierarchyIds ||
                    HierarchyIds != null &&
                    HierarchyIds.SequenceEqual(other.HierarchyIds)
                ) && 
                (
                    Highlights == other.Highlights ||
                    Highlights != null &&
                    Highlights.Equals(other.Highlights)
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
                    if (TimeSeriesId != null)
                    hashCode = hashCode * 59 + TimeSeriesId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (TypeId != null)
                    hashCode = hashCode * 59 + TypeId.GetHashCode();
                    if (HierarchyIds != null)
                    hashCode = hashCode * 59 + HierarchyIds.GetHashCode();
                    if (Highlights != null)
                    hashCode = hashCode * 59 + Highlights.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstanceHit left, InstanceHit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstanceHit left, InstanceHit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
