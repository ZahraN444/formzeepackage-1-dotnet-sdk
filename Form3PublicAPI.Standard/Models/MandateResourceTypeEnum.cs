// <copyright file="MandateResourceTypeEnum.cs" company="APIMatic">
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
    /// MandateResourceTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MandateResourceTypeEnum
    {
        /// <summary>
        /// Mandates.
        /// </summary>
        [EnumMember(Value = "mandates")]
        Mandates,

        /// <summary>
        /// MandateAdmissions.
        /// </summary>
        [EnumMember(Value = "mandate_admissions")]
        MandateAdmissions,

        /// <summary>
        /// MandateReturns.
        /// </summary>
        [EnumMember(Value = "mandate_returns")]
        MandateReturns,

        /// <summary>
        /// MandateReturnSubmissions.
        /// </summary>
        [EnumMember(Value = "mandate_return_submissions")]
        MandateReturnSubmissions,

        /// <summary>
        /// MandateReturnSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "mandate_return_submission_validations")]
        MandateReturnSubmissionValidations,

        /// <summary>
        /// MandateSubmissions.
        /// </summary>
        [EnumMember(Value = "mandate_submissions")]
        MandateSubmissions,

        /// <summary>
        /// MandateSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "mandate_submission_validations")]
        MandateSubmissionValidations,

        /// <summary>
        /// MandateAutomaticReturns.
        /// </summary>
        [EnumMember(Value = "mandate_automatic_returns")]
        MandateAutomaticReturns,

        /// <summary>
        /// MandateManagements.
        /// </summary>
        [EnumMember(Value = "mandate_managements")]
        MandateManagements,

        /// <summary>
        /// MandateSubmissionsWithFinalState.
        /// </summary>
        [EnumMember(Value = "mandate_submissions_with_final_state")]
        MandateSubmissionsWithFinalState
    }
}