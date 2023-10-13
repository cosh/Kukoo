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
    /// Request to get or delete multiple time series hierarchies. Exactly one of \&quot;hierarchyIds\&quot; or \&quot;names\&quot; must be set.
    /// </summary>
    [DataContract]
    public partial class HierarchiesRequestBatchGetDelete : IEquatable<HierarchiesRequestBatchGetDelete>
    { 
        /// <summary>
        /// List of hierarchy IDs.
        /// </summary>
        /// <value>List of hierarchy IDs.</value>

        [DataMember(Name="hierarchyIds")]
        public List<string> HierarchyIds { get; set; }

        /// <summary>
        /// List of hierarchy names.
        /// </summary>
        /// <value>List of hierarchy names.</value>

        [DataMember(Name="names")]
        public List<string> Names { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HierarchiesRequestBatchGetDelete {\n");
            sb.Append("  HierarchyIds: ").Append(HierarchyIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HierarchiesRequestBatchGetDelete)obj);
        }

        /// <summary>
        /// Returns true if HierarchiesRequestBatchGetDelete instances are equal
        /// </summary>
        /// <param name="other">Instance of HierarchiesRequestBatchGetDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HierarchiesRequestBatchGetDelete other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HierarchyIds == other.HierarchyIds ||
                    HierarchyIds != null &&
                    HierarchyIds.SequenceEqual(other.HierarchyIds)
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
                    if (HierarchyIds != null)
                    hashCode = hashCode * 59 + HierarchyIds.GetHashCode();
                    if (Names != null)
                    hashCode = hashCode * 59 + Names.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HierarchiesRequestBatchGetDelete left, HierarchiesRequestBatchGetDelete right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HierarchiesRequestBatchGetDelete left, HierarchiesRequestBatchGetDelete right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
