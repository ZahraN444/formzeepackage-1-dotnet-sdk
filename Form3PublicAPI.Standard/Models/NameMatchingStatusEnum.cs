// <copyright file="NameMatchingStatusEnum.cs" company="APIMatic">
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
    /// NameMatchingStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameMatchingStatusEnum
    {
        /// <summary>
        /// Supported.
        /// </summary>
        [EnumMember(Value = "supported")]
        Supported,

        /// <summary>
        /// Switched.
        /// </summary>
        [EnumMember(Value = "switched")]
        Switched,

        /// <summary>
        /// OptedOut.
        /// </summary>
        [EnumMember(Value = "opted_out")]
        OptedOut,

        /// <summary>
        /// NotSupported.
        /// </summary>
        [EnumMember(Value = "not_supported")]
        NotSupported
    }
}