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
    /// Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property.
    /// </summary>
    [DataContract]
    public partial class PropertyValues : EventProperty, IEquatable<PropertyValues>
    { 
        /// <summary>
        /// Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property.
        /// </summary>
        /// <value>Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property.</value>

        [DataMember(Name="values")]
        public List<Object> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyValues {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((PropertyValues)obj);
        }

        /// <summary>
        /// Returns true if PropertyValues instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyValues other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Values == other.Values ||
                    Values != null &&
                    Values.SequenceEqual(other.Values)
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
                    if (Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PropertyValues left, PropertyValues right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PropertyValues left, PropertyValues right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
