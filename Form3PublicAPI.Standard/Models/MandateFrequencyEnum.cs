// <copyright file="MandateFrequencyEnum.cs" company="APIMatic">
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
    /// MandateFrequencyEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MandateFrequencyEnum
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily,

        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,

        /// <summary>
        /// Fortnightly.
        /// </summary>
        [EnumMember(Value = "fortnightly")]
        Fortnightly,

        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,

        /// <summary>
        /// Bimonthly.
        /// </summary>
        [EnumMember(Value = "bimonthly")]
        Bimonthly,

        /// <summary>
        /// Quarterly.
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,

        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly
    }
}