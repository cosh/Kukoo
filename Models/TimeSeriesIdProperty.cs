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
    /// A definition of a single property that can be used in time series ID properties defined during environment creation.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesIdProperty : IEquatable<TimeSeriesIdProperty>
    { 
        /// <summary>
        /// The name of the property.
        /// </summary>
        /// <value>The name of the property.</value>

        [DataMember(Name="name")]
        public string Name { get; private set; }

        /// <summary>
        /// The type of the property. Currently, only \"String\" is supported.
        /// </summary>
        /// <value>The type of the property. Currently, only \"String\" is supported.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum StringEnum for String
            /// </summary>
            [EnumMember(Value = "String")]
            StringEnum = 1
        }

        /// <summary>
        /// The type of the property. Currently, only \&quot;String\&quot; is supported.
        /// </summary>
        /// <value>The type of the property. Currently, only \&quot;String\&quot; is supported.</value>

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesIdProperty {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesIdProperty)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesIdProperty instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesIdProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesIdProperty other)
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
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesIdProperty left, TimeSeriesIdProperty right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesIdProperty left, TimeSeriesIdProperty right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
