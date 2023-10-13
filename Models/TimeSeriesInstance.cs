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
    /// Time series instances are the time series themselves. In most cases, the deviceId or assetId is the unique identifier of the asset in the environment. Instances have descriptive information associated with them called instance fields. At a minimum, instance fields include hierarchy information. They can also include useful, descriptive data like the manufacturer, operator, or the last service date.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesInstance : IEquatable<TimeSeriesInstance>
    { 
        /// <summary>
        /// Gets or Sets TimeSeriesId
        /// </summary>
        [Required]
        
        [DataMember(Name="timeSeriesId")]
        public TimeSeriesId TimeSeriesId { get; set; }

        /// <summary>
        /// This represents the type that this instance belongs to. Never null.
        /// </summary>
        /// <value>This represents the type that this instance belongs to. Never null.</value>
        [Required]
        
        [DataMember(Name="typeId")]
        public string TypeId { get; set; }

        /// <summary>
        /// Optional name of the instance which is unique in an environment. Names acts as a mutable alias or display name of the time series instance. Mutable, may be null.
        /// </summary>
        /// <value>Optional name of the instance which is unique in an environment. Names acts as a mutable alias or display name of the time series instance. Mutable, may be null.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// This optional field contains description about the instance.
        /// </summary>
        /// <value>This optional field contains description about the instance.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of time series hierarchy IDs that the instance belong to. May be null.
        /// </summary>
        /// <value>Set of time series hierarchy IDs that the instance belong to. May be null.</value>

        [DataMember(Name="hierarchyIds")]
        public List<string> HierarchyIds { get; set; }

        /// <summary>
        /// Set of key-value pairs that contain user-defined instance properties. It may be null. Supported property value types are: bool, string, long, double and it cannot be nested or null.
        /// </summary>
        /// <value>Set of key-value pairs that contain user-defined instance properties. It may be null. Supported property value types are: bool, string, long, double and it cannot be nested or null.</value>

        [DataMember(Name="instanceFields")]
        public Dictionary<string, Object> InstanceFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesInstance {\n");
            sb.Append("  TimeSeriesId: ").Append(TimeSeriesId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HierarchyIds: ").Append(HierarchyIds).Append("\n");
            sb.Append("  InstanceFields: ").Append(InstanceFields).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesInstance)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesInstance other)
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
                    TypeId == other.TypeId ||
                    TypeId != null &&
                    TypeId.Equals(other.TypeId)
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
                    InstanceFields == other.InstanceFields ||
                    InstanceFields != null &&
                    InstanceFields.SequenceEqual(other.InstanceFields)
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
                    if (TypeId != null)
                    hashCode = hashCode * 59 + TypeId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (HierarchyIds != null)
                    hashCode = hashCode * 59 + HierarchyIds.GetHashCode();
                    if (InstanceFields != null)
                    hashCode = hashCode * 59 + InstanceFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesInstance left, TimeSeriesInstance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesInstance left, TimeSeriesInstance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
