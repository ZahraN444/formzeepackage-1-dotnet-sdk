// <copyright file="QueryResponseAnswerEnum.cs" company="APIMatic">
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
    /// QueryResponseAnswerEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryResponseAnswerEnum
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// Rejected.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// AlreadyApplied.
        /// </summary>
        [EnumMember(Value = "already_applied")]
        AlreadyApplied,

        /// <summary>
        /// ModifiedAsRequested.
        /// </summary>
        [EnumMember(Value = "modified_as_requested")]
        ModifiedAsRequested,

        /// <summary>
        /// TransactionNotReceived.
        /// </summary>
        [EnumMember(Value = "transaction_not_received")]
        TransactionNotReceived,

        /// <summary>
        /// TransactionRejected.
        /// </summary>
        [EnumMember(Value = "transaction_rejected")]
        TransactionRejected,

        /// <summary>
        /// TransactionReturned.
        /// </summary>
        [EnumMember(Value = "transaction_returned")]
        TransactionReturned,

        /// <summary>
        /// TransactionNotProcessed.
        /// </summary>
        [EnumMember(Value = "transaction_not_processed")]
        TransactionNotProcessed,

        /// <summary>
        /// RejectedRegulatoryReason.
        /// </summary>
        [EnumMember(Value = "rejected_regulatory_reason")]
        RejectedRegulatoryReason
    }
}