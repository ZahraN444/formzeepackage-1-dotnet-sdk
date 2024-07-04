// <copyright file="MethodEnum.cs" company="APIMatic">
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
    /// MethodEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MethodEnum
    {
        /// <summary>
        /// CLRG.
        /// </summary>
        [EnumMember(Value = "CLRG")]
        CLRG,

        /// <summary>
        /// COVE.
        /// </summary>
        [EnumMember(Value = "COVE")]
        COVE,

        /// <summary>
        /// INGA.
        /// </summary>
        [EnumMember(Value = "INGA")]
        INGA,

        /// <summary>
        /// INDA.
        /// </summary>
        [EnumMember(Value = "INDA")]
        INDA
    }
}