// <copyright file="Attributes57.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Attributes57.
    /// </summary>
    public class Attributes57
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes57"/> class.
        /// </summary>
        public Attributes57()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes57"/> class.
        /// </summary>
        /// <param name="agents">agents.</param>
        /// <param name="answer">answer.</param>
        /// <param name="chargesAmount">charges_amount.</param>
        /// <param name="reason">reason.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="recallAmount">recall_amount.</param>
        /// <param name="resolutionRelatedInformation">resolution_related_information.</param>
        public Attributes57(
            List<Models.Agent> agents = null,
            Models.RecallDecisionAnswerEnum? answer = null,
            Models.CurrencyAndAmount chargesAmount = null,
            string reason = null,
            string reasonCode = null,
            Models.CurrencyAndAmount recallAmount = null,
            Models.ResolutionRelatedInformation resolutionRelatedInformation = null)
        {
            this.Agents = agents;
            this.Answer = answer;
            this.ChargesAmount = chargesAmount;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.RecallAmount = recallAmount;
            this.ResolutionRelatedInformation = resolutionRelatedInformation;
        }

        /// <summary>
        /// Block to represent a Financial Institution/agent in the payment chain
        /// </summary>
        [JsonProperty("agents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Agent> Agents { get; set; }

        /// <summary>
        /// Answer to the recall request. Can either be `accepted` or `rejected`.
        /// </summary>
        [JsonProperty("answer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecallDecisionAnswerEnum? Answer { get; set; }

        /// <summary>
        /// Gets or sets ChargesAmount.
        /// </summary>
        [JsonProperty("charges_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyAndAmount ChargesAmount { get; set; }

        /// <summary>
        /// Optional free text reason in addition to `reason_code`
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Reason for a rejected decision. Required when answer is rejected, ignored otherwise. Has to be a valid [rejected recall decision reason code](http://api-docs.form3.tech/api.html#enumerations-rejected-recall-decision-reason-codes)
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets RecallAmount.
        /// </summary>
        [JsonProperty("recall_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyAndAmount RecallAmount { get; set; }

        /// <summary>
        /// Gets or sets ResolutionRelatedInformation.
        /// </summary>
        [JsonProperty("resolution_related_information", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResolutionRelatedInformation ResolutionRelatedInformation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes57 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Attributes57 other &&                ((this.Agents == null && other.Agents == null) || (this.Agents?.Equals(other.Agents) == true)) &&
                ((this.Answer == null && other.Answer == null) || (this.Answer?.Equals(other.Answer) == true)) &&
                ((this.ChargesAmount == null && other.ChargesAmount == null) || (this.ChargesAmount?.Equals(other.ChargesAmount) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.RecallAmount == null && other.RecallAmount == null) || (this.RecallAmount?.Equals(other.RecallAmount) == true)) &&
                ((this.ResolutionRelatedInformation == null && other.ResolutionRelatedInformation == null) || (this.ResolutionRelatedInformation?.Equals(other.ResolutionRelatedInformation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Agents = {(this.Agents == null ? "null" : $"[{string.Join(", ", this.Agents)} ]")}");
            toStringOutput.Add($"this.Answer = {(this.Answer == null ? "null" : this.Answer.ToString())}");
            toStringOutput.Add($"this.ChargesAmount = {(this.ChargesAmount == null ? "null" : this.ChargesAmount.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.RecallAmount = {(this.RecallAmount == null ? "null" : this.RecallAmount.ToString())}");
            toStringOutput.Add($"this.ResolutionRelatedInformation = {(this.ResolutionRelatedInformation == null ? "null" : this.ResolutionRelatedInformation.ToString())}");
        }
    }
}