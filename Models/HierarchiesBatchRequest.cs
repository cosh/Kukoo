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
    /// Request to perform a single operation on a batch of hierarchies. Exactly one of \&quot;get\&quot;, \&quot;put\&quot; or \&quot;delete\&quot; must be set.
    /// </summary>
    [DataContract]
    public partial class HierarchiesBatchRequest : IEquatable<HierarchiesBatchRequest>
    { 
        /// <summary>
        /// Gets or Sets Get
        /// </summary>

        [DataMember(Name="get")]
        public HierarchiesRequestBatchGetDelete Get { get; set; }

        /// <summary>
        /// \&quot;put\&quot; should be set while creating or updating hierarchies.
        /// </summary>
        /// <value>\&quot;put\&quot; should be set while creating or updating hierarchies.</value>

        [DataMember(Name="put")]
        public List<TimeSeriesHierarchy> Put { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>

        [DataMember(Name="delete")]
        public HierarchiesRequestBatchGetDelete Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HierarchiesBatchRequest {\n");
            sb.Append("  Get: ").Append(Get).Append("\n");
            sb.Append("  Put: ").Append(Put).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HierarchiesBatchRequest)obj);
        }

        /// <summary>
        /// Returns true if HierarchiesBatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of HierarchiesBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HierarchiesBatchRequest other)
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
                    if (Delete != null)
                    hashCode = hashCode * 59 + Delete.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HierarchiesBatchRequest left, HierarchiesBatchRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HierarchiesBatchRequest left, HierarchiesBatchRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
