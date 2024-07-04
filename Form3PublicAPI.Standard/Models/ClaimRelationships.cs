// <copyright file="ClaimRelationships.cs" company="APIMatic">
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
    /// ClaimRelationships.
    /// </summary>
    public class ClaimRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRelationships"/> class.
        /// </summary>
        public ClaimRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRelationships"/> class.
        /// </summary>
        /// <param name="claimReversal">claim_reversal.</param>
        /// <param name="claimSubmission">claim_submission.</param>
        public ClaimRelationships(
            Models.ClaimReversal2 claimReversal = null,
            Models.ClaimSubmission2 claimSubmission = null)
        {
            this.ClaimReversal = claimReversal;
            this.ClaimSubmission = claimSubmission;
        }

        /// <summary>
        /// Gets or sets ClaimReversal.
        /// </summary>
        [JsonProperty("claim_reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimReversal2 ClaimReversal { get; set; }

        /// <summary>
        /// Gets or sets ClaimSubmission.
        /// </summary>
        [JsonProperty("claim_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimSubmission2 ClaimSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClaimRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClaimRelationships other &&                ((this.ClaimReversal == null && other.ClaimReversal == null) || (this.ClaimReversal?.Equals(other.ClaimReversal) == true)) &&
                ((this.ClaimSubmission == null && other.ClaimSubmission == null) || (this.ClaimSubmission?.Equals(other.ClaimSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClaimReversal = {(this.ClaimReversal == null ? "null" : this.ClaimReversal.ToString())}");
            toStringOutput.Add($"this.ClaimSubmission = {(this.ClaimSubmission == null ? "null" : this.ClaimSubmission.ToString())}");
        }
    }
}