// <copyright file="BranchValidationTypeEnum.cs" company="APIMatic">
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
    /// BranchValidationTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BranchValidationTypeEnum
    {
        /// <summary>
        /// Card.
        /// </summary>
        [EnumMember(Value = "card")]
        Card,

        /// <summary>
        /// MandatoryReference.
        /// </summary>
        [EnumMember(Value = "mandatory_reference")]
        MandatoryReference,

        /// <summary>
        /// AccountModCheck.
        /// </summary>
        [EnumMember(Value = "account_mod_check")]
        AccountModCheck,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}