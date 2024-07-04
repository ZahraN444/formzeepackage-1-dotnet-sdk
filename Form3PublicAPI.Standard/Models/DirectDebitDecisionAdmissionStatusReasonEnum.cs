// <copyright file="DirectDebitDecisionAdmissionStatusReasonEnum.cs" company="APIMatic">
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
    /// DirectDebitDecisionAdmissionStatusReasonEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitDecisionAdmissionStatusReasonEnum
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
        /// PendingSettlement.
        /// </summary>
        [EnumMember(Value = "pending_settlement")]
        PendingSettlement
    }
}