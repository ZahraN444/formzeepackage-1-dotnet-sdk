// <copyright file="ReportRequestUserIdCodeEnum.cs" company="APIMatic">
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
    /// ReportRequestUserIdCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportRequestUserIdCodeEnum
    {
        /// <summary>
        /// SWBIC.
        /// </summary>
        [EnumMember(Value = "SWBIC")]
        SWBIC,

        /// <summary>
        /// RTN.
        /// </summary>
        [EnumMember(Value = "RTN")]
        RTN,

        /// <summary>
        /// Participant.
        /// </summary>
        [EnumMember(Value = "Participant")]
        Participant,

        /// <summary>
        /// SUN.
        /// </summary>
        [EnumMember(Value = "SUN")]
        SUN
    }
}