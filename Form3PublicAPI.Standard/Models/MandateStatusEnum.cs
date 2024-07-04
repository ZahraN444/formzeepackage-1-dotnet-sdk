// <copyright file="MandateStatusEnum.cs" company="APIMatic">
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
    /// MandateStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MandateStatusEnum
    {
        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Invalid.
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled
    }
}