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
    /// A single page of query results. If query has not finished yet, a page will have continuation token set. In this case, to get the next page of results, send the same request again with continuation token parameter. If query has completed, the continuation token is null. It is also possible to get an empty page with only continuation token set when no query results have been computed yet. If paging has completed (continuation token is null), then timestamps and properties may be empty if there is no data to return.
    /// </summary>
    [DataContract]
    public partial class QueryResultPage : PagedResponse, IEquatable<QueryResultPage>
    { 
        /// <summary>
        /// The timestamps of the values of the time series. If an aggregation over intervals is used, timestamps represent the start of corresponding intervals. If events are retrieved, timestamps are values of timestamp $ts property of events. Can be null if server was unable to fill the page in this request, or can be empty if there are no more objects when continuation token is null.
        /// </summary>
        /// <value>The timestamps of the values of the time series. If an aggregation over intervals is used, timestamps represent the start of corresponding intervals. If events are retrieved, timestamps are values of timestamp $ts property of events. Can be null if server was unable to fill the page in this request, or can be empty if there are no more objects when continuation token is null.</value>

        [DataMember(Name="timestamps")]
        public List<DateTime?> Timestamps { get; private set; }

        /// <summary>
        /// Collection of time series properties and values for each of the timestamps.  Can be null if server was unable to fill the page in this request, or can be empty if there are no more objects when continuation token is null.
        /// </summary>
        /// <value>Collection of time series properties and values for each of the timestamps.  Can be null if server was unable to fill the page in this request, or can be empty if there are no more objects when continuation token is null.</value>

        [DataMember(Name="properties")]
        public List<PropertyValues> Properties { get; private set; }

        /// <summary>
        /// Approximate progress of the query in percentage. It can be between 0 and 100. When the continuation token in the response is null, the progress is expected to be 100.
        /// </summary>
        /// <value>Approximate progress of the query in percentage. It can be between 0 and 100. When the continuation token in the response is null, the progress is expected to be 100.</value>

        [DataMember(Name="progress")]
        public double? Progress { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResultPage {\n");
            sb.Append("  Timestamps: ").Append(Timestamps).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((QueryResultPage)obj);
        }

        /// <summary>
        /// Returns true if QueryResultPage instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryResultPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResultPage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Timestamps == other.Timestamps ||
                    Timestamps != null &&
                    Timestamps.SequenceEqual(other.Timestamps)
                ) && 
                (
                    Properties == other.Properties ||
                    Properties != null &&
                    Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    Progress == other.Progress ||
                    Progress != null &&
                    Progress.Equals(other.Progress)
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
                    if (Timestamps != null)
                    hashCode = hashCode * 59 + Timestamps.GetHashCode();
                    if (Properties != null)
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                    if (Progress != null)
                    hashCode = hashCode * 59 + Progress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(QueryResultPage left, QueryResultPage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(QueryResultPage left, QueryResultPage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
