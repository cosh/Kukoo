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
    /// Request to get or delete instances by time series IDs or time series names. Exactly one of \&quot;timeSeriesIds\&quot; or \&quot;names\&quot; must be set.
    /// </summary>
    [DataContract]
    public partial class InstancesRequestBatchGetOrDelete : IEquatable<InstancesRequestBatchGetOrDelete>
    { 
        /// <summary>
        /// List of time series IDs of the time series instances to return or delete.
        /// </summary>
        /// <value>List of time series IDs of the time series instances to return or delete.</value>

        [DataMember(Name="timeSeriesIds")]
        public List<TimeSeriesId> TimeSeriesIds { get; set; }

        /// <summary>
        /// List of names of the time series instances to return or delete.
        /// </summary>
        /// <value>List of names of the time series instances to return or delete.</value>

        [DataMember(Name="names")]
        public List<string> Names { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesRequestBatchGetOrDelete {\n");
            sb.Append("  TimeSeriesIds: ").Append(TimeSeriesIds).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstancesRequestBatchGetOrDelete)obj);
        }

        /// <summary>
        /// Returns true if InstancesRequestBatchGetOrDelete instances are equal
        /// </summary>
        /// <param name="other">Instance of InstancesRequestBatchGetOrDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesRequestBatchGetOrDelete other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeSeriesIds == other.TimeSeriesIds ||
                    TimeSeriesIds != null &&
                    TimeSeriesIds.SequenceEqual(other.TimeSeriesIds)
                ) && 
                (
                    Names == other.Names ||
                    Names != null &&
                    Names.SequenceEqual(other.Names)
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
                    if (TimeSeriesIds != null)
                    hashCode = hashCode * 59 + TimeSeriesIds.GetHashCode();
                    if (Names != null)
                    hashCode = hashCode * 59 + Names.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstancesRequestBatchGetOrDelete left, InstancesRequestBatchGetOrDelete right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstancesRequestBatchGetOrDelete left, InstancesRequestBatchGetOrDelete right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
