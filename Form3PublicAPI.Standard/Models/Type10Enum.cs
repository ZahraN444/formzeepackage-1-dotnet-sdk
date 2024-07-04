// <copyright file="Type10Enum.cs" company="APIMatic">
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
    /// Type10Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type10Enum
    {
        /// <summary>
        /// PaymentSubmissionTasks.
        /// </summary>
        [EnumMember(Value = "payment_submission_tasks")]
        PaymentSubmissionTasks
    }
}