// <copyright file="Relationships20.cs" company="APIMatic">
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
    /// Relationships20.
    /// </summary>
    public class Relationships20
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships20"/> class.
        /// </summary>
        public Relationships20()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships20"/> class.
        /// </summary>
        /// <param name="decisionAdmission">decision_admission.</param>
        /// <param name="decisionSubmission">decision_submission.</param>
        /// <param name="payment">payment.</param>
        /// <param name="recall">recall.</param>
        public Relationships20(
            Models.RelationshipLinks decisionAdmission = null,
            Models.RelationshipLinks decisionSubmission = null,
            Models.RelationshipLinks payment = null,
            Models.RelationshipLinks recall = null)
        {
            this.DecisionAdmission = decisionAdmission;
            this.DecisionSubmission = decisionSubmission;
            this.Payment = payment;
            this.Recall = recall;
        }

        /// <summary>
        /// Gets or sets DecisionAdmission.
        /// </summary>
        [JsonProperty("decision_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks DecisionAdmission { get; set; }

        /// <summary>
        /// Gets or sets DecisionSubmission.
        /// </summary>
        [JsonProperty("decision_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks DecisionSubmission { get; set; }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Payment { get; set; }

        /// <summary>
        /// Gets or sets Recall.
        /// </summary>
        [JsonProperty("recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Recall { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships20 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships20 other &&                ((this.DecisionAdmission == null && other.DecisionAdmission == null) || (this.DecisionAdmission?.Equals(other.DecisionAdmission) == true)) &&
                ((this.DecisionSubmission == null && other.DecisionSubmission == null) || (this.DecisionSubmission?.Equals(other.DecisionSubmission) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Recall == null && other.Recall == null) || (this.Recall?.Equals(other.Recall) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DecisionAdmission = {(this.DecisionAdmission == null ? "null" : this.DecisionAdmission.ToString())}");
            toStringOutput.Add($"this.DecisionSubmission = {(this.DecisionSubmission == null ? "null" : this.DecisionSubmission.ToString())}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Recall = {(this.Recall == null ? "null" : this.Recall.ToString())}");
        }
    }
}