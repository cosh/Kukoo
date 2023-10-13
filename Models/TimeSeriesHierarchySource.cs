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
    /// Definition of how time series hierarchy tree levels are created.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesHierarchySource : IEquatable<TimeSeriesHierarchySource>
    { 
        /// <summary>
        /// List of instance field names that must be set in all time series instances that belong to this hierarchy. The order of the instance fields defines the levels in the hierarchy.
        /// </summary>
        /// <value>List of instance field names that must be set in all time series instances that belong to this hierarchy. The order of the instance fields defines the levels in the hierarchy.</value>

        [DataMember(Name="instanceFieldNames")]
        public List<string> InstanceFieldNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesHierarchySource {\n");
            sb.Append("  InstanceFieldNames: ").Append(InstanceFieldNames).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesHierarchySource)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesHierarchySource instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesHierarchySource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesHierarchySource other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InstanceFieldNames == other.InstanceFieldNames ||
                    InstanceFieldNames != null &&
                    InstanceFieldNames.SequenceEqual(other.InstanceFieldNames)
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
                    if (InstanceFieldNames != null)
                    hashCode = hashCode * 59 + InstanceFieldNames.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesHierarchySource left, TimeSeriesHierarchySource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesHierarchySource left, TimeSeriesHierarchySource right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
