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
    /// Get Events query. Allows to retrieve raw events for a given Time Series ID and search span.
    /// </summary>
    [DataContract]
    public partial class GetEvents : IEquatable<GetEvents>
    { 
        /// <summary>
        /// A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null.
        /// </summary>
        /// <value>A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null.</value>
        [Required]
        
        [DataMember(Name="timeSeriesId")]
        public TimeSeriesId TimeSeriesId { get; set; }

        /// <summary>
        /// The range of time on which the query is executed. Cannot be null.
        /// </summary>
        /// <value>The range of time on which the query is executed. Cannot be null.</value>
        [Required]
        
        [DataMember(Name="searchSpan")]
        public DateTimeRange SearchSpan { get; set; }

        /// <summary>
        /// Optional top-level filter for the query which will be applied to all the variables in the query. Example: \&quot;$event.Status.String&#x3D;&#39;Good&#39;\&quot;.  Can be null.
        /// </summary>
        /// <value>Optional top-level filter for the query which will be applied to all the variables in the query. Example: \&quot;$event.Status.String&#x3D;&#39;Good&#39;\&quot;.  Can be null.</value>

        [DataMember(Name="filter")]
        public Tsx Filter { get; set; }

        /// <summary>
        /// Projected properties is an array of properties which you want to project. These properties must appear in the events; otherwise, they are not returned.
        /// </summary>
        /// <value>Projected properties is an array of properties which you want to project. These properties must appear in the events; otherwise, they are not returned.</value>

        [DataMember(Name="projectedProperties")]
        public List<EventProperty> ProjectedProperties { get; set; }

        /// <summary>
        /// Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000.
        /// </summary>
        /// <value>Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000.</value>

        [DataMember(Name="take")]
        public int? Take { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEvents {\n");
            sb.Append("  TimeSeriesId: ").Append(TimeSeriesId).Append("\n");
            sb.Append("  SearchSpan: ").Append(SearchSpan).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  ProjectedProperties: ").Append(ProjectedProperties).Append("\n");
            sb.Append("  Take: ").Append(Take).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetEvents)obj);
        }

        /// <summary>
        /// Returns true if GetEvents instances are equal
        /// </summary>
        /// <param name="other">Instance of GetEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEvents other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeSeriesId == other.TimeSeriesId ||
                    TimeSeriesId != null &&
                    TimeSeriesId.Equals(other.TimeSeriesId)
                ) && 
                (
                    SearchSpan == other.SearchSpan ||
                    SearchSpan != null &&
                    SearchSpan.Equals(other.SearchSpan)
                ) && 
                (
                    Filter == other.Filter ||
                    Filter != null &&
                    Filter.Equals(other.Filter)
                ) && 
                (
                    ProjectedProperties == other.ProjectedProperties ||
                    ProjectedProperties != null &&
                    ProjectedProperties.SequenceEqual(other.ProjectedProperties)
                ) && 
                (
                    Take == other.Take ||
                    Take != null &&
                    Take.Equals(other.Take)
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
                    if (TimeSeriesId != null)
                    hashCode = hashCode * 59 + TimeSeriesId.GetHashCode();
                    if (SearchSpan != null)
                    hashCode = hashCode * 59 + SearchSpan.GetHashCode();
                    if (Filter != null)
                    hashCode = hashCode * 59 + Filter.GetHashCode();
                    if (ProjectedProperties != null)
                    hashCode = hashCode * 59 + ProjectedProperties.GetHashCode();
                    if (Take != null)
                    hashCode = hashCode * 59 + Take.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetEvents left, GetEvents right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetEvents left, GetEvents right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
