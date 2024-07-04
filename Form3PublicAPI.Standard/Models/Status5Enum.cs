// <copyright file="Status5Enum.cs" company="APIMatic">
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
    /// Status5Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status5Enum
    {
        /// <summary>
        /// PendingActivation.
        /// </summary>
        [EnumMember(Value = "pending_activation")]
        PendingActivation,

        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// Revoked.
        /// </summary>
        [EnumMember(Value = "revoked")]
        Revoked
    }
}