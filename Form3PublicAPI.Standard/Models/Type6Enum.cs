// <copyright file="Type6Enum.cs" company="APIMatic">
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
    /// Type6Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type6Enum
    {
        /// <summary>
        /// Missing.
        /// </summary>
        [EnumMember(Value = "missing")]
        Missing,

        /// <summary>
        /// Incorrect.
        /// </summary>
        [EnumMember(Value = "incorrect")]
        Incorrect
    }
}