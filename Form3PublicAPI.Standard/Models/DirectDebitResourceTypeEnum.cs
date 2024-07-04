// <copyright file="DirectDebitResourceTypeEnum.cs" company="APIMatic">
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
    /// DirectDebitResourceTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitResourceTypeEnum
    {
        /// <summary>
        /// DirectDebits.
        /// </summary>
        [EnumMember(Value = "direct_debits")]
        DirectDebits,

        /// <summary>
        /// DirectDebitStatus.
        /// </summary>
        [EnumMember(Value = "direct_debit_status")]
        DirectDebitStatus,

        /// <summary>
        /// DirectDebitAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_admissions")]
        DirectDebitAdmissions,

        /// <summary>
        /// DirectDebitSubmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_submissions")]
        DirectDebitSubmissions,

        /// <summary>
        /// DirectDebitSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "direct_debit_submission_validations")]
        DirectDebitSubmissionValidations,

        /// <summary>
        /// DirectDebitReversals.
        /// </summary>
        [EnumMember(Value = "direct_debit_reversals")]
        DirectDebitReversals,

        /// <summary>
        /// DirectDebitReversalAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_reversal_admissions")]
        DirectDebitReversalAdmissions,

        /// <summary>
        /// DirectDebitReversalSubmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_reversal_submissions")]
        DirectDebitReversalSubmissions,

        /// <summary>
        /// DirectDebitReversalSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "direct_debit_reversal_submission_validations")]
        DirectDebitReversalSubmissionValidations,

        /// <summary>
        /// DirectDebitReturns.
        /// </summary>
        [EnumMember(Value = "direct_debit_returns")]
        DirectDebitReturns,

        /// <summary>
        /// DirectDebitReturnAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_return_admissions")]
        DirectDebitReturnAdmissions,

        /// <summary>
        /// DirectDebitReturnSubmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_return_submissions")]
        DirectDebitReturnSubmissions,

        /// <summary>
        /// DirectDebitReturnSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "direct_debit_return_submission_validations")]
        DirectDebitReturnSubmissionValidations,

        /// <summary>
        /// DirectDebitReturnReversals.
        /// </summary>
        [EnumMember(Value = "direct_debit_return_reversals")]
        DirectDebitReturnReversals,

        /// <summary>
        /// DirectDebitReturnReversalAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_return_reversal_admissions")]
        DirectDebitReturnReversalAdmissions,

        /// <summary>
        /// DirectDebitAutomaticReturns.
        /// </summary>
        [EnumMember(Value = "direct_debit_automatic_returns")]
        DirectDebitAutomaticReturns,

        /// <summary>
        /// DirectDebitRecalls.
        /// </summary>
        [EnumMember(Value = "direct_debit_recalls")]
        DirectDebitRecalls,

        /// <summary>
        /// DirectDebitRecallAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_recall_admissions")]
        DirectDebitRecallAdmissions,

        /// <summary>
        /// DirectDebitRecallSubmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_recall_submissions")]
        DirectDebitRecallSubmissions,

        /// <summary>
        /// DirectDebitRecallSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "direct_debit_recall_submission_validations")]
        DirectDebitRecallSubmissionValidations,

        /// <summary>
        /// DirectDebitDecisions.
        /// </summary>
        [EnumMember(Value = "direct_debit_decisions")]
        DirectDebitDecisions,

        /// <summary>
        /// DirectDebitDecisionAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_decision_admissions")]
        DirectDebitDecisionAdmissions,

        /// <summary>
        /// DirectDebitDecisionSubmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_decision_submissions")]
        DirectDebitDecisionSubmissions,

        /// <summary>
        /// DirectDebitDecisionSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "direct_debit_decision_submission_validations")]
        DirectDebitDecisionSubmissionValidations,

        /// <summary>
        /// DirectDebitSubmissionsWithFinalState.
        /// </summary>
        [EnumMember(Value = "direct_debit_submissions_with_final_state")]
        DirectDebitSubmissionsWithFinalState,

        /// <summary>
        /// DirectDebitReturnSubmissionsWithFinalState.
        /// </summary>
        [EnumMember(Value = "direct_debit_return_submissions_with_final_state")]
        DirectDebitReturnSubmissionsWithFinalState
    }
}