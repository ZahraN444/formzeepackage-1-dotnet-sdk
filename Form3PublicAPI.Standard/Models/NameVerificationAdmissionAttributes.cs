// <copyright file="NameVerificationAdmissionAttributes.cs" company="APIMatic">
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
    /// NameVerificationAdmissionAttributes.
    /// </summary>
    public class NameVerificationAdmissionAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAdmissionAttributes"/> class.
        /// </summary>
        public NameVerificationAdmissionAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAdmissionAttributes"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="actualName">actual_name.</param>
        /// <param name="answer">answer.</param>
        /// <param name="reason">reason.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="statusReason">status_reason.</param>
        public NameVerificationAdmissionAttributes(
            Models.NameVerificationAdmissionStatusEnum status,
            string actualName = null,
            Models.NameVerificationAdmissionAnswerEnum? answer = null,
            string reason = null,
            Models.NameVerificationAdmissionReasonCodeEnum? reasonCode = null,
            string statusReason = null)
        {
            this.ActualName = actualName;
            this.Answer = answer;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.Status = status;
            this.StatusReason = statusReason;
        }

        /// <summary>
        /// Gets or sets ActualName.
        /// </summary>
        [JsonProperty("actual_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualName { get; set; }

        /// <summary>
        /// Gets or sets Answer.
        /// </summary>
        [JsonProperty("answer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NameVerificationAdmissionAnswerEnum? Answer { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NameVerificationAdmissionReasonCodeEnum? ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.NameVerificationAdmissionStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets StatusReason.
        /// </summary>
        [JsonProperty("status_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NameVerificationAdmissionAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is NameVerificationAdmissionAttributes other &&                ((this.ActualName == null && other.ActualName == null) || (this.ActualName?.Equals(other.ActualName) == true)) &&
                ((this.Answer == null && other.Answer == null) || (this.Answer?.Equals(other.Answer) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                this.Status.Equals(other.Status) &&
                ((this.StatusReason == null && other.StatusReason == null) || (this.StatusReason?.Equals(other.StatusReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActualName = {(this.ActualName == null ? "null" : this.ActualName)}");
            toStringOutput.Add($"this.Answer = {(this.Answer == null ? "null" : this.Answer.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode.ToString())}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.StatusReason = {(this.StatusReason == null ? "null" : this.StatusReason)}");
        }
    }
}