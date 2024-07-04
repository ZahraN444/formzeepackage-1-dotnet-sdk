// <copyright file="StatusReasonEnum.cs" company="APIMatic">
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
    /// StatusReasonEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusReasonEnum
    {
        /// <summary>
        /// Closed.
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,

        /// <summary>
        /// Stopped.
        /// </summary>
        [EnumMember(Value = "stopped")]
        Stopped,

        /// <summary>
        /// Currency.
        /// </summary>
        [EnumMember(Value = "currency")]
        Currency,

        /// <summary>
        /// Transferred.
        /// </summary>
        [EnumMember(Value = "transferred")]
        Transferred,

        /// <summary>
        /// Deceased.
        /// </summary>
        [EnumMember(Value = "deceased")]
        Deceased,

        /// <summary>
        /// BusinessReasons.
        /// </summary>
        [EnumMember(Value = "business_reasons")]
        BusinessReasons,

        /// <summary>
        /// BeneficiarySensitivities.
        /// </summary>
        [EnumMember(Value = "beneficiary_sensitivities")]
        BeneficiarySensitivities,

        /// <summary>
        /// TermsAndConditions.
        /// </summary>
        [EnumMember(Value = "terms_and_conditions")]
        TermsAndConditions,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}