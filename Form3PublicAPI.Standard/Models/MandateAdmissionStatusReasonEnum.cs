// <copyright file="MandateAdmissionStatusReasonEnum.cs" company="APIMatic">
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
    /// MandateAdmissionStatusReasonEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MandateAdmissionStatusReasonEnum
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
        /// MandateCancelled.
        /// </summary>
        [EnumMember(Value = "mandate_cancelled")]
        MandateCancelled,

        /// <summary>
        /// MandateExpired.
        /// </summary>
        [EnumMember(Value = "mandate_expired")]
        MandateExpired,

        /// <summary>
        /// MandateFailed.
        /// </summary>
        [EnumMember(Value = "mandate_failed")]
        MandateFailed,

        /// <summary>
        /// UnknownInstruction.
        /// </summary>
        [EnumMember(Value = "unknown_instruction")]
        UnknownInstruction,

        /// <summary>
        /// PayerReferenceNotUnique.
        /// </summary>
        [EnumMember(Value = "payer_reference_not_unique")]
        PayerReferenceNotUnique,

        /// <summary>
        /// InvalidReference.
        /// </summary>
        [EnumMember(Value = "invalid_reference")]
        InvalidReference,

        /// <summary>
        /// NotEligibleForReinstatementByOriginator.
        /// </summary>
        [EnumMember(Value = "not_eligible_for_reinstatement_by_originator")]
        NotEligibleForReinstatementByOriginator
    }
}