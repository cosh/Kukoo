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
    /// Definition of sorting of hierarchy nodes.
    /// </summary>
    [DataContract]
    public partial class HierarchiesSortParameter : IEquatable<HierarchiesSortParameter>
    { 
        /// <summary>
        /// Value to use for hierarchy node sorting. When it is set to 'CumulativeInstanceCount', the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to 'Name', the returned hierarchies are sorted based on the hierarchy name. Optional, default is 'CumulativeInstanceCount'.
        /// </summary>
        /// <value>Value to use for hierarchy node sorting. When it is set to 'CumulativeInstanceCount', the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to 'Name', the returned hierarchies are sorted based on the hierarchy name. Optional, default is 'CumulativeInstanceCount'.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HierarchiesSortByEnum
        {
            
            /// <summary>
            /// Enum CumulativeInstanceCountEnum for CumulativeInstanceCount
            /// </summary>
            [EnumMember(Value = "CumulativeInstanceCount")]
            CumulativeInstanceCountEnum = 1,
            
            /// <summary>
            /// Enum NameEnum for Name
            /// </summary>
            [EnumMember(Value = "Name")]
            NameEnum = 2
        }

        /// <summary>
        /// Value to use for hierarchy node sorting. When it is set to &#39;CumulativeInstanceCount&#39;, the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to &#39;Name&#39;, the returned hierarchies are sorted based on the hierarchy name. Optional, default is &#39;CumulativeInstanceCount&#39;.
        /// </summary>
        /// <value>Value to use for hierarchy node sorting. When it is set to &#39;CumulativeInstanceCount&#39;, the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to &#39;Name&#39;, the returned hierarchies are sorted based on the hierarchy name. Optional, default is &#39;CumulativeInstanceCount&#39;.</value>

        [DataMember(Name="by")]
        public HierarchiesSortByEnum? By { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HierarchiesSortParameter {\n");
            sb.Append("  By: ").Append(By).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HierarchiesSortParameter)obj);
        }

        /// <summary>
        /// Returns true if HierarchiesSortParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of HierarchiesSortParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HierarchiesSortParameter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    By == other.By ||
                    By != null &&
                    By.Equals(other.By)
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
                    if (By != null)
                    hashCode = hashCode * 59 + By.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HierarchiesSortParameter left, HierarchiesSortParameter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HierarchiesSortParameter left, HierarchiesSortParameter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
