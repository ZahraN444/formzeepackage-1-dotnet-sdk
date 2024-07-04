// <copyright file="Attributes25.cs" company="APIMatic">
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
    /// Attributes25.
    /// </summary>
    public class Attributes25
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes25"/> class.
        /// </summary>
        public Attributes25()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes25"/> class.
        /// </summary>
        /// <param name="answer">answer.</param>
        /// <param name="reason">reason.</param>
        /// <param name="reasonCode">reason_code.</param>
        public Attributes25(
            Models.AnswerEnum? answer = null,
            string reason = null,
            string reasonCode = null)
        {
            this.Answer = answer;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// Answer to direct debit request. Only `rejected` can be used.
        /// </summary>
        [JsonProperty("answer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AnswerEnum? Answer { get; set; }

        /// <summary>
        /// Free text reason in addition to `reason_code`. Maximum length 105 characters for both inbound and outbound direct debit decisions.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Reason for a rejected decision. Required when answer is rejected, ignored otherwise. Has to be a valid SEPA direct debit decision reason code.
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes25 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes25 other &&                ((this.Answer == null && other.Answer == null) || (this.Answer?.Equals(other.Answer) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Answer = {(this.Answer == null ? "null" : this.Answer.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
        }
    }
}