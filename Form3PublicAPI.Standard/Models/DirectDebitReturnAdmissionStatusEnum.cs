// <copyright file="DirectDebitReturnAdmissionStatusEnum.cs" company="APIMatic">
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
    /// DirectDebitReturnAdmissionStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitReturnAdmissionStatusEnum
    {
        /// <summary>
        /// Confirmed.
        /// </summary>
        [EnumMember(Value = "confirmed")]
        Confirmed,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// LimitCheckPending.
        /// </summary>
        [EnumMember(Value = "limit_check_pending")]
        LimitCheckPending,

        /// <summary>
        /// LimitCheckPassed.
        /// </summary>
        [EnumMember(Value = "limit_check_passed")]
        LimitCheckPassed
    }
}