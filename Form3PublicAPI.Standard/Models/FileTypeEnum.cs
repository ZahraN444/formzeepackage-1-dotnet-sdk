// <copyright file="FileTypeEnum.cs" company="APIMatic">
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
    /// FileTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileTypeEnum
    {
        /// <summary>
        /// Switch.
        /// </summary>
        [EnumMember(Value = "switch")]
        Switch,

        /// <summary>
        /// ISA.
        /// </summary>
        [EnumMember(Value = "ISA")]
        ISA
    }
}