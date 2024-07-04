// <copyright file="FilterRelationshipsEnum.cs" company="APIMatic">
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
    /// FilterRelationshipsEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FilterRelationshipsEnum
    {
        /// <summary>
        /// DirectDebitSubmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_submissions")]
        DirectDebitSubmissions,

        /// <summary>
        /// DirectDebitAdmissions.
        /// </summary>
        [EnumMember(Value = "direct_debit_admissions")]
        DirectDebitAdmissions,

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
        /// Decisions.
        /// </summary>
        [EnumMember(Value = "decisions")]
        Decisions
    }
}