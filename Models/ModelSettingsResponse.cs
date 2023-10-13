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
    /// Response containing full time series model settings which include model name, Time Series ID properties and default type ID.
    /// </summary>
    [DataContract]
    public partial class ModelSettingsResponse : IEquatable<ModelSettingsResponse>
    { 
        /// <summary>
        /// Gets or Sets ModelSettings
        /// </summary>

        [DataMember(Name="modelSettings")]
        public TimeSeriesModelSettings ModelSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelSettingsResponse {\n");
            sb.Append("  ModelSettings: ").Append(ModelSettings).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ModelSettingsResponse)obj);
        }

        /// <summary>
        /// Returns true if ModelSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelSettingsResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ModelSettings == other.ModelSettings ||
                    ModelSettings != null &&
                    ModelSettings.Equals(other.ModelSettings)
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
                    if (ModelSettings != null)
                    hashCode = hashCode * 59 + ModelSettings.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ModelSettingsResponse left, ModelSettingsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ModelSettingsResponse left, ModelSettingsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
