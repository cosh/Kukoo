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
    /// Time series type defines variables or formulas for doing computation on events associated with time series instances. Each time series instance is associated with exactly one type. A type can have one or more variables. For example, a time series instance might be of type Temperature Sensor, which consists of the variables avg temperature, min temperature, and max temperature.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesType : IEquatable<TimeSeriesType>
    { 
        /// <summary>
        /// Case-sensitive unique type identifier that is immutable. Can be null on create or update requests, and then server generates the ID. Not null on get and delete operations.
        /// </summary>
        /// <value>Case-sensitive unique type identifier that is immutable. Can be null on create or update requests, and then server generates the ID. Not null on get and delete operations.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// User-given unique name for the type. Mutable, not null.
        /// </summary>
        /// <value>User-given unique name for the type. Mutable, not null.</value>
        [Required]
        
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the type. May be null.
        /// </summary>
        /// <value>Description of the type. May be null.</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Different variables associated with the type. Not empty, not null.
        /// </summary>
        /// <value>Different variables associated with the type. Not empty, not null.</value>
        [Required]
        
        [DataMember(Name="variables")]
        public Object Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesType)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesType instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Variables == other.Variables ||
                    Variables != null &&
                    Variables.Equals(other.Variables)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Variables != null)
                    hashCode = hashCode * 59 + Variables.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesType left, TimeSeriesType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesType left, TimeSeriesType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
