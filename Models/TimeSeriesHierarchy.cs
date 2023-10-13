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
    /// Time series hierarchy organizes time series instances into a tree.
    /// </summary>
    [DataContract]
    public partial class TimeSeriesHierarchy : IEquatable<TimeSeriesHierarchy>
    { 
        /// <summary>
        /// Case-sensitive unique hierarchy identifier. Can be null while creating hierarchy objects and then server generates the id, not null on get and delete operations.
        /// </summary>
        /// <value>Case-sensitive unique hierarchy identifier. Can be null while creating hierarchy objects and then server generates the id, not null on get and delete operations.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// User-given unique name for the type. It is mutable and not null.
        /// </summary>
        /// <value>User-given unique name for the type. It is mutable and not null.</value>
        [Required]
        
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [Required]
        
        [DataMember(Name="source")]
        public TimeSeriesHierarchySource Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSeriesHierarchy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeSeriesHierarchy)obj);
        }

        /// <summary>
        /// Returns true if TimeSeriesHierarchy instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeSeriesHierarchy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesHierarchy other)
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
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
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
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeSeriesHierarchy left, TimeSeriesHierarchy right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeSeriesHierarchy left, TimeSeriesHierarchy right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
