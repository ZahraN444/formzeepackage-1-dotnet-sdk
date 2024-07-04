// <copyright file="ClearingChannelEnum.cs" company="APIMatic">
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
    /// ClearingChannelEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClearingChannelEnum
    {
        /// <summary>
        /// MPNS.
        /// </summary>
        [EnumMember(Value = "MPNS")]
        MPNS,

        /// <summary>
        /// RTGS.
        /// </summary>
        [EnumMember(Value = "RTGS")]
        RTGS,

        /// <summary>
        /// RTNS.
        /// </summary>
        [EnumMember(Value = "RTNS")]
        RTNS
    }
}