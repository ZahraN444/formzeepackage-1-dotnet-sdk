// <copyright file="AgentRoleEnum.cs" company="APIMatic">
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
    /// AgentRoleEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgentRoleEnum
    {
        /// <summary>
        /// IntermediaryAgent1.
        /// </summary>
        [EnumMember(Value = "IntermediaryAgent1")]
        IntermediaryAgent1,

        /// <summary>
        /// IntermediaryAgent2.
        /// </summary>
        [EnumMember(Value = "IntermediaryAgent2")]
        IntermediaryAgent2,

        /// <summary>
        /// IntermediaryAgent3.
        /// </summary>
        [EnumMember(Value = "IntermediaryAgent3")]
        IntermediaryAgent3,

        /// <summary>
        /// InstructingAgent.
        /// </summary>
        [EnumMember(Value = "InstructingAgent")]
        InstructingAgent,

        /// <summary>
        /// InstructedAgent.
        /// </summary>
        [EnumMember(Value = "InstructedAgent")]
        InstructedAgent,

        /// <summary>
        /// AdditionalBeneficiaryPartyAgentInformation.
        /// </summary>
        [EnumMember(Value = "AdditionalBeneficiaryPartyAgentInformation")]
        AdditionalBeneficiaryPartyAgentInformation,

        /// <summary>
        /// CreditorAgent.
        /// </summary>
        [EnumMember(Value = "CreditorAgent")]
        CreditorAgent,

        /// <summary>
        /// DebtorAgent.
        /// </summary>
        [EnumMember(Value = "DebtorAgent")]
        DebtorAgent
    }
}