// <copyright file="PaymentScheme2Enum.cs" company="APIMatic">
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
    /// PaymentScheme2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentScheme2Enum
    {
        /// <summary>
        /// CASS.
        /// </summary>
        [EnumMember(Value = "CASS")]
        CASS,

        /// <summary>
        /// CISA.
        /// </summary>
        [EnumMember(Value = "CISA")]
        CISA
    }
}