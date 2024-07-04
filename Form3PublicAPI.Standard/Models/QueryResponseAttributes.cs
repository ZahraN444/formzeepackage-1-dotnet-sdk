// <copyright file="QueryResponseAttributes.cs" company="APIMatic">
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
    /// QueryResponseAttributes.
    /// </summary>
    public class QueryResponseAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseAttributes"/> class.
        /// </summary>
        public QueryResponseAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseAttributes"/> class.
        /// </summary>
        /// <param name="answer">answer.</param>
        /// <param name="charges">charges.</param>
        /// <param name="compensation">compensation.</param>
        /// <param name="compensationAmount">compensation_amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="information">information.</param>
        /// <param name="statusCode">status_code.</param>
        public QueryResponseAttributes(
            Models.QueryResponseAnswerEnum answer,
            Models.QueryResponseCharges charges = null,
            Models.QueryResponseCompensation compensation = null,
            string compensationAmount = null,
            string currency = null,
            Models.QueryResponseInformation information = null,
            Models.QueryResponseStatusCodeEnum? statusCode = null)
        {
            this.Answer = answer;
            this.Charges = charges;
            this.Compensation = compensation;
            this.CompensationAmount = compensationAmount;
            this.Currency = currency;
            this.Information = information;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Gets or sets Answer.
        /// </summary>
        [JsonProperty("answer")]
        public Models.QueryResponseAnswerEnum Answer { get; set; }

        /// <summary>
        /// Gets or sets Charges.
        /// </summary>
        [JsonProperty("charges", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryResponseCharges Charges { get; set; }

        /// <summary>
        /// Gets or sets Compensation.
        /// </summary>
        [JsonProperty("compensation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryResponseCompensation Compensation { get; set; }

        /// <summary>
        /// Gets or sets CompensationAmount.
        /// </summary>
        [JsonProperty("compensation_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string CompensationAmount { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Information.
        /// </summary>
        [JsonProperty("information", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryResponseInformation Information { get; set; }

        /// <summary>
        /// Gets or sets StatusCode.
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QueryResponseStatusCodeEnum? StatusCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseAttributes other &&                this.Answer.Equals(other.Answer) &&
                ((this.Charges == null && other.Charges == null) || (this.Charges?.Equals(other.Charges) == true)) &&
                ((this.Compensation == null && other.Compensation == null) || (this.Compensation?.Equals(other.Compensation) == true)) &&
                ((this.CompensationAmount == null && other.CompensationAmount == null) || (this.CompensationAmount?.Equals(other.CompensationAmount) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Information == null && other.Information == null) || (this.Information?.Equals(other.Information) == true)) &&
                ((this.StatusCode == null && other.StatusCode == null) || (this.StatusCode?.Equals(other.StatusCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Answer = {this.Answer}");
            toStringOutput.Add($"this.Charges = {(this.Charges == null ? "null" : this.Charges.ToString())}");
            toStringOutput.Add($"this.Compensation = {(this.Compensation == null ? "null" : this.Compensation.ToString())}");
            toStringOutput.Add($"this.CompensationAmount = {(this.CompensationAmount == null ? "null" : this.CompensationAmount)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Information = {(this.Information == null ? "null" : this.Information.ToString())}");
            toStringOutput.Add($"this.StatusCode = {(this.StatusCode == null ? "null" : this.StatusCode.ToString())}");
        }
    }
}