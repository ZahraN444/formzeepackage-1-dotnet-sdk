// <copyright file="RouteEnum.cs" company="APIMatic">
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
    /// RouteEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RouteEnum
    {
        /// <summary>
        /// OnUs.
        /// </summary>
        [EnumMember(Value = "on_us")]
        OnUs
    }
}