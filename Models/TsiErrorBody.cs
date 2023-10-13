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
    /// A particular API error with an error code and a message.
    /// </summary>
    [DataContract]
    public class TsiErrorBody
    { 
        /// <summary>
        /// Language-independent, human-readable string that defines a service-specific error code. This code serves as a more specific indicator for the HTTP error code specified in the response. Can be used to programmatically handle specific error cases.
        /// </summary>
        /// <value>Language-independent, human-readable string that defines a service-specific error code. This code serves as a more specific indicator for the HTTP error code specified in the response. Can be used to programmatically handle specific error cases.</value>

        [DataMember(Name="code")]
        public string Code { get; private set; }

        /// <summary>
        /// Human-readable, language-independent representation of the error. It is intended as an aid to developers and is not suitable for exposure to end users.
        /// </summary>
        /// <value>Human-readable, language-independent representation of the error. It is intended as an aid to developers and is not suitable for exposure to end users.</value>

        [DataMember(Name="message")]
        public string Message { get; private set; }

        /// <summary>
        /// Target of the particular error (for example, the name of the property in error). May be null.
        /// </summary>
        /// <value>Target of the particular error (for example, the name of the property in error). May be null.</value>

        [DataMember(Name="target")]
        public string Target { get; private set; }

        /// <summary>
        /// Contains more specific error that narrows down the cause. May be null.
        /// </summary>
        /// <value>Contains more specific error that narrows down the cause. May be null.</value>

        [DataMember(Name="innerError")]
        public TsiErrorBody InnerError { get; private set; }

        /// <summary>
        /// Contains additional error information. May be null.
        /// </summary>
        /// <value>Contains additional error information. May be null.</value>

        [DataMember(Name="details")]
        public List<TsiErrorDetails> Details { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsiErrorBody {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  InnerError: ").Append(InnerError).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TsiErrorBody)obj);
        }

        /// <summary>
        /// Returns true if TsiErrorBody instances are equal
        /// </summary>
        /// <param name="other">Instance of TsiErrorBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsiErrorBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    Target == other.Target ||
                    Target != null &&
                    Target.Equals(other.Target)
                ) && 
                (
                    InnerError == other.InnerError ||
                    InnerError != null &&
                    InnerError.Equals(other.InnerError)
                ) && 
                (
                    Details == other.Details ||
                    Details != null &&
                    Details.SequenceEqual(other.Details)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    if (Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();
                    if (InnerError != null)
                    hashCode = hashCode * 59 + InnerError.GetHashCode();
                    if (Details != null)
                    hashCode = hashCode * 59 + Details.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TsiErrorBody left, TsiErrorBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TsiErrorBody left, TsiErrorBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
