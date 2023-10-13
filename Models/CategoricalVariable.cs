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
    /// Categorical variable represents signal that needs to be analyzed based on the count or duration of occurrence of limited set of defined values.
    /// </summary>
    [DataContract]
    public partial class CategoricalVariable : Variable, IEquatable<CategoricalVariable>
    { 
        /// <summary>
        /// Gets or Sets Value
        /// </summary>

        [DataMember(Name="value")]
        public Tsx Value { get; set; }

        /// <summary>
        /// Gets or Sets Interpolation
        /// </summary>

        [DataMember(Name="interpolation")]
        public Interpolation Interpolation { get; set; }

        /// <summary>
        /// &lt;This property needs a description&gt;
        /// </summary>
        /// <value>&lt;This property needs a description&gt;</value>

        [DataMember(Name="categories")]
        public List<TimeSeriesAggregateCategory> Categories { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCategory
        /// </summary>

        [DataMember(Name="defaultCategory")]
        public TimeSeriesDefaultCategory DefaultCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoricalVariable {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Interpolation: ").Append(Interpolation).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  DefaultCategory: ").Append(DefaultCategory).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CategoricalVariable)obj);
        }

        /// <summary>
        /// Returns true if CategoricalVariable instances are equal
        /// </summary>
        /// <param name="other">Instance of CategoricalVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoricalVariable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Interpolation == other.Interpolation ||
                    Interpolation != null &&
                    Interpolation.Equals(other.Interpolation)
                ) && 
                (
                    Categories == other.Categories ||
                    Categories != null &&
                    Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    DefaultCategory == other.DefaultCategory ||
                    DefaultCategory != null &&
                    DefaultCategory.Equals(other.DefaultCategory)
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
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Interpolation != null)
                    hashCode = hashCode * 59 + Interpolation.GetHashCode();
                    if (Categories != null)
                    hashCode = hashCode * 59 + Categories.GetHashCode();
                    if (DefaultCategory != null)
                    hashCode = hashCode * 59 + DefaultCategory.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CategoricalVariable left, CategoricalVariable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CategoricalVariable left, CategoricalVariable right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
