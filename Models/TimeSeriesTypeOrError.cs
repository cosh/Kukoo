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
    /// Result of a batch operation on a particular time series type. Type object is set when operation is successful and error object is set when operation is unsuccessful.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesTypeOrError : IEquatable<TimeSeriesTypeOrError>
    { 
        /// <summary>
        /// Gets or Sets TimeSeriesType
        /// </summary>

        [DataMember(Name="timeSeriesType")]
        public TimeSeriesType TimeSeriesType { get; set; }

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
            sb.Append("class TimeSeriesTypeOrError {\n");
            sb.Append("  TimeSeriesType: ").Append(TimeSeriesType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesTypeOrError)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesTypeOrError instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesTypeOrError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesTypeOrError other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeSeriesType == other.TimeSeriesType ||
                    TimeSeriesType != null &&
                    TimeSeriesType.Equals(other.TimeSeriesType)
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
                    if (TimeSeriesType != null)
                    hashCode = hashCode * 59 + TimeSeriesType.GetHashCode();
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesTypeOrError left, TimeSeriesTypeOrError right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesTypeOrError left, TimeSeriesTypeOrError right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
