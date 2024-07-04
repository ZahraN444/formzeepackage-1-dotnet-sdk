// <copyright file="DirectDebitAdmissionStatusReasonEnum.cs" company="APIMatic">
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
    /// DirectDebitAdmissionStatusReasonEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitAdmissionStatusReasonEnum
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
        /// InvalidTransaction.
        /// </summary>
        [EnumMember(Value = "invalid_transaction")]
        InvalidTransaction,

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
        /// PendingSettlement.
        /// </summary>
        [EnumMember(Value = "pending_settlement")]
        PendingSettlement,

        /// <summary>
        /// SettlementFailed.
        /// </summary>
        [EnumMember(Value = "settlement_failed")]
        SettlementFailed,

        /// <summary>
        /// Duplication.
        /// </summary>
        [EnumMember(Value = "duplication")]
        Duplication,

        /// <summary>
        /// NotAllowedAmount.
        /// </summary>
        [EnumMember(Value = "not_allowed_amount")]
        NotAllowedAmount,

        /// <summary>
        /// MandateCancelled.
        /// </summary>
        [EnumMember(Value = "mandate_cancelled")]
        MandateCancelled,

        /// <summary>
        /// NoInstruction.
        /// </summary>
        [EnumMember(Value = "no_instruction")]
        NoInstruction,

        /// <summary>
        /// AccountTransferredToNewPsp.
        /// </summary>
        [EnumMember(Value = "account_transferred_to_new_psp")]
        AccountTransferredToNewPsp,

        /// <summary>
        /// PayingBankCancellation.
        /// </summary>
        [EnumMember(Value = "paying_bank_cancellation")]
        PayingBankCancellation,

        /// <summary>
        /// CancelledByPayer.
        /// </summary>
        [EnumMember(Value = "cancelled_by_payer")]
        CancelledByPayer,

        /// <summary>
        /// PayerDeceased.
        /// </summary>
        [EnumMember(Value = "payer_deceased")]
        PayerDeceased,

        /// <summary>
        /// AccountClosed.
        /// </summary>
        [EnumMember(Value = "account_closed")]
        AccountClosed,

        /// <summary>
        /// SchemeStatusInvalid.
        /// </summary>
        [EnumMember(Value = "scheme_status_invalid")]
        SchemeStatusInvalid,

        /// <summary>
        /// PendingAuthorisationBySponsor.
        /// </summary>
        [EnumMember(Value = "pending_authorisation_by_sponsor")]
        PendingAuthorisationBySponsor,

        /// <summary>
        /// AuthorisedBySponsor.
        /// </summary>
        [EnumMember(Value = "authorised_by_sponsor")]
        AuthorisedBySponsor,

        /// <summary>
        /// AuthorisationFailedBySponsor.
        /// </summary>
        [EnumMember(Value = "authorisation_failed_by_sponsor")]
        AuthorisationFailedBySponsor,

        /// <summary>
        /// ClosedAccount.
        /// </summary>
        [EnumMember(Value = "closed_account")]
        ClosedAccount,

        /// <summary>
        /// BlockedAccount.
        /// </summary>
        [EnumMember(Value = "blocked_account")]
        BlockedAccount,

        /// <summary>
        /// InvalidDebtorAccountType.
        /// </summary>
        [EnumMember(Value = "invalid_debtor_account_type")]
        InvalidDebtorAccountType,

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
        /// InsufficientFunds.
        /// </summary>
        [EnumMember(Value = "insufficient_funds")]
        InsufficientFunds,

        /// <summary>
        /// UnrecognisedInitiatingParty.
        /// </summary>
        [EnumMember(Value = "unrecognised_initiating_party")]
        UnrecognisedInitiatingParty,

        /// <summary>
        /// CreditorBankNotRegisteredUnderBic.
        /// </summary>
        [EnumMember(Value = "creditor_bank_not_registered_under_bic")]
        CreditorBankNotRegisteredUnderBic,

        /// <summary>
        /// EnumDebtorBankNotRegisteredUnderBic.
        /// </summary>
        [EnumMember(Value = "debtor_bank_not registered_under_bic")]
        EnumDebtorBankNotRegisteredUnderBic,

        /// <summary>
        /// OperationCodeIncorrect.
        /// </summary>
        [EnumMember(Value = "operation_code_incorrect")]
        OperationCodeIncorrect,

        /// <summary>
        /// UnauthorisedTransaction.
        /// </summary>
        [EnumMember(Value = "unauthorised_transaction")]
        UnauthorisedTransaction,

        /// <summary>
        /// MissingMandatoryMandateInformation.
        /// </summary>
        [EnumMember(Value = "missing_mandatory_mandate_information")]
        MissingMandatoryMandateInformation,

        /// <summary>
        /// EndCustomerDeceased.
        /// </summary>
        [EnumMember(Value = "end_customer_deceased")]
        EndCustomerDeceased,

        /// <summary>
        /// NotSpecifiedReasonCustomer.
        /// </summary>
        [EnumMember(Value = "not_specified_reason_customer")]
        NotSpecifiedReasonCustomer,

        /// <summary>
        /// NotSpecifiedReasonAgent.
        /// </summary>
        [EnumMember(Value = "not_specified_reason_agent")]
        NotSpecifiedReasonAgent,

        /// <summary>
        /// BankIdentifierIncorrect.
        /// </summary>
        [EnumMember(Value = "bank_identifier_incorrect")]
        BankIdentifierIncorrect,

        /// <summary>
        /// MissingDebtorAccount.
        /// </summary>
        [EnumMember(Value = "missing_debtor_account")]
        MissingDebtorAccount,

        /// <summary>
        /// MissingDebtorNameOrAddress.
        /// </summary>
        [EnumMember(Value = "missing_debtor_name_or_address")]
        MissingDebtorNameOrAddress,

        /// <summary>
        /// MissingCreditorNameOrAddress.
        /// </summary>
        [EnumMember(Value = "missing_creditor_name_or_address")]
        MissingCreditorNameOrAddress,

        /// <summary>
        /// RegulatoryReason.
        /// </summary>
        [EnumMember(Value = "regulatory_reason")]
        RegulatoryReason,

        /// <summary>
        /// SpecificServiceOfferedByDebtorBank.
        /// </summary>
        [EnumMember(Value = "specific_service_offered_by_debtor_bank")]
        SpecificServiceOfferedByDebtorBank,

        /// <summary>
        /// RecalledByOriginator.
        /// </summary>
        [EnumMember(Value = "recalled_by_originator")]
        RecalledByOriginator,

        /// <summary>
        /// UnknownStatusReason.
        /// </summary>
        [EnumMember(Value = "unknown_status_reason")]
        UnknownStatusReason
    }
}