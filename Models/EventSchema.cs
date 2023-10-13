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
    /// Event schema of all events within a given search span. Event schema is a set of property definitions. Properties are identified by both name and type. Different events can have properties with same name, but different type. Event schema may not be contain all persisted properties when there are too many properties.
    /// </summary>
    [DataContract]
    public partial class EventSchema : IEquatable<EventSchema>
    { 
        /// <summary>
        /// A set of property definitions. When environment has no data, the returned array is empty.
        /// </summary>
        /// <value>A set of property definitions. When environment has no data, the returned array is empty.</value>

        [DataMember(Name="properties")]
        public List<EventProperty> Properties { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventSchema {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EventSchema)obj);
        }

        /// <summary>
        /// Returns true if EventSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of EventSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventSchema other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Properties == other.Properties ||
                    Properties != null &&
                    Properties.SequenceEqual(other.Properties)
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
                    if (Properties != null)
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EventSchema left, EventSchema right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventSchema left, EventSchema right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
