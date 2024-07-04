// <copyright file="PaymentAdmissionTaskAssigneeEnum.cs" company="APIMatic">
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
    /// PaymentAdmissionTaskAssigneeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentAdmissionTaskAssigneeEnum
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// Form3.
        /// </summary>
        [EnumMember(Value = "form3")]
        Form3
    }
}