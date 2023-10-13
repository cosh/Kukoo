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
    /// Request to execute a time series query over events. Exactly one of \&quot;getEvents\&quot;, \&quot;getSeries\&quot; or \&quot;aggregateSeries\&quot; must be set.
    /// </summary>
    [DataContract]
    public partial class QueryRequest : IEquatable<QueryRequest>
    { 
        /// <summary>
        /// Get Events query. Allows to retrieve raw events for a given Time Series ID and search span.
        /// </summary>
        /// <value>Get Events query. Allows to retrieve raw events for a given Time Series ID and search span.</value>

        [DataMember(Name="getEvents")]
        public GetEvents GetEvents { get; set; }

        /// <summary>
        /// Get Series query. Allows to retrieve time series of calculated variable values from events for a given Time Series ID and search span.
        /// </summary>
        /// <value>Get Series query. Allows to retrieve time series of calculated variable values from events for a given Time Series ID and search span.</value>

        [DataMember(Name="getSeries")]
        public GetSeries GetSeries { get; set; }

        /// <summary>
        /// Aggregate Series query. Allows to calculate an aggregated time series from events for a given Time Series ID and search span.
        /// </summary>
        /// <value>Aggregate Series query. Allows to calculate an aggregated time series from events for a given Time Series ID and search span.</value>

        [DataMember(Name="aggregateSeries")]
        public AggregateSeries AggregateSeries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRequest {\n");
            sb.Append("  GetEvents: ").Append(GetEvents).Append("\n");
            sb.Append("  GetSeries: ").Append(GetSeries).Append("\n");
            sb.Append("  AggregateSeries: ").Append(AggregateSeries).Append("\n");
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
            return obj.GetType() == GetType() && Equals((QueryRequest)obj);
        }

        /// <summary>
        /// Returns true if QueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    GetEvents == other.GetEvents ||
                    GetEvents != null &&
                    GetEvents.Equals(other.GetEvents)
                ) && 
                (
                    GetSeries == other.GetSeries ||
                    GetSeries != null &&
                    GetSeries.Equals(other.GetSeries)
                ) && 
                (
                    AggregateSeries == other.AggregateSeries ||
                    AggregateSeries != null &&
                    AggregateSeries.Equals(other.AggregateSeries)
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
                    if (GetEvents != null)
                    hashCode = hashCode * 59 + GetEvents.GetHashCode();
                    if (GetSeries != null)
                    hashCode = hashCode * 59 + GetSeries.GetHashCode();
                    if (AggregateSeries != null)
                    hashCode = hashCode * 59 + AggregateSeries.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(QueryRequest left, QueryRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(QueryRequest left, QueryRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
