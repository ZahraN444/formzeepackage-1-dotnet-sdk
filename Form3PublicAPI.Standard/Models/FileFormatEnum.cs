// <copyright file="FileFormatEnum.cs" company="APIMatic">
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
    /// FileFormatEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileFormatEnum
    {
        /// <summary>
        /// Ndjson.
        /// </summary>
        [EnumMember(Value = "ndjson")]
        Ndjson,

        /// <summary>
        /// Standard18.
        /// </summary>
        [EnumMember(Value = "standard18")]
        Standard18
    }
}