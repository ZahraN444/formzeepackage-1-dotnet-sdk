// <copyright file="Type11Enum.cs" company="APIMatic">
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
    /// Type11Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type11Enum
    {
        /// <summary>
        /// ReportAdmissions.
        /// </summary>
        [EnumMember(Value = "report_admissions")]
        ReportAdmissions
    }
}