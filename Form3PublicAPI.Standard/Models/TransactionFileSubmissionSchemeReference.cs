// <copyright file="TransactionFileSubmissionSchemeReference.cs" company="APIMatic">
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
    /// TransactionFileSubmissionSchemeReference.
    /// </summary>
    public class TransactionFileSubmissionSchemeReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileSubmissionSchemeReference"/> class.
        /// </summary>
        public TransactionFileSubmissionSchemeReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileSubmissionSchemeReference"/> class.
        /// </summary>
        /// <param name="clearingId">clearing_id.</param>
        /// <param name="fileIdentifier">file_identifier.</param>
        /// <param name="fileNumber">file_number.</param>
        /// <param name="transactionCount">transaction_count.</param>
        /// <param name="transactionSum">transaction_sum.</param>
        public TransactionFileSubmissionSchemeReference(
            string clearingId = null,
            string fileIdentifier = null,
            string fileNumber = null,
            int? transactionCount = null,
            string transactionSum = null)
        {
            this.ClearingId = clearingId;
            this.FileIdentifier = fileIdentifier;
            this.FileNumber = fileNumber;
            this.TransactionCount = transactionCount;
            this.TransactionSum = transactionSum;
        }

        /// <summary>
        /// Service User Number (SUN) of the payment originator
        /// </summary>
        [JsonProperty("clearing_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClearingId { get; set; }

        /// <summary>
        /// Submission serial number
        /// </summary>
        [JsonProperty("file_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string FileIdentifier { get; set; }

        /// <summary>
        /// Number of the file sent to the scheme
        /// </summary>
        [JsonProperty("file_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FileNumber { get; set; }

        /// <summary>
        /// The count of transactions submitted in a given scheme file
        /// </summary>
        [JsonProperty("transaction_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransactionCount { get; set; }

        /// <summary>
        /// The sum of transactions submitted in a given scheme file
        /// </summary>
        [JsonProperty("transaction_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionSum { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionFileSubmissionSchemeReference : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionFileSubmissionSchemeReference other &&                ((this.ClearingId == null && other.ClearingId == null) || (this.ClearingId?.Equals(other.ClearingId) == true)) &&
                ((this.FileIdentifier == null && other.FileIdentifier == null) || (this.FileIdentifier?.Equals(other.FileIdentifier) == true)) &&
                ((this.FileNumber == null && other.FileNumber == null) || (this.FileNumber?.Equals(other.FileNumber) == true)) &&
                ((this.TransactionCount == null && other.TransactionCount == null) || (this.TransactionCount?.Equals(other.TransactionCount) == true)) &&
                ((this.TransactionSum == null && other.TransactionSum == null) || (this.TransactionSum?.Equals(other.TransactionSum) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClearingId = {(this.ClearingId == null ? "null" : this.ClearingId)}");
            toStringOutput.Add($"this.FileIdentifier = {(this.FileIdentifier == null ? "null" : this.FileIdentifier)}");
            toStringOutput.Add($"this.FileNumber = {(this.FileNumber == null ? "null" : this.FileNumber)}");
            toStringOutput.Add($"this.TransactionCount = {(this.TransactionCount == null ? "null" : this.TransactionCount.ToString())}");
            toStringOutput.Add($"this.TransactionSum = {(this.TransactionSum == null ? "null" : this.TransactionSum)}");
        }
    }
}