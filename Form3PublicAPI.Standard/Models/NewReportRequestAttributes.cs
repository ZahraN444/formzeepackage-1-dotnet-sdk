// <copyright file="NewReportRequestAttributes.cs" company="APIMatic">
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
    /// NewReportRequestAttributes.
    /// </summary>
    public class NewReportRequestAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewReportRequestAttributes"/> class.
        /// </summary>
        public NewReportRequestAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewReportRequestAttributes"/> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="reportType">report_type.</param>
        public NewReportRequestAttributes(
            Models.NewReportRequestFilter filter,
            string paymentScheme,
            string reportType)
        {
            this.Filter = filter;
            this.PaymentScheme = paymentScheme;
            this.ReportType = reportType;
        }

        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty("filter")]
        public Models.NewReportRequestFilter Filter { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NewReportRequestAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is NewReportRequestAttributes other &&                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                ((this.ReportType == null && other.ReportType == null) || (this.ReportType?.Equals(other.ReportType) == true));
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
        }
    }
}