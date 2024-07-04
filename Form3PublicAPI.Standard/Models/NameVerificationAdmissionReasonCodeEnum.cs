// <copyright file="NameVerificationAdmissionReasonCodeEnum.cs" company="APIMatic">
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
    /// NameVerificationAdmissionReasonCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameVerificationAdmissionReasonCodeEnum
    {
        /// <summary>
        /// ANNM.
        /// </summary>
        [EnumMember(Value = "ANNM")]
        ANNM,

        /// <summary>
        /// MBAM.
        /// </summary>
        [EnumMember(Value = "MBAM")]
        MBAM,

        /// <summary>
        /// BANM.
        /// </summary>
        [EnumMember(Value = "BANM")]
        BANM,

        /// <summary>
        /// PANM.
        /// </summary>
        [EnumMember(Value = "PANM")]
        PANM,

        /// <summary>
        /// BAMM.
        /// </summary>
        [EnumMember(Value = "BAMM")]
        BAMM,

        /// <summary>
        /// PAMM.
        /// </summary>
        [EnumMember(Value = "PAMM")]
        PAMM,

        /// <summary>
        /// AC01.
        /// </summary>
        [EnumMember(Value = "AC01")]
        AC01,

        /// <summary>
        /// IVCR.
        /// </summary>
        [EnumMember(Value = "IVCR")]
        IVCR,

        /// <summary>
        /// CASS.
        /// </summary>
        [EnumMember(Value = "CASS")]
        CASS,

        /// <summary>
        /// SCNS.
        /// </summary>
        [EnumMember(Value = "SCNS")]
        SCNS,

        /// <summary>
        /// ACNS.
        /// </summary>
        [EnumMember(Value = "ACNS")]
        ACNS,

        /// <summary>
        /// OPTO.
        /// </summary>
        [EnumMember(Value = "OPTO")]
        OPTO
    }
}