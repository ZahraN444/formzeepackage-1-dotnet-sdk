// <copyright file="AcceptanceQualifierEnum.cs" company="APIMatic">
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
    /// AcceptanceQualifierEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcceptanceQualifierEnum
    {
        /// <summary>
        /// SomeOtherTime.
        /// </summary>
        [EnumMember(Value = "some_other_time")]
        SomeOtherTime,

        /// <summary>
        /// SameDay.
        /// </summary>
        [EnumMember(Value = "same_day")]
        SameDay,

        /// <summary>
        /// NextCalendarDay.
        /// </summary>
        [EnumMember(Value = "next_calendar_day")]
        NextCalendarDay,

        /// <summary>
        /// NextWorkingDay.
        /// </summary>
        [EnumMember(Value = "next_working_day")]
        NextWorkingDay,

        /// <summary>
        /// AfterNextWorkingDay.
        /// </summary>
        [EnumMember(Value = "after_next_working_day")]
        AfterNextWorkingDay,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}