// <copyright file="NameVerificationAdmissionAnswerEnum.cs" company="APIMatic">
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
    /// NameVerificationAdmissionAnswerEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameVerificationAdmissionAnswerEnum
    {
        /// <summary>
        /// Confirmed.
        /// </summary>
        [EnumMember(Value = "confirmed")]
        Confirmed,

        /// <summary>
        /// Rejected.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected
    }
}