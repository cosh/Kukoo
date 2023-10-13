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
    /// Definition of whether to expand hierarchy nodes in the same search instances call.
    /// </summary>
    [DataContract]
    public partial class HierarchiesExpandParameter : IEquatable<HierarchiesExpandParameter>
    { 
        /// <summary>
        /// Kind of the expansion of hierarchy nodes. When it is set to 'UntilChildren', the hierarchy nodes are expanded recursively until there is more than one child. When it is set to 'OneLevel', the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is 'UntilChildren'.
        /// </summary>
        /// <value>Kind of the expansion of hierarchy nodes. When it is set to 'UntilChildren', the hierarchy nodes are expanded recursively until there is more than one child. When it is set to 'OneLevel', the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is 'UntilChildren'.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum KindEnum
        {
            
            /// <summary>
            /// Enum UntilChildrenEnum for UntilChildren
            /// </summary>
            [EnumMember(Value = "UntilChildren")]
            UntilChildrenEnum = 1,
            
            /// <summary>
            /// Enum OneLevelEnum for OneLevel
            /// </summary>
            [EnumMember(Value = "OneLevel")]
            OneLevelEnum = 2
        }

        /// <summary>
        /// Kind of the expansion of hierarchy nodes. When it is set to &#39;UntilChildren&#39;, the hierarchy nodes are expanded recursively until there is more than one child. When it is set to &#39;OneLevel&#39;, the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is &#39;UntilChildren&#39;.
        /// </summary>
        /// <value>Kind of the expansion of hierarchy nodes. When it is set to &#39;UntilChildren&#39;, the hierarchy nodes are expanded recursively until there is more than one child. When it is set to &#39;OneLevel&#39;, the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is &#39;UntilChildren&#39;.</value>

        [DataMember(Name="kind")]
        public KindEnum? Kind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HierarchiesExpandParameter {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HierarchiesExpandParameter)obj);
        }

        /// <summary>
        /// Returns true if HierarchiesExpandParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of HierarchiesExpandParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HierarchiesExpandParameter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Kind == other.Kind ||
                    Kind != null &&
                    Kind.Equals(other.Kind)
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
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HierarchiesExpandParameter left, HierarchiesExpandParameter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HierarchiesExpandParameter left, HierarchiesExpandParameter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
