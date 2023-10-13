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
    /// Response of a single operation on a batch of time series types. Exactly one of \&quot;get\&quot;, \&quot;put\&quot; or \&quot;delete\&quot; will be set.
    /// </summary>
    [DataContract]
    public partial class TypesBatchResponse : IEquatable<TypesBatchResponse>
    { 
        /// <summary>
        /// List of types or error objects corresponding by position to the \&quot;get\&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful.
        /// </summary>
        /// <value>List of types or error objects corresponding by position to the \&quot;get\&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful.</value>

        [DataMember(Name="get")]
        public List<TimeSeriesTypeOrError> Get { get; private set; }

        /// <summary>
        /// List of types or error objects corresponding by position to the \&quot;put\&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful.
        /// </summary>
        /// <value>List of types or error objects corresponding by position to the \&quot;put\&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful.</value>

        [DataMember(Name="put")]
        public List<TimeSeriesTypeOrError> Put { get; private set; }

        /// <summary>
        /// List of error objects corresponding by position to the \&quot;delete\&quot; array in the request - null when the operation is successful.
        /// </summary>
        /// <value>List of error objects corresponding by position to the \&quot;delete\&quot; array in the request - null when the operation is successful.</value>

        [DataMember(Name="delete")]
        public List<TsiErrorBody> Delete { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypesBatchResponse {\n");
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
            return obj.GetType() == GetType() && Equals((TypesBatchResponse)obj);
        }

        /// <summary>
        /// Returns true if TypesBatchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TypesBatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypesBatchResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Get == other.Get ||
                    Get != null &&
                    Get.SequenceEqual(other.Get)
                ) && 
                (
                    Put == other.Put ||
                    Put != null &&
                    Put.SequenceEqual(other.Put)
                ) && 
                (
                    Delete == other.Delete ||
                    Delete != null &&
                    Delete.SequenceEqual(other.Delete)
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

        public static bool operator ==(TypesBatchResponse left, TypesBatchResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TypesBatchResponse left, TypesBatchResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
