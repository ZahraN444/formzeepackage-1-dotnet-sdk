// <copyright file="TransactionFileRelationships.cs" company="APIMatic">
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
    /// TransactionFileRelationships.
    /// </summary>
    public class TransactionFileRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileRelationships"/> class.
        /// </summary>
        public TransactionFileRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileRelationships"/> class.
        /// </summary>
        /// <param name="reports">reports.</param>
        /// <param name="transactionFileAdmissions">transaction_file_admissions.</param>
        /// <param name="transactionFileSubmissions">transaction_file_submissions.</param>
        public TransactionFileRelationships(
            Models.ThinRelationship reports = null,
            Models.TransactionFileAdmissions transactionFileAdmissions = null,
            Models.TransactionFileSubmissions transactionFileSubmissions = null)
        {
            this.Reports = reports;
            this.TransactionFileAdmissions = transactionFileAdmissions;
            this.TransactionFileSubmissions = transactionFileSubmissions;
        }

        /// <summary>
        /// Gets or sets Reports.
        /// </summary>
        [JsonProperty("reports", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThinRelationship Reports { get; set; }

        /// <summary>
        /// Gets or sets TransactionFileAdmissions.
        /// </summary>
        [JsonProperty("transaction_file_admissions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFileAdmissions TransactionFileAdmissions { get; set; }

        /// <summary>
        /// Gets or sets TransactionFileSubmissions.
        /// </summary>
        [JsonProperty("transaction_file_submissions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFileSubmissions TransactionFileSubmissions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionFileRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionFileRelationships other &&                ((this.Reports == null && other.Reports == null) || (this.Reports?.Equals(other.Reports) == true)) &&
                ((this.TransactionFileAdmissions == null && other.TransactionFileAdmissions == null) || (this.TransactionFileAdmissions?.Equals(other.TransactionFileAdmissions) == true)) &&
                ((this.TransactionFileSubmissions == null && other.TransactionFileSubmissions == null) || (this.TransactionFileSubmissions?.Equals(other.TransactionFileSubmissions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reports = {(this.Reports == null ? "null" : this.Reports.ToString())}");
            toStringOutput.Add($"this.TransactionFileAdmissions = {(this.TransactionFileAdmissions == null ? "null" : this.TransactionFileAdmissions.ToString())}");
            toStringOutput.Add($"this.TransactionFileSubmissions = {(this.TransactionFileSubmissions == null ? "null" : this.TransactionFileSubmissions.ToString())}");
        }
    }
}