// <copyright file="SchemeMessageAdmissionStatusEnum.cs" company="APIMatic">
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
    /// SchemeMessageAdmissionStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SchemeMessageAdmissionStatusEnum
    {
        /// <summary>
        /// DeliveryConfirmed.
        /// </summary>
        [EnumMember(Value = "delivery_confirmed")]
        DeliveryConfirmed,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }
}