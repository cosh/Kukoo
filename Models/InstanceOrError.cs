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
    /// Result of a batch operation on a particular time series instance. Instance object is set when operation is successful (except put operation) and error object is set when operation is unsuccessful.
    /// </summary>
    [DataContract]
    public partial class InstanceOrError : IEquatable<InstanceOrError>
    { 
        /// <summary>
        /// Gets or Sets Instance
        /// </summary>

        [DataMember(Name="instance")]
        public TimeSeriesInstance Instance { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>

        [DataMember(Name="error")]
        public TsiErrorBody Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceOrError {\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InstanceOrError)obj);
        }

        /// <summary>
        /// Returns true if InstanceOrError instances are equal
        /// </summary>
        /// <param name="other">Instance of InstanceOrError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceOrError other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Instance == other.Instance ||
                    Instance != null &&
                    Instance.Equals(other.Instance)
                ) && 
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error)
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
                    if (Instance != null)
                    hashCode = hashCode * 59 + Instance.GetHashCode();
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InstanceOrError left, InstanceOrError right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstanceOrError left, InstanceOrError right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
