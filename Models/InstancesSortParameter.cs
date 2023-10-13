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
    /// Definition of how time series instances are sorted before being returned by search instances call.
    /// </summary>
    [DataContract]
    public partial class InstancesSortParameter : IEquatable<InstancesSortParameter>
    { 
        /// <summary>
        /// Value to use for sorting of the time series instances before being returned by search instances call. When it is set to 'Rank', the returned instances are sorted based on the relevance. When it is set to 'DisplayName', the returned results are sorted based on the display name. Display name is the name of the instance if it exists, otherwise, display name is the time series ID. Default is 'Rank'.
        /// </summary>
        /// <value>Value to use for sorting of the time series instances before being returned by search instances call. When it is set to 'Rank', the returned instances are sorted based on the relevance. When it is set to 'DisplayName', the returned results are sorted based on the display name. Display name is the name of the instance if it exists, otherwise, display name is the time series ID. Default is 'Rank'.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum InstanceSortByEnum
        {
            
            /// <summary>
            /// Enum RankEnum for Rank
            /// </summary>
            [EnumMember(Value = "Rank")]
            RankEnum = 1,
            
            /// <summary>
            /// Enum DisplayNameEnum for DisplayName
            /// </summary>
            [EnumMember(Value = "DisplayName")]
            DisplayNameEnum = 2
        }

        /// <summary>
        /// Value to use for sorting of the time series instances before being returned by search instances call. When it is set to &#39;Rank&#39;, the returned instances are sorted based on the relevance. When it is set to &#39;DisplayName&#39;, the returned results are sorted based on the display name. Display name is the name of the instance if it exists, otherwise, display name is the time series ID. Default is &#39;Rank&#39;.
        /// </summary>
        /// <value>Value to use for sorting of the time series instances before being returned by search instances call. When it is set to &#39;Rank&#39;, the returned instances are sorted based on the relevance. When it is set to &#39;DisplayName&#39;, the returned results are sorted based on the display name. Display name is the name of the instance if it exists, otherwise, display name is the time series ID. Default is &#39;Rank&#39;.</value>

        [DataMember(Name="by")]
        public InstanceSortByEnum? By { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancesSortParameter {\n");
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
            return obj.GetType() == GetType() && Equals((InstancesSortParameter)obj);
        }

        /// <summary>
        /// Returns true if InstancesSortParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of InstancesSortParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancesSortParameter other)
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

        public static bool operator ==(InstancesSortParameter left, InstancesSortParameter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InstancesSortParameter left, InstancesSortParameter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
