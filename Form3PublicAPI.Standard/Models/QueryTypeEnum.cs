// <copyright file="QueryTypeEnum.cs" company="APIMatic">
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
    /// QueryTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryTypeEnum
    {
        /// <summary>
        /// ClaimNonReceipt.
        /// </summary>
        [EnumMember(Value = "claim_non_receipt")]
        ClaimNonReceipt,

        /// <summary>
        /// ModifyPayment.
        /// </summary>
        [EnumMember(Value = "modify_payment")]
        ModifyPayment,

        /// <summary>
        /// StatusRequest.
        /// </summary>
        [EnumMember(Value = "status_request")]
        StatusRequest,

        /// <summary>
        /// RequestForInformation.
        /// </summary>
        [EnumMember(Value = "request_for_information")]
        RequestForInformation
    }
}