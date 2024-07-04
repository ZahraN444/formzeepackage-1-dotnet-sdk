// <copyright file="DirectDebitRecallSubmissionStatusEnum.cs" company="APIMatic">
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
    /// DirectDebitRecallSubmissionStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitRecallSubmissionStatusEnum
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// ReleasedToGateway.
        /// </summary>
        [EnumMember(Value = "released_to_gateway")]
        ReleasedToGateway,

        /// <summary>
        /// DeliveryConfirmed.
        /// </summary>
        [EnumMember(Value = "delivery_confirmed")]
        DeliveryConfirmed,

        /// <summary>
        /// DeliveryFailed.
        /// </summary>
        [EnumMember(Value = "delivery_failed")]
        DeliveryFailed,

        /// <summary>
        /// Submitted.
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted,

        /// <summary>
        /// ValidationPending.
        /// </summary>
        [EnumMember(Value = "validation_pending")]
        ValidationPending,

        /// <summary>
        /// ValidationPassed.
        /// </summary>
        [EnumMember(Value = "validation_passed")]
        ValidationPassed,

        /// <summary>
        /// QueuedForDelivery.
        /// </summary>
        [EnumMember(Value = "queued_for_delivery")]
        QueuedForDelivery,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending
    }
}