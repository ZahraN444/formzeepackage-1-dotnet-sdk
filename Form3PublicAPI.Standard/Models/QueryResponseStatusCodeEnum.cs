// <copyright file="QueryResponseStatusCodeEnum.cs" company="APIMatic">
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
    /// QueryResponseStatusCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryResponseStatusCodeEnum
    {
        /// <summary>
        /// IPAY.
        /// </summary>
        [EnumMember(Value = "IPAY")]
        IPAY,

        /// <summary>
        /// INFO.
        /// </summary>
        [EnumMember(Value = "INFO")]
        INFO,

        /// <summary>
        /// NINF.
        /// </summary>
        [EnumMember(Value = "NINF")]
        NINF,

        /// <summary>
        /// PDNG.
        /// </summary>
        [EnumMember(Value = "PDNG")]
        PDNG,

        /// <summary>
        /// IDUP.
        /// </summary>
        [EnumMember(Value = "IDUP")]
        IDUP
    }
}