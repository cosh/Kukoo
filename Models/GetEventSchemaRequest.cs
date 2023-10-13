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
    /// Request to get the event schema of all events within a given search span.
    /// </summary>
    [DataContract]
    public partial class GetEventSchemaRequest : IEquatable<GetEventSchemaRequest>
    { 
        /// <summary>
        /// The range of time on which the query is executed. Cannot be null.
        /// </summary>
        /// <value>The range of time on which the query is executed. Cannot be null.</value>
        [Required]
        
        [DataMember(Name="searchSpan")]
        public DateTimeRange SearchSpan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEventSchemaRequest {\n");
            sb.Append("  SearchSpan: ").Append(SearchSpan).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetEventSchemaRequest)obj);
        }

        /// <summary>
        /// Returns true if GetEventSchemaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GetEventSchemaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEventSchemaRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SearchSpan == other.SearchSpan ||
                    SearchSpan != null &&
                    SearchSpan.Equals(other.SearchSpan)
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
                    if (SearchSpan != null)
                    hashCode = hashCode * 59 + SearchSpan.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetEventSchemaRequest left, GetEventSchemaRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetEventSchemaRequest left, GetEventSchemaRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
