// <copyright file="ClaimResourceTypeEnum.cs" company="APIMatic">
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
    /// ClaimResourceTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClaimResourceTypeEnum
    {
        /// <summary>
        /// Claims.
        /// </summary>
        [EnumMember(Value = "claims")]
        Claims,

        /// <summary>
        /// ClaimSubmissions.
        /// </summary>
        [EnumMember(Value = "claim_submissions")]
        ClaimSubmissions,

        /// <summary>
        /// ClaimSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "claim_submission_validations")]
        ClaimSubmissionValidations,

        /// <summary>
        /// ClaimReversals.
        /// </summary>
        [EnumMember(Value = "claim_reversals")]
        ClaimReversals,

        /// <summary>
        /// ClaimReversalSubmissions.
        /// </summary>
        [EnumMember(Value = "claim_reversal_submissions")]
        ClaimReversalSubmissions,

        /// <summary>
        /// ClaimReversalSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "claim_reversal_submission_validations")]
        ClaimReversalSubmissionValidations
    }
}