// <copyright file="ClaimReversalSubmissionRelationships.cs" company="APIMatic">
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
    /// ClaimReversalSubmissionRelationships.
    /// </summary>
    public class ClaimReversalSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimReversalSubmissionRelationships"/> class.
        /// </summary>
        public ClaimReversalSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimReversalSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="claim">claim.</param>
        /// <param name="claimReversal">claim_reversal.</param>
        public ClaimReversalSubmissionRelationships(
            Models.Claim1 claim = null,
            Models.ClaimReversal2 claimReversal = null)
        {
            this.Claim = claim;
            this.ClaimReversal = claimReversal;
        }

        /// <summary>
        /// Gets or sets Claim.
        /// </summary>
        [JsonProperty("claim", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Claim1 Claim { get; set; }

        /// <summary>
        /// Gets or sets ClaimReversal.
        /// </summary>
        [JsonProperty("claim_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimReversal2 ClaimReversal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClaimReversalSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClaimReversalSubmissionRelationships other &&                ((this.Claim == null && other.Claim == null) || (this.Claim?.Equals(other.Claim) == true)) &&
                ((this.ClaimReversal == null && other.ClaimReversal == null) || (this.ClaimReversal?.Equals(other.ClaimReversal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Claim = {(this.Claim == null ? "null" : this.Claim.ToString())}");
            toStringOutput.Add($"this.ClaimReversal = {(this.ClaimReversal == null ? "null" : this.ClaimReversal.ToString())}");
        }
    }
}