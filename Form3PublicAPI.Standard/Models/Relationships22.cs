// <copyright file="Relationships22.cs" company="APIMatic">
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
    /// Relationships22.
    /// </summary>
    public class Relationships22
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships22"/> class.
        /// </summary>
        public Relationships22()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships22"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="recall">recall.</param>
        /// <param name="recallReversal">recall_reversal.</param>
        public Relationships22(
            Models.RelationshipPayments payment = null,
            Models.RelationshipRecalls recall = null,
            Models.RelationshipRecallReversals recallReversal = null)
        {
            this.Payment = payment;
            this.Recall = recall;
            this.RecallReversal = recallReversal;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets Recall.
        /// </summary>
        [JsonProperty("recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipRecalls Recall { get; set; }

        /// <summary>
        /// Gets or sets RecallReversal.
        /// </summary>
        [JsonProperty("recall_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipRecallReversals RecallReversal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships22 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships22 other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Recall == null && other.Recall == null) || (this.Recall?.Equals(other.Recall) == true)) &&
                ((this.RecallReversal == null && other.RecallReversal == null) || (this.RecallReversal?.Equals(other.RecallReversal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Recall = {(this.Recall == null ? "null" : this.Recall.ToString())}");
            toStringOutput.Add($"this.RecallReversal = {(this.RecallReversal == null ? "null" : this.RecallReversal.ToString())}");
        }
    }
}