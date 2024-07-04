// <copyright file="AccountNumberCodeEnum.cs" company="APIMatic">
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
    /// AccountNumberCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountNumberCodeEnum
    {
        /// <summary>
        /// IBAN.
        /// </summary>
        [EnumMember(Value = "IBAN")]
        IBAN,

        /// <summary>
        /// BBAN.
        /// </summary>
        [EnumMember(Value = "BBAN")]
        BBAN
    }
}