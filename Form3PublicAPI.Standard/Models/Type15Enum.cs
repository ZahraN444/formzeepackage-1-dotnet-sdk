// <copyright file="Type15Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// Type15Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type15Enum
    {
        /// <summary>
        /// SchemeMessageAdmissions.
        /// </summary>
        [EnumMember(Value = "scheme_message_admissions")]
        SchemeMessageAdmissions
    }
}