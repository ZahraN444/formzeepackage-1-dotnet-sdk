// <copyright file="RoutingStatusEnum.cs" company="APIMatic">
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
    /// RoutingStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoutingStatusEnum
    {
        /// <summary>
        /// Unroutable.
        /// </summary>
        [EnumMember(Value = "unroutable")]
        Unroutable,

        /// <summary>
        /// Routable.
        /// </summary>
        [EnumMember(Value = "routable")]
        Routable,

        /// <summary>
        /// Deleted.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
}