// <copyright file="TransactionGroupCodeEnum.cs" company="APIMatic">
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
    /// TransactionGroupCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionGroupCodeEnum
    {
        /// <summary>
        /// DR.
        /// </summary>
        [EnumMember(Value = "DR")]
        DR,

        /// <summary>
        /// CR.
        /// </summary>
        [EnumMember(Value = "CR")]
        CR,

        /// <summary>
        /// CU.
        /// </summary>
        [EnumMember(Value = "CU")]
        CU,

        /// <summary>
        /// BS.
        /// </summary>
        [EnumMember(Value = "BS")]
        BS,

        /// <summary>
        /// DV.
        /// </summary>
        [EnumMember(Value = "DV")]
        DV,

        /// <summary>
        /// AU.
        /// </summary>
        [EnumMember(Value = "AU")]
        AU
    }
}