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
    /// Time series model settings including model name, Time Series ID properties and default type ID.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesModelSettings : IEquatable<TimeSeriesModelSettings>
    { 
        /// <summary>
        /// Time series model display name which is shown in the UX. Examples: \&quot;Temperature Sensors\&quot;, \&quot;MyDevices\&quot;.
        /// </summary>
        /// <value>Time series model display name which is shown in the UX. Examples: \&quot;Temperature Sensors\&quot;, \&quot;MyDevices\&quot;.</value>

        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets TimeSeriesIdProperties
        /// </summary>

        [DataMember(Name="timeSeriesIdProperties")]
        public TimeSeriesIdProperties TimeSeriesIdProperties { get; set; }

        /// <summary>
        /// Default type ID of the model that new time series instances will automatically belong to.
        /// </summary>
        /// <value>Default type ID of the model that new time series instances will automatically belong to.</value>

        [DataMember(Name="defaultTypeId")]
        public string DefaultTypeId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesModelSettings {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TimeSeriesIdProperties: ").Append(TimeSeriesIdProperties).Append("\n");
            sb.Append("  DefaultTypeId: ").Append(DefaultTypeId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesModelSettings)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesModelSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesModelSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesModelSettings other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    TimeSeriesIdProperties == other.TimeSeriesIdProperties ||
                    TimeSeriesIdProperties != null &&
                    TimeSeriesIdProperties.Equals(other.TimeSeriesIdProperties)
                ) && 
                (
                    DefaultTypeId == other.DefaultTypeId ||
                    DefaultTypeId != null &&
                    DefaultTypeId.Equals(other.DefaultTypeId)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (TimeSeriesIdProperties != null)
                    hashCode = hashCode * 59 + TimeSeriesIdProperties.GetHashCode();
                    if (DefaultTypeId != null)
                    hashCode = hashCode * 59 + DefaultTypeId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesModelSettings left, TimeSeriesModelSettings right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesModelSettings left, TimeSeriesModelSettings right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
