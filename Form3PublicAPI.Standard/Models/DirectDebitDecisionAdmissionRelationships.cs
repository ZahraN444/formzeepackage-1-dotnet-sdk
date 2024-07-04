// <copyright file="DirectDebitDecisionAdmissionRelationships.cs" company="APIMatic">
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
    /// DirectDebitDecisionAdmissionRelationships.
    /// </summary>
    public class DirectDebitDecisionAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitDecisionAdmissionRelationships"/> class.
        /// </summary>
        public DirectDebitDecisionAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitDecisionAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="directDebit">direct_debit.</param>
        /// <param name="directDebitDecision">direct_debit_decision.</param>
        public DirectDebitDecisionAdmissionRelationships(
            Models.DirectDebit1 directDebit = null,
            Models.DirectDebitDecision2 directDebitDecision = null)
        {
            this.DirectDebit = directDebit;
            this.DirectDebitDecision = directDebitDecision;
        }

        /// <summary>
        /// Gets or sets DirectDebit.
        /// </summary>
        [JsonProperty("direct_debit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebit1 DirectDebit { get; set; }

        /// <summary>
        /// Gets or sets DirectDebitDecision.
        /// </summary>
        [JsonProperty("direct_debit_decision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDecision2 DirectDebitDecision { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitDecisionAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitDecisionAdmissionRelationships other &&                ((this.DirectDebit == null && other.DirectDebit == null) || (this.DirectDebit?.Equals(other.DirectDebit) == true)) &&
                ((this.DirectDebitDecision == null && other.DirectDebitDecision == null) || (this.DirectDebitDecision?.Equals(other.DirectDebitDecision) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DirectDebit = {(this.DirectDebit == null ? "null" : this.DirectDebit.ToString())}");
            toStringOutput.Add($"this.DirectDebitDecision = {(this.DirectDebitDecision == null ? "null" : this.DirectDebitDecision.ToString())}");
        }
    }
}