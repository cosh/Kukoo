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
    /// Event availability information when environment contains events. Contains time range of events and approximate distribution of events over time.
    /// </summary>
    [DataContract]
    public partial class Availability : IEquatable<Availability>
    { 
        /// <summary>
        /// Minimum and maximum values of event timestamp ($ts) property.
        /// </summary>
        /// <value>Minimum and maximum values of event timestamp ($ts) property.</value>

        [DataMember(Name="range")]
        public DateTimeRange Range { get; private set; }

        /// <summary>
        /// Interval size for the returned distribution of the events. Returned interval is selected to return a reasonable number of points. All intervals are the same size. On the wire interval is specified in ISO-8601 duration format. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is \&quot;PT1M\&quot;, 1 millisecond is \&quot;PT0.001S\&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration
        /// </summary>
        /// <value>Interval size for the returned distribution of the events. Returned interval is selected to return a reasonable number of points. All intervals are the same size. On the wire interval is specified in ISO-8601 duration format. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is \&quot;PT1M\&quot;, 1 millisecond is \&quot;PT0.001S\&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration</value>

        [DataMember(Name="intervalSize")]
        public string IntervalSize { get; private set; }

        /// <summary>
        /// Gets or Sets Distribution
        /// </summary>

        [DataMember(Name="distribution")]
        public Object Distribution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Availability {\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  IntervalSize: ").Append(IntervalSize).Append("\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Availability)obj);
        }

        /// <summary>
        /// Returns true if Availability instances are equal
        /// </summary>
        /// <param name="other">Instance of Availability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Availability other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Range == other.Range ||
                    Range != null &&
                    Range.Equals(other.Range)
                ) && 
                (
                    IntervalSize == other.IntervalSize ||
                    IntervalSize != null &&
                    IntervalSize.Equals(other.IntervalSize)
                ) && 
                (
                    Distribution == other.Distribution ||
                    Distribution != null &&
                    Distribution.Equals(other.Distribution)
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
                    if (Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();
                    if (IntervalSize != null)
                    hashCode = hashCode * 59 + IntervalSize.GetHashCode();
                    if (Distribution != null)
                    hashCode = hashCode * 59 + Distribution.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Availability left, Availability right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Availability left, Availability right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
