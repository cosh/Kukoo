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
    /// Get Series query. Allows to retrieve time series of calculated variable values from events for a given Time Series ID and search span.
    /// </summary>
    [DataContract]
    public partial class GetSeries : IEquatable<GetSeries>
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
        /// Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND&#39;ed with filter in each variable. Example: \&quot;$event.Status.String&#x3D;&#39;Good&#39;\&quot;. Optional.
        /// </summary>
        /// <value>Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND&#39;ed with filter in each variable. Example: \&quot;$event.Status.String&#x3D;&#39;Good&#39;\&quot;. Optional.</value>

        [DataMember(Name="filter")]
        public Tsx Filter { get; set; }

        /// <summary>
        /// Selected variables that needs to be projected in the query result. When it is null or not set, all the variables from inlineVariables and time series type in the model are returned. Can be null.
        /// </summary>
        /// <value>Selected variables that needs to be projected in the query result. When it is null or not set, all the variables from inlineVariables and time series type in the model are returned. Can be null.</value>

        [DataMember(Name="projectedVariables")]
        public List<string> ProjectedVariables { get; set; }

        /// <summary>
        /// Optional inline variables apart from the ones already defined in the time series type in the model. When the inline variable name is the same name as in the model, the inline variable definition takes precedence. Can be null.
        /// </summary>
        /// <value>Optional inline variables apart from the ones already defined in the time series type in the model. When the inline variable name is the same name as in the model, the inline variable definition takes precedence. Can be null.</value>

        [DataMember(Name="inlineVariables")]
        public Dictionary<string, Variable> InlineVariables { get; set; }

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
            sb.Append("class GetSeries {\n");
            sb.Append("  TimeSeriesId: ").Append(TimeSeriesId).Append("\n");
            sb.Append("  SearchSpan: ").Append(SearchSpan).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  ProjectedVariables: ").Append(ProjectedVariables).Append("\n");
            sb.Append("  InlineVariables: ").Append(InlineVariables).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetSeries)obj);
        }

        /// <summary>
        /// Returns true if GetSeries instances are equal
        /// </summary>
        /// <param name="other">Instance of GetSeries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSeries other)
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
                    ProjectedVariables == other.ProjectedVariables ||
                    ProjectedVariables != null &&
                    ProjectedVariables.SequenceEqual(other.ProjectedVariables)
                ) && 
                (
                    InlineVariables == other.InlineVariables ||
                    InlineVariables != null &&
                    InlineVariables.SequenceEqual(other.InlineVariables)
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
                    if (ProjectedVariables != null)
                    hashCode = hashCode * 59 + ProjectedVariables.GetHashCode();
                    if (InlineVariables != null)
                    hashCode = hashCode * 59 + InlineVariables.GetHashCode();
                    if (Take != null)
                    hashCode = hashCode * 59 + Take.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GetSeries left, GetSeries right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetSeries left, GetSeries right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
