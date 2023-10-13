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
    /// Partial list of time series instances returned in a single request.
    /// </summary>
    [DataContract]
    public partial class GetInstancesPage : PagedResponse, IEquatable<GetInstancesPage>
    { 
        /// <summary>
        /// Partial list of time series instances returned in a single request. Can be empty if server was unable to fill the page in this request, or there is no more objects when continuation token is null.
        /// </summary>
        /// <value>Partial list of time series instances returned in a single request. Can be empty if server was unable to fill the page in this request, or there is no more objects when continuation token is null.</value>

        [DataMember(Name="instances")]
        public List<TimeSeriesInstance> Instances { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInstancesPage {\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetInstancesPage)obj);
        }

        /// <summary>
        /// Returns true if GetInstancesPage instances are equal
        /// </summary>
        /// <param name="other">Instance of GetInstancesPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInstancesPage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Instances == other.Instances ||
                    Instances != null &&
                    Instances.SequenceEqual(other.Instances)
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
                    if (Instances != null)
                    hashCode = hashCode * 59 + Instances.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetInstancesPage left, GetInstancesPage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetInstancesPage left, GetInstancesPage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
