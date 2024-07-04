// <copyright file="ResourceTypeEnum.cs" company="APIMatic">
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
    /// ResourceTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceTypeEnum
    {
        /// <summary>
        /// AccountIndirects.
        /// </summary>
        [EnumMember(Value = "account_indirects")]
        AccountIndirects,

        /// <summary>
        /// Accounts.
        /// </summary>
        [EnumMember(Value = "accounts")]
        Accounts,

        /// <summary>
        /// Payments.
        /// </summary>
        [EnumMember(Value = "payments")]
        Payments,

        /// <summary>
        /// Reversals.
        /// </summary>
        [EnumMember(Value = "reversals")]
        Reversals,

        /// <summary>
        /// RecallDecisionSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "recall_decision_submission_validations")]
        RecallDecisionSubmissionValidations,

        /// <summary>
        /// RecallDecisionAdmissions.
        /// </summary>
        [EnumMember(Value = "recall_decision_admissions")]
        RecallDecisionAdmissions,

        /// <summary>
        /// NameVerificationSubmissions.
        /// </summary>
        [EnumMember(Value = "name_verification_submissions")]
        NameVerificationSubmissions,

        /// <summary>
        /// PaymentBatches.
        /// </summary>
        [EnumMember(Value = "payment_batches")]
        PaymentBatches,

        /// <summary>
        /// ReturnReversalAdmissions.
        /// </summary>
        [EnumMember(Value = "return_reversal_admissions")]
        ReturnReversalAdmissions,

        /// <summary>
        /// Branches.
        /// </summary>
        [EnumMember(Value = "branches")]
        Branches,

        /// <summary>
        /// PaymentAdvices.
        /// </summary>
        [EnumMember(Value = "payment_advices")]
        PaymentAdvices,

        /// <summary>
        /// RecallAdmissions.
        /// </summary>
        [EnumMember(Value = "recall_admissions")]
        RecallAdmissions,

        /// <summary>
        /// BranchIdentifications.
        /// </summary>
        [EnumMember(Value = "branch_identifications")]
        BranchIdentifications,

        /// <summary>
        /// PaymentAdviceSubmissions.
        /// </summary>
        [EnumMember(Value = "payment_advice_submissions")]
        PaymentAdviceSubmissions,

        /// <summary>
        /// SchemeMessages.
        /// </summary>
        [EnumMember(Value = "scheme_messages")]
        SchemeMessages,

        /// <summary>
        /// PaymentAdmissionTasks.
        /// </summary>
        [EnumMember(Value = "payment_admission_tasks")]
        PaymentAdmissionTasks,

        /// <summary>
        /// PaymentAdviceSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "payment_advice_submission_validations")]
        PaymentAdviceSubmissionValidations,

        /// <summary>
        /// FxDeals.
        /// </summary>
        [EnumMember(Value = "fx_deals")]
        FxDeals,

        /// <summary>
        /// Contacts.
        /// </summary>
        [EnumMember(Value = "contacts")]
        Contacts,

        /// <summary>
        /// NameVerifications.
        /// </summary>
        [EnumMember(Value = "name_verifications")]
        NameVerifications,

        /// <summary>
        /// RecallReversals.
        /// </summary>
        [EnumMember(Value = "recall_reversals")]
        RecallReversals,

        /// <summary>
        /// BankIds.
        /// </summary>
        [EnumMember(Value = "bank_ids")]
        BankIds,

        /// <summary>
        /// PaymentAutomaticReturns.
        /// </summary>
        [EnumMember(Value = "payment_automatic_returns")]
        PaymentAutomaticReturns,

        /// <summary>
        /// AccountIdentifications.
        /// </summary>
        [EnumMember(Value = "account_identifications")]
        AccountIdentifications,

        /// <summary>
        /// Limits.
        /// </summary>
        [EnumMember(Value = "limits")]
        Limits,

        /// <summary>
        /// ReturnSubmissionTasks.
        /// </summary>
        [EnumMember(Value = "return_submission_tasks")]
        ReturnSubmissionTasks,

        /// <summary>
        /// PaymentSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "payment_submission_validations")]
        PaymentSubmissionValidations,

        /// <summary>
        /// NameVerificationAdmissions.
        /// </summary>
        [EnumMember(Value = "name_verification_admissions")]
        NameVerificationAdmissions,

        /// <summary>
        /// PaymentSubmissionTasks.
        /// </summary>
        [EnumMember(Value = "payment_submission_tasks")]
        PaymentSubmissionTasks,

        /// <summary>
        /// ReturnReversals.
        /// </summary>
        [EnumMember(Value = "return_reversals")]
        ReturnReversals,

        /// <summary>
        /// Bics.
        /// </summary>
        [EnumMember(Value = "bics")]
        Bics,

        /// <summary>
        /// RecallSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "recall_submission_validations")]
        RecallSubmissionValidations,

        /// <summary>
        /// RecallReversalAdmissions.
        /// </summary>
        [EnumMember(Value = "recall_reversal_admissions")]
        RecallReversalAdmissions,

        /// <summary>
        /// ReversalAdmissionTasks.
        /// </summary>
        [EnumMember(Value = "reversal_admission_tasks")]
        ReversalAdmissionTasks,

        /// <summary>
        /// PaymentAdmissions.
        /// </summary>
        [EnumMember(Value = "payment_admissions")]
        PaymentAdmissions,

        /// <summary>
        /// ReversalSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "reversal_submission_validations")]
        ReversalSubmissionValidations,

        /// <summary>
        /// PaymentDefaults.
        /// </summary>
        [EnumMember(Value = "payment_defaults")]
        PaymentDefaults,

        /// <summary>
        /// ReturnAdmissions.
        /// </summary>
        [EnumMember(Value = "return_admissions")]
        ReturnAdmissions,

        /// <summary>
        /// PartyAccounts.
        /// </summary>
        [EnumMember(Value = "party_accounts")]
        PartyAccounts,

        /// <summary>
        /// AccountEvents.
        /// </summary>
        [EnumMember(Value = "account_events")]
        AccountEvents,

        /// <summary>
        /// Positions.
        /// </summary>
        [EnumMember(Value = "positions")]
        Positions,

        /// <summary>
        /// ReversalSubmissions.
        /// </summary>
        [EnumMember(Value = "reversal_submissions")]
        ReversalSubmissions,

        /// <summary>
        /// RecallDecisions.
        /// </summary>
        [EnumMember(Value = "recall_decisions")]
        RecallDecisions,

        /// <summary>
        /// ReturnSubmissions.
        /// </summary>
        [EnumMember(Value = "return_submissions")]
        ReturnSubmissions,

        /// <summary>
        /// ContactAccounts.
        /// </summary>
        [EnumMember(Value = "contact_accounts")]
        ContactAccounts,

        /// <summary>
        /// DirectAccount.
        /// </summary>
        [EnumMember(Value = "direct_account")]
        DirectAccount,

        /// <summary>
        /// RecallDecisionSubmissions.
        /// </summary>
        [EnumMember(Value = "recall_decision_submissions")]
        RecallDecisionSubmissions,

        /// <summary>
        /// RecallSubmissions.
        /// </summary>
        [EnumMember(Value = "recall_submissions")]
        RecallSubmissions,

        /// <summary>
        /// SchemeMessageAdmissions.
        /// </summary>
        [EnumMember(Value = "scheme_message_admissions")]
        SchemeMessageAdmissions,

        /// <summary>
        /// AccountRoutings.
        /// </summary>
        [EnumMember(Value = "account_routings")]
        AccountRoutings,

        /// <summary>
        /// Parties.
        /// </summary>
        [EnumMember(Value = "parties")]
        Parties,

        /// <summary>
        /// ReversalAdmissions.
        /// </summary>
        [EnumMember(Value = "reversal_admissions")]
        ReversalAdmissions,

        /// <summary>
        /// AccountConfigurations.
        /// </summary>
        [EnumMember(Value = "account_configurations")]
        AccountConfigurations,

        /// <summary>
        /// Returns.
        /// </summary>
        [EnumMember(Value = "returns")]
        Returns,

        /// <summary>
        /// ReturnSubmissionValidations.
        /// </summary>
        [EnumMember(Value = "return_submission_validations")]
        ReturnSubmissionValidations,

        /// <summary>
        /// Recalls.
        /// </summary>
        [EnumMember(Value = "recalls")]
        Recalls,

        /// <summary>
        /// PaymentSubmissions.
        /// </summary>
        [EnumMember(Value = "payment_submissions")]
        PaymentSubmissions
    }
}