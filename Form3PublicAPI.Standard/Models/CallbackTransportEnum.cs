// <copyright file="CallbackTransportEnum.cs" company="APIMatic">
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
    /// CallbackTransportEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallbackTransportEnum
    {
        /// <summary>
        /// Queue.
        /// </summary>
        [EnumMember(Value = "queue")]
        Queue,

        /// <summary>
        /// Http.
        /// </summary>
        [EnumMember(Value = "http")]
        Http,

        /// <summary>
        /// HttpAwsPrivate.
        /// </summary>
        [EnumMember(Value = "http_aws_private")]
        HttpAwsPrivate,

        /// <summary>
        /// HttpGcpPrivate.
        /// </summary>
        [EnumMember(Value = "http_gcp_private")]
        HttpGcpPrivate
    }
}