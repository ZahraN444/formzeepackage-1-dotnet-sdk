// <copyright file="BankIdCodeEnum.cs" company="APIMatic">
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
    /// BankIdCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankIdCodeEnum
    {
        /// <summary>
        /// SWBIC.
        /// </summary>
        [EnumMember(Value = "SWBIC")]
        SWBIC,

        /// <summary>
        /// GBDSC.
        /// </summary>
        [EnumMember(Value = "GBDSC")]
        GBDSC,

        /// <summary>
        /// BE.
        /// </summary>
        [EnumMember(Value = "BE")]
        BE,

        /// <summary>
        /// FR.
        /// </summary>
        [EnumMember(Value = "FR")]
        FR,

        /// <summary>
        /// DEBLZ.
        /// </summary>
        [EnumMember(Value = "DEBLZ")]
        DEBLZ,

        /// <summary>
        /// GRBIC.
        /// </summary>
        [EnumMember(Value = "GRBIC")]
        GRBIC,

        /// <summary>
        /// ITNCC.
        /// </summary>
        [EnumMember(Value = "ITNCC")]
        ITNCC,

        /// <summary>
        /// PLKNR.
        /// </summary>
        [EnumMember(Value = "PLKNR")]
        PLKNR,

        /// <summary>
        /// PTNCC.
        /// </summary>
        [EnumMember(Value = "PTNCC")]
        PTNCC,

        /// <summary>
        /// ESNCC.
        /// </summary>
        [EnumMember(Value = "ESNCC")]
        ESNCC,

        /// <summary>
        /// CHBCC.
        /// </summary>
        [EnumMember(Value = "CHBCC")]
        CHBCC
    }
}