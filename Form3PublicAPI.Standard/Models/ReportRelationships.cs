// <copyright file="ReportRelationships.cs" company="APIMatic">
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
    /// ReportRelationships.
    /// </summary>
    public class ReportRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRelationships"/> class.
        /// </summary>
        public ReportRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRelationships"/> class.
        /// </summary>
        /// <param name="reportAdmission">report_admission.</param>
        /// <param name="reportRequest">report_request.</param>
        /// <param name="transactionFile">transaction_file.</param>
        public ReportRelationships(
            Models.ReportAdmission2 reportAdmission = null,
            Models.ReportRequest1 reportRequest = null,
            Models.ThinRelationship transactionFile = null)
        {
            this.ReportAdmission = reportAdmission;
            this.ReportRequest = reportRequest;
            this.TransactionFile = transactionFile;
        }

        /// <summary>
        /// Gets or sets ReportAdmission.
        /// </summary>
        [JsonProperty("report_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportAdmission2 ReportAdmission { get; set; }

        /// <summary>
        /// Gets or sets ReportRequest.
        /// </summary>
        [JsonProperty("report_request", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportRequest1 ReportRequest { get; set; }

        /// <summary>
        /// Gets or sets TransactionFile.
        /// </summary>
        [JsonProperty("transaction_file", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThinRelationship TransactionFile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRelationships other &&                ((this.ReportAdmission == null && other.ReportAdmission == null) || (this.ReportAdmission?.Equals(other.ReportAdmission) == true)) &&
                ((this.ReportRequest == null && other.ReportRequest == null) || (this.ReportRequest?.Equals(other.ReportRequest) == true)) &&
                ((this.TransactionFile == null && other.TransactionFile == null) || (this.TransactionFile?.Equals(other.TransactionFile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReportAdmission = {(this.ReportAdmission == null ? "null" : this.ReportAdmission.ToString())}");
            toStringOutput.Add($"this.ReportRequest = {(this.ReportRequest == null ? "null" : this.ReportRequest.ToString())}");
            toStringOutput.Add($"this.TransactionFile = {(this.TransactionFile == null ? "null" : this.TransactionFile.ToString())}");
        }
    }
}