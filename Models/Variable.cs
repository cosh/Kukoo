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
    /// Variables are named calculations over values from the events. Time Series Insights variable definitions contain formula and computation rules. Variables are stored in the type definition in Time Series Model and can be provided inline via Query APIs to override the stored definition.
    /// </summary>
    [DataContract]
    public partial class Variable : IEquatable<Variable>
    { 
        /// <summary>
        /// Allowed \&quot;kind\&quot; values are - \&quot;numeric\&quot; or \&quot;aggregate\&quot;. While \&quot;numeric\&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the \&quot;aggregate\&quot; kind lets you directly aggregate on the event properties without specifying value.
        /// </summary>
        /// <value>Allowed \&quot;kind\&quot; values are - \&quot;numeric\&quot; or \&quot;aggregate\&quot;. While \&quot;numeric\&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the \&quot;aggregate\&quot; kind lets you directly aggregate on the event properties without specifying value.</value>
        [Required]
        
        [DataMember(Name="kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>

        [DataMember(Name="filter")]
        public Tsx Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Variable {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Variable)obj);
        }

        /// <summary>
        /// Returns true if Variable instances are equal
        /// </summary>
        /// <param name="other">Instance of Variable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Variable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Kind == other.Kind ||
                    Kind != null &&
                    Kind.Equals(other.Kind)
                ) && 
                (
                    Filter == other.Filter ||
                    Filter != null &&
                    Filter.Equals(other.Filter)
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
                    if (Kind != null)
                    hashCode = hashCode * 59 + Kind.GetHashCode();
                    if (Filter != null)
                    hashCode = hashCode * 59 + Filter.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Variable left, Variable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Variable left, Variable right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
