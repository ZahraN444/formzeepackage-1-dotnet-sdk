// <copyright file="MandateSubmissionStatusEnum.cs" company="APIMatic">
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
    /// MandateSubmissionStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MandateSubmissionStatusEnum
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

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
        /// ReleasedToGateway.
        /// </summary>
        [EnumMember(Value = "released_to_gateway")]
        ReleasedToGateway,

        /// <summary>
        /// QueuedForDelivery.
        /// </summary>
        [EnumMember(Value = "queued_for_delivery")]
        QueuedForDelivery,

        /// <summary>
        /// Submitted.
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted,

        /// <summary>
        /// DeliveryConfirmed.
        /// </summary>
        [EnumMember(Value = "delivery_confirmed")]
        DeliveryConfirmed,

        /// <summary>
        /// DeliveryFailed.
        /// </summary>
        [EnumMember(Value = "delivery_failed")]
        DeliveryFailed
    }
}