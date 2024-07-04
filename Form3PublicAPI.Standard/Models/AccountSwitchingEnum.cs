// <copyright file="AccountSwitchingEnum.cs" company="APIMatic">
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
    /// AccountSwitchingEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountSwitchingEnum
    {
        /// <summary>
        /// Full.
        /// </summary>
        [EnumMember(Value = "full")]
        Full,

        /// <summary>
        /// Partial.
        /// </summary>
        [EnumMember(Value = "partial")]
        Partial,

        /// <summary>
        /// Ineligible.
        /// </summary>
        [EnumMember(Value = "ineligible")]
        Ineligible
    }
}