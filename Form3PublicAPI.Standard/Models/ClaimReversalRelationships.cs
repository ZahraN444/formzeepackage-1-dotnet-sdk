// <copyright file="ClaimReversalRelationships.cs" company="APIMatic">
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
    /// ClaimReversalRelationships.
    /// </summary>
    public class ClaimReversalRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimReversalRelationships"/> class.
        /// </summary>
        public ClaimReversalRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimReversalRelationships"/> class.
        /// </summary>
        /// <param name="claim">claim.</param>
        /// <param name="claimReversalSubmission">claim_reversal_submission.</param>
        public ClaimReversalRelationships(
            Models.Claim1 claim = null,
            Models.ClaimReversalSubmission2 claimReversalSubmission = null)
        {
            this.Claim = claim;
            this.ClaimReversalSubmission = claimReversalSubmission;
        }

        /// <summary>
        /// Gets or sets Claim.
        /// </summary>
        [JsonProperty("claim", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Claim1 Claim { get; set; }

        /// <summary>
        /// Gets or sets ClaimReversalSubmission.
        /// </summary>
        [JsonProperty("claim_reversal_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimReversalSubmission2 ClaimReversalSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClaimReversalRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClaimReversalRelationships other &&                ((this.Claim == null && other.Claim == null) || (this.Claim?.Equals(other.Claim) == true)) &&
                ((this.ClaimReversalSubmission == null && other.ClaimReversalSubmission == null) || (this.ClaimReversalSubmission?.Equals(other.ClaimReversalSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Claim = {(this.Claim == null ? "null" : this.Claim.ToString())}");
            toStringOutput.Add($"this.ClaimReversalSubmission = {(this.ClaimReversalSubmission == null ? "null" : this.ClaimReversalSubmission.ToString())}");
        }
    }
}