// <copyright file="PaymentSchemeEnum.cs" company="APIMatic">
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
    /// PaymentSchemeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentSchemeEnum
    {
        /// <summary>
        /// FPS.
        /// </summary>
        [EnumMember(Value = "FPS")]
        FPS,

        /// <summary>
        /// SEPAINSTANT.
        /// </summary>
        [EnumMember(Value = "SEPAINSTANT")]
        SEPAINSTANT,

        /// <summary>
        /// TCH.
        /// </summary>
        [EnumMember(Value = "TCH")]
        TCH,

        /// <summary>
        /// FDN.
        /// </summary>
        [EnumMember(Value = "FDN")]
        FDN,

        /// <summary>
        /// FDW.
        /// </summary>
        [EnumMember(Value = "FDW")]
        FDW
    }
}