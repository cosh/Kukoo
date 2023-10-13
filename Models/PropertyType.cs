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
        /// The type of the property that is either stored in events or computed by a calculation.
        /// </summary>
        /// <value>The type of the property that is either stored in events or computed by a calculation.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PropertyType
        {
            
            /// <summary>
            /// Enum BoolEnum for Bool
            /// </summary>
            [EnumMember(Value = "Bool")]
            BoolEnum = 1,
            
            /// <summary>
            /// Enum DateTimeEnum for DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTimeEnum = 2,
            
            /// <summary>
            /// Enum DoubleEnum for Double
            /// </summary>
            [EnumMember(Value = "Double")]
            DoubleEnum = 3,
            
            /// <summary>
            /// Enum StringEnum for String
            /// </summary>
            [EnumMember(Value = "String")]
            StringEnum = 4,
            
            /// <summary>
            /// Enum TimeSpanEnum for TimeSpan
            /// </summary>
            [EnumMember(Value = "TimeSpan")]
            TimeSpanEnum = 5,
            
            /// <summary>
            /// Enum LongEnum for Long
            /// </summary>
            [EnumMember(Value = "Long")]
            LongEnum = 6
        }
}
