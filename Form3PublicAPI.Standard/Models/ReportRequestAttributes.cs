// <copyright file="ReportRequestAttributes.cs" company="APIMatic">
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
    /// ReportRequestAttributes.
    /// </summary>
    public class ReportRequestAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestAttributes"/> class.
        /// </summary>
        public ReportRequestAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestAttributes"/> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="reportType">report_type.</param>
        /// <param name="status">status.</param>
        public ReportRequestAttributes(
            Models.ReportRequestFilter filter,
            string paymentScheme,
            string reportType,
            Models.ReportRequestStatusEnum status)
        {
            this.Filter = filter;
            this.PaymentScheme = paymentScheme;
            this.ReportType = reportType;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty("filter")]
        public Models.ReportRequestFilter Filter { get; set; }

        /// <summary>
        /// Gets or sets PaymentScheme.
        /// </summary>
        [JsonProperty("payment_scheme")]
        public string PaymentScheme { get; set; }

        /// <summary>
        /// Gets or sets ReportType.
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.ReportRequestStatusEnum Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRequestAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRequestAttributes other &&                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                ((this.ReportType == null && other.ReportType == null) || (this.ReportType?.Equals(other.ReportType) == true)) &&
                this.Status.Equals(other.Status);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"this.PaymentScheme = {(this.PaymentScheme == null ? "null" : this.PaymentScheme)}");
            toStringOutput.Add($"this.ReportType = {(this.ReportType == null ? "null" : this.ReportType)}");
            toStringOutput.Add($"this.Status = {this.Status}");
        }
    }
}