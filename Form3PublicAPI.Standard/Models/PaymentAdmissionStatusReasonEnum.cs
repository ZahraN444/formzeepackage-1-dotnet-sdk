// <copyright file="PaymentAdmissionStatusReasonEnum.cs" company="APIMatic">
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
    /// PaymentAdmissionStatusReasonEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentAdmissionStatusReasonEnum
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// InvalidBeneficiaryDetails.
        /// </summary>
        [EnumMember(Value = "invalid_beneficiary_details")]
        InvalidBeneficiaryDetails,

        /// <summary>
        /// BankidNotProvisioned.
        /// </summary>
        [EnumMember(Value = "bankid_not_provisioned")]
        BankidNotProvisioned,

        /// <summary>
        /// UnknownAccountnumber.
        /// </summary>
        [EnumMember(Value = "unknown_accountnumber")]
        UnknownAccountnumber,

        /// <summary>
        /// CustomerCheckFailed.
        /// </summary>
        [EnumMember(Value = "customer_check_failed")]
        CustomerCheckFailed,

        /// <summary>
        /// SchemeTimeout.
        /// </summary>
        [EnumMember(Value = "scheme_timeout")]
        SchemeTimeout,

        /// <summary>
        /// IncorrectReferenceValidationType.
        /// </summary>
        [EnumMember(Value = "incorrect_reference_validation_type")]
        IncorrectReferenceValidationType,

        /// <summary>
        /// IncorrectReferenceSecondaryIdentification.
        /// </summary>
        [EnumMember(Value = "incorrect_reference_secondary_identification")]
        IncorrectReferenceSecondaryIdentification,

        /// <summary>
        /// IncorrectReferenceReferenceMask.
        /// </summary>
        [EnumMember(Value = "incorrect_reference_reference_mask")]
        IncorrectReferenceReferenceMask,

        /// <summary>
        /// AccountClosed.
        /// </summary>
        [EnumMember(Value = "account_closed")]
        AccountClosed,

        /// <summary>
        /// AccountClosedBusinessReasons.
        /// </summary>
        [EnumMember(Value = "account_closed_business_reasons")]
        AccountClosedBusinessReasons,

        /// <summary>
        /// AccountClosedStopped.
        /// </summary>
        [EnumMember(Value = "account_closed_stopped")]
        AccountClosedStopped,

        /// <summary>
        /// AccountClosedCurrency.
        /// </summary>
        [EnumMember(Value = "account_closed_currency")]
        AccountClosedCurrency,

        /// <summary>
        /// AccountClosedTransferred.
        /// </summary>
        [EnumMember(Value = "account_closed_transferred")]
        AccountClosedTransferred,

        /// <summary>
        /// AccountClosedBeneficiaryDeceased.
        /// </summary>
        [EnumMember(Value = "account_closed_beneficiary_deceased")]
        AccountClosedBeneficiaryDeceased,

        /// <summary>
        /// AccountClosedBeneficiarySensitivities.
        /// </summary>
        [EnumMember(Value = "account_closed_beneficiary_sensitivities")]
        AccountClosedBeneficiarySensitivities,

        /// <summary>
        /// AccountClosedTermsAndConditions.
        /// </summary>
        [EnumMember(Value = "account_closed_terms_and_conditions")]
        AccountClosedTermsAndConditions,

        /// <summary>
        /// BeneficiaryAgentClearingProcessTimeout.
        /// </summary>
        [EnumMember(Value = "beneficiary_agent_clearing_process_timeout")]
        BeneficiaryAgentClearingProcessTimeout,

        /// <summary>
        /// AgentClearingProcessTimeout.
        /// </summary>
        [EnumMember(Value = "agent_clearing_process_timeout")]
        AgentClearingProcessTimeout,

        /// <summary>
        /// AgentUnavailable.
        /// </summary>
        [EnumMember(Value = "agent_unavailable")]
        AgentUnavailable,

        /// <summary>
        /// BeneficiaryAgentUnavailable.
        /// </summary>
        [EnumMember(Value = "beneficiary_agent_unavailable")]
        BeneficiaryAgentUnavailable,

        /// <summary>
        /// BeneficiaryAgentClearingProcessError.
        /// </summary>
        [EnumMember(Value = "beneficiary_agent_clearing_process_error")]
        BeneficiaryAgentClearingProcessError,

        /// <summary>
        /// AgentClearingProcessError.
        /// </summary>
        [EnumMember(Value = "agent_clearing_process_error")]
        AgentClearingProcessError,

        /// <summary>
        /// BlockedAccount.
        /// </summary>
        [EnumMember(Value = "blocked_account")]
        BlockedAccount,

        /// <summary>
        /// TransactionForbidden.
        /// </summary>
        [EnumMember(Value = "transaction_forbidden")]
        TransactionForbidden,

        /// <summary>
        /// InvalidBankOperationCode.
        /// </summary>
        [EnumMember(Value = "invalid_bank_operation_code")]
        InvalidBankOperationCode,

        /// <summary>
        /// OriginalPaymentNotReceived.
        /// </summary>
        [EnumMember(Value = "original_payment_not_received")]
        OriginalPaymentNotReceived,

        /// <summary>
        /// AgentSuspended.
        /// </summary>
        [EnumMember(Value = "agent_suspended")]
        AgentSuspended,

        /// <summary>
        /// BeneficiaryAgentSuspended.
        /// </summary>
        [EnumMember(Value = "beneficiary_agent_suspended")]
        BeneficiaryAgentSuspended,

        /// <summary>
        /// AmountNotAllowed.
        /// </summary>
        [EnumMember(Value = "amount_not_allowed")]
        AmountNotAllowed,

        /// <summary>
        /// DuplicatePayment.
        /// </summary>
        [EnumMember(Value = "duplicate_payment")]
        DuplicatePayment,

        /// <summary>
        /// AmountExceedsSettlementLimit.
        /// </summary>
        [EnumMember(Value = "amount_exceeds_settlement_limit")]
        AmountExceedsSettlementLimit,

        /// <summary>
        /// InvalidBeneficiaryAddress.
        /// </summary>
        [EnumMember(Value = "invalid_beneficiary_address")]
        InvalidBeneficiaryAddress,

        /// <summary>
        /// InvalidBeneficiaryAgentBIC.
        /// </summary>
        [EnumMember(Value = "invalid_beneficiary_agent_BIC")]
        InvalidBeneficiaryAgentBIC,

        /// <summary>
        /// InvalidDebtorAgentBIC.
        /// </summary>
        [EnumMember(Value = "invalid_debtor_agent_BIC")]
        InvalidDebtorAgentBIC,

        /// <summary>
        /// CustomerReasonUnknown.
        /// </summary>
        [EnumMember(Value = "customer_reason_unknown")]
        CustomerReasonUnknown,

        /// <summary>
        /// AgentReasonUnknown.
        /// </summary>
        [EnumMember(Value = "agent_reason_unknown")]
        AgentReasonUnknown,

        /// <summary>
        /// InvalidBankID.
        /// </summary>
        [EnumMember(Value = "invalid_bank_ID")]
        InvalidBankID,

        /// <summary>
        /// InvalidDebtorDetails.
        /// </summary>
        [EnumMember(Value = "invalid_debtor_details")]
        InvalidDebtorDetails,

        /// <summary>
        /// RegulatoryReason.
        /// </summary>
        [EnumMember(Value = "regulatory_reason")]
        RegulatoryReason,

        /// <summary>
        /// AmountInvalidOrMissing.
        /// </summary>
        [EnumMember(Value = "amount_invalid_or_missing")]
        AmountInvalidOrMissing,

        /// <summary>
        /// EndToEndIdMissingOrInvalid.
        /// </summary>
        [EnumMember(Value = "end_to_end_id_missing_or_invalid")]
        EndToEndIdMissingOrInvalid,

        /// <summary>
        /// TransactionTypeNotSupported.
        /// </summary>
        [EnumMember(Value = "transaction_type_not_supported")]
        TransactionTypeNotSupported
    }
}