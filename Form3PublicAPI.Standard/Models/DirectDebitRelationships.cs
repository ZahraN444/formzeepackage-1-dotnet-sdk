// <copyright file="DirectDebitRelationships.cs" company="APIMatic">
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
    /// DirectDebitRelationships.
    /// </summary>
    public class DirectDebitRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitRelationships"/> class.
        /// </summary>
        public DirectDebitRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitRelationships"/> class.
        /// </summary>
        /// <param name="directDebitAdmission">direct_debit_admission.</param>
        /// <param name="directDebitDecision">direct_debit_decision.</param>
        /// <param name="directDebitRecall">direct_debit_recall.</param>
        /// <param name="directDebitReturn">direct_debit_return.</param>
        /// <param name="directDebitReversal">direct_debit_reversal.</param>
        /// <param name="directDebitSubmission">direct_debit_submission.</param>
        /// <param name="mandate">mandate.</param>
        public DirectDebitRelationships(
            Models.DirectDebitAdmission2 directDebitAdmission = null,
            Models.DirectDebitDecision2 directDebitDecision = null,
            Models.DirectDebitRecall2 directDebitRecall = null,
            Models.DirectDebitReturn2 directDebitReturn = null,
            Models.DirectDebitReversal2 directDebitReversal = null,
            Models.DirectDebitSubmission2 directDebitSubmission = null,
            Models.Mandate6 mandate = null)
        {
            this.DirectDebitAdmission = directDebitAdmission;
            this.DirectDebitDecision = directDebitDecision;
            this.DirectDebitRecall = directDebitRecall;
            this.DirectDebitReturn = directDebitReturn;
            this.DirectDebitReversal = directDebitReversal;
            this.DirectDebitSubmission = directDebitSubmission;
            this.Mandate = mandate;
        }

        /// <summary>
        /// Gets or sets DirectDebitAdmission.
        /// </summary>
        [JsonProperty("direct_debit_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitAdmission2 DirectDebitAdmission { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitDecision.
        /// </summary>
        [JsonProperty("direct_debit_decision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDecision2 DirectDebitDecision { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitRecall.
        /// </summary>
        [JsonProperty("direct_debit_recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitRecall2 DirectDebitRecall { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReturn.
        /// </summary>
        [JsonProperty("direct_debit_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturn2 DirectDebitReturn { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitReversal.
        /// </summary>
        [JsonProperty("direct_debit_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReversal2 DirectDebitReversal { get; set; }

        /// <summary>
        /// The submission resource related to the direct debit
        /// </summary>
        [JsonProperty("direct_debit_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitSubmission2 DirectDebitSubmission { get; set; }

        /// <summary>
        /// Gets or sets Mandate.
        /// </summary>
        [JsonProperty("mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mandate6 Mandate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitRelationships other &&                ((this.DirectDebitAdmission == null && other.DirectDebitAdmission == null) || (this.DirectDebitAdmission?.Equals(other.DirectDebitAdmission) == true)) &&
                ((this.DirectDebitDecision == null && other.DirectDebitDecision == null) || (this.DirectDebitDecision?.Equals(other.DirectDebitDecision) == true)) &&
                ((this.DirectDebitRecall == null && other.DirectDebitRecall == null) || (this.DirectDebitRecall?.Equals(other.DirectDebitRecall) == true)) &&
                ((this.DirectDebitReturn == null && other.DirectDebitReturn == null) || (this.DirectDebitReturn?.Equals(other.DirectDebitReturn) == true)) &&
                ((this.DirectDebitReversal == null && other.DirectDebitReversal == null) || (this.DirectDebitReversal?.Equals(other.DirectDebitReversal) == true)) &&
                ((this.DirectDebitSubmission == null && other.DirectDebitSubmission == null) || (this.DirectDebitSubmission?.Equals(other.DirectDebitSubmission) == true)) &&
                ((this.Mandate == null && other.Mandate == null) || (this.Mandate?.Equals(other.Mandate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebitAdmission = {(this.DirectDebitAdmission == null ? "null" : this.DirectDebitAdmission.ToString())}");
            toStringOutput.Add($"this.DirectDebitDecision = {(this.DirectDebitDecision == null ? "null" : this.DirectDebitDecision.ToString())}");
            toStringOutput.Add($"this.DirectDebitRecall = {(this.DirectDebitRecall == null ? "null" : this.DirectDebitRecall.ToString())}");
            toStringOutput.Add($"this.DirectDebitReturn = {(this.DirectDebitReturn == null ? "null" : this.DirectDebitReturn.ToString())}");
            toStringOutput.Add($"this.DirectDebitReversal = {(this.DirectDebitReversal == null ? "null" : this.DirectDebitReversal.ToString())}");
            toStringOutput.Add($"this.DirectDebitSubmission = {(this.DirectDebitSubmission == null ? "null" : this.DirectDebitSubmission.ToString())}");
            toStringOutput.Add($"this.Mandate = {(this.Mandate == null ? "null" : this.Mandate.ToString())}");
        }
    }
}