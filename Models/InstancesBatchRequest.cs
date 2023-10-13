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
    /// Request to perform a single operation on a batch of instances. Exactly one of \&quot;get\&quot;, \&quot;put\&quot;, \&quot;update\&quot; or \&quot;delete\&quot; must be set.
    /// </summary>
    [DataContract]
    public partial class InstancesBatchRequest : IEquatable<InstancesBatchRequest>
    { 
        /// <summary>
        /// Gets or Sets Get
        /// </summary>

        [DataMember(Name="get")]
        public InstancesRequestBatchGetOrDelete Get { get; set; }

        /// <summary>
        /// Time series instances to be created or updated.
        /// </summary>
        /// <value>Time series instances to be created or updated.</value>

        [DataMember(Name="put")]
        public List<TimeSeriesInstance> Put { get; set; }

        /// <summary>
        /// Time series instance to be updated. If instance does not exist, an error is returned.
        /// </summary>
        /// <value>Time series instance to be updated. If instance does not exist, an error is returned.</value>

        [DataMember(Name="update")]
        public List<TimeSeriesInstance> Update { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>

        [DataMember(Name="delete")]
        public InstancesRequestBatchGetOrDelete Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesBatchRequest {\n");
            sb.Append("  Get: ").Append(Get).Append("\n");
            sb.Append("  Put: ").Append(Put).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstancesBatchRequest)obj);
        }

        /// <summary>
        /// Returns true if InstancesBatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InstancesBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesBatchRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Get == other.Get ||
                    Get != null &&
                    Get.Equals(other.Get)
                ) && 
                (
                    Put == other.Put ||
                    Put != null &&
                    Put.SequenceEqual(other.Put)
                ) && 
                (
                    Update == other.Update ||
                    Update != null &&
                    Update.SequenceEqual(other.Update)
                ) && 
                (
                    Delete == other.Delete ||
                    Delete != null &&
                    Delete.Equals(other.Delete)
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
                    if (Get != null)
                    hashCode = hashCode * 59 + Get.GetHashCode();
                    if (Put != null)
                    hashCode = hashCode * 59 + Put.GetHashCode();
                    if (Update != null)
                    hashCode = hashCode * 59 + Update.GetHashCode();
                    if (Delete != null)
                    hashCode = hashCode * 59 + Delete.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstancesBatchRequest left, InstancesBatchRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstancesBatchRequest left, InstancesBatchRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
