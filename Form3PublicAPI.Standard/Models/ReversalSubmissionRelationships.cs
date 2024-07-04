// <copyright file="ReversalSubmissionRelationships.cs" company="APIMatic">
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
    /// ReversalSubmissionRelationships.
    /// </summary>
    public class ReversalSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalSubmissionRelationships"/> class.
        /// </summary>
        public ReversalSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="reversal">reversal.</param>
        /// <param name="validations">validations.</param>
        public ReversalSubmissionRelationships(
            Models.RelationshipPayments payment = null,
            Models.RelationshipReversals reversal = null,
            Models.RelationshipLinks validations = null)
        {
            this.Payment = payment;
            this.Reversal = reversal;
            this.Validations = validations;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets Reversal.
        /// </summary>
        [JsonProperty("reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReversals Reversal { get; set; }

        /// <summary>
        /// Gets or sets Validations.
        /// </summary>
        [JsonProperty("validations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Validations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReversalSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReversalSubmissionRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Reversal == null && other.Reversal == null) || (this.Reversal?.Equals(other.Reversal) == true)) &&
                ((this.Validations == null && other.Validations == null) || (this.Validations?.Equals(other.Validations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Reversal = {(this.Reversal == null ? "null" : this.Reversal.ToString())}");
            toStringOutput.Add($"this.Validations = {(this.Validations == null ? "null" : this.Validations.ToString())}");
        }
    }
}