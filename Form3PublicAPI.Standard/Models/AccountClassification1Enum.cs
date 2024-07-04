// <copyright file="AccountClassification1Enum.cs" company="APIMatic">
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
    /// AccountClassification1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountClassification1Enum
    {
        /// <summary>
        /// Personal.
        /// </summary>
        [EnumMember(Value = "Personal")]
        Personal,

        /// <summary>
        /// Business.
        /// </summary>
        [EnumMember(Value = "Business")]
        Business
    }
}