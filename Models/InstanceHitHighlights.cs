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
    /// Highlighted text of time series instance to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use any of the highlighted properties to do further API calls.
    /// </summary>
    [DataContract]
    public partial class InstanceHitHighlights : IEquatable<InstanceHitHighlights>
    { 
        /// <summary>
        /// List of highlighted string values of Time Series ID for displaying. Cannot be used to lookup instance.
        /// </summary>
        /// <value>List of highlighted string values of Time Series ID for displaying. Cannot be used to lookup instance.</value>

        [DataMember(Name="timeSeriesId")]
        public List<string> TimeSeriesId { get; private set; }

        /// <summary>
        /// Highlighted time series type name that this instance belongs to.
        /// </summary>
        /// <value>Highlighted time series type name that this instance belongs to.</value>

        [DataMember(Name="typeName")]
        public string TypeName { get; private set; }

        /// <summary>
        /// Highlighted name of time series instance. May be null.
        /// </summary>
        /// <value>Highlighted name of time series instance. May be null.</value>

        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Highlighted description of time series instance. May be null.
        /// </summary>
        /// <value>Highlighted description of time series instance. May be null.</value>

        [DataMember(Name="description")]
        public string Description { get; private set; }

        /// <summary>
        /// List of highlighted time series hierarchy IDs that time series instance belongs to. Cannot be used to lookup hierarchies. May be null.
        /// </summary>
        /// <value>List of highlighted time series hierarchy IDs that time series instance belongs to. Cannot be used to lookup hierarchies. May be null.</value>

        [DataMember(Name="hierarchyIds")]
        public List<string> HierarchyIds { get; private set; }

        /// <summary>
        /// List of highlighted time series hierarchy names that time series instance belongs to. Cannot be used to lookup hierarchies. May be null.
        /// </summary>
        /// <value>List of highlighted time series hierarchy names that time series instance belongs to. Cannot be used to lookup hierarchies. May be null.</value>

        [DataMember(Name="hierarchyNames")]
        public List<string> HierarchyNames { get; private set; }

        /// <summary>
        /// List of highlighted time series instance field names. May be null.
        /// </summary>
        /// <value>List of highlighted time series instance field names. May be null.</value>

        [DataMember(Name="instanceFieldNames")]
        public List<string> InstanceFieldNames { get; private set; }

        /// <summary>
        /// List of highlighted time series instance field values. May be null.
        /// </summary>
        /// <value>List of highlighted time series instance field values. May be null.</value>

        [DataMember(Name="instanceFieldValues")]
        public List<string> InstanceFieldValues { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceHitHighlights {\n");
            sb.Append("  TimeSeriesId: ").Append(TimeSeriesId).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HierarchyIds: ").Append(HierarchyIds).Append("\n");
            sb.Append("  HierarchyNames: ").Append(HierarchyNames).Append("\n");
            sb.Append("  InstanceFieldNames: ").Append(InstanceFieldNames).Append("\n");
            sb.Append("  InstanceFieldValues: ").Append(InstanceFieldValues).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstanceHitHighlights)obj);
        }

        /// <summary>
        /// Returns true if InstanceHitHighlights instances are equal
        /// </summary>
        /// <param name="other">Instance of InstanceHitHighlights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceHitHighlights other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeSeriesId == other.TimeSeriesId ||
                    TimeSeriesId != null &&
                    TimeSeriesId.SequenceEqual(other.TimeSeriesId)
                ) && 
                (
                    TypeName == other.TypeName ||
                    TypeName != null &&
                    TypeName.Equals(other.TypeName)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    HierarchyIds == other.HierarchyIds ||
                    HierarchyIds != null &&
                    HierarchyIds.SequenceEqual(other.HierarchyIds)
                ) && 
                (
                    HierarchyNames == other.HierarchyNames ||
                    HierarchyNames != null &&
                    HierarchyNames.SequenceEqual(other.HierarchyNames)
                ) && 
                (
                    InstanceFieldNames == other.InstanceFieldNames ||
                    InstanceFieldNames != null &&
                    InstanceFieldNames.SequenceEqual(other.InstanceFieldNames)
                ) && 
                (
                    InstanceFieldValues == other.InstanceFieldValues ||
                    InstanceFieldValues != null &&
                    InstanceFieldValues.SequenceEqual(other.InstanceFieldValues)
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
                    if (TypeName != null)
                    hashCode = hashCode * 59 + TypeName.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (HierarchyIds != null)
                    hashCode = hashCode * 59 + HierarchyIds.GetHashCode();
                    if (HierarchyNames != null)
                    hashCode = hashCode * 59 + HierarchyNames.GetHashCode();
                    if (InstanceFieldNames != null)
                    hashCode = hashCode * 59 + InstanceFieldNames.GetHashCode();
                    if (InstanceFieldValues != null)
                    hashCode = hashCode * 59 + InstanceFieldValues.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstanceHitHighlights left, InstanceHitHighlights right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstanceHitHighlights left, InstanceHitHighlights right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
