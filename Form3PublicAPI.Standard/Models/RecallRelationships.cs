// <copyright file="RecallRelationships.cs" company="APIMatic">
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
    /// RecallRelationships.
    /// </summary>
    public class RecallRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecallRelationships"/> class.
        /// </summary>
        public RecallRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecallRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="recallAdmission">recall_admission.</param>
        /// <param name="recallDecisions">recall_decisions.</param>
        /// <param name="recallReversal">recall_reversal.</param>
        /// <param name="recallSubmission">recall_submission.</param>
        public RecallRelationships(
            Models.RelationshipLinks payment = null,
            Models.RelationshipLinks recallAdmission = null,
            Models.RelationshipLinks recallDecisions = null,
            Models.RelationshipLinks recallReversal = null,
            Models.RelationshipLinks recallSubmission = null)
        {
            this.Payment = payment;
            this.RecallAdmission = recallAdmission;
            this.RecallDecisions = recallDecisions;
            this.RecallReversal = recallReversal;
            this.RecallSubmission = recallSubmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Payment { get; set; }

        /// <summary>
        /// Gets or sets RecallAdmission.
        /// </summary>
        [JsonProperty("recall_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks RecallAdmission { get; set; }

        /// <summary>
        /// Gets or sets RecallDecisions.
        /// </summary>
        [JsonProperty("recall_decisions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks RecallDecisions { get; set; }

        /// <summary>
        /// Gets or sets RecallReversal.
        /// </summary>
        [JsonProperty("recall_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks RecallReversal { get; set; }

        /// <summary>
        /// Gets or sets RecallSubmission.
        /// </summary>
        [JsonProperty("recall_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks RecallSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecallRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is RecallRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.RecallAdmission == null && other.RecallAdmission == null) || (this.RecallAdmission?.Equals(other.RecallAdmission) == true)) &&
                ((this.RecallDecisions == null && other.RecallDecisions == null) || (this.RecallDecisions?.Equals(other.RecallDecisions) == true)) &&
                ((this.RecallReversal == null && other.RecallReversal == null) || (this.RecallReversal?.Equals(other.RecallReversal) == true)) &&
                ((this.RecallSubmission == null && other.RecallSubmission == null) || (this.RecallSubmission?.Equals(other.RecallSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.RecallAdmission = {(this.RecallAdmission == null ? "null" : this.RecallAdmission.ToString())}");
            toStringOutput.Add($"this.RecallDecisions = {(this.RecallDecisions == null ? "null" : this.RecallDecisions.ToString())}");
            toStringOutput.Add($"this.RecallReversal = {(this.RecallReversal == null ? "null" : this.RecallReversal.ToString())}");
            toStringOutput.Add($"this.RecallSubmission = {(this.RecallSubmission == null ? "null" : this.RecallSubmission.ToString())}");
        }
    }
}