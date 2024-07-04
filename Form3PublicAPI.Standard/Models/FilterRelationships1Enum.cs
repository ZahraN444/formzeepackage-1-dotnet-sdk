// <copyright file="FilterRelationships1Enum.cs" company="APIMatic">
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
    /// FilterRelationships1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterRelationships1Enum
    {
        /// <summary>
        /// PaymentSubmissions.
        /// </summary>
        [EnumMember(Value = "payment_submissions")]
        PaymentSubmissions,

        /// <summary>
        /// PaymentAdmissions.
        /// </summary>
        [EnumMember(Value = "payment_admissions")]
        PaymentAdmissions,

        /// <summary>
        /// Reversals.
        /// </summary>
        [EnumMember(Value = "reversals")]
        Reversals,

        /// <summary>
        /// Recalls.
        /// </summary>
        [EnumMember(Value = "recalls")]
        Recalls,

        /// <summary>
        /// Returns.
        /// </summary>
        [EnumMember(Value = "returns")]
        Returns,

        /// <summary>
        /// PaymentAdvices.
        /// </summary>
        [EnumMember(Value = "payment_advices")]
        PaymentAdvices
    }
}