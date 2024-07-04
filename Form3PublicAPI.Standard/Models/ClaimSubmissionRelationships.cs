// <copyright file="ClaimSubmissionRelationships.cs" company="APIMatic">
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
    /// ClaimSubmissionRelationships.
    /// </summary>
    public class ClaimSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimSubmissionRelationships"/> class.
        /// </summary>
        public ClaimSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="claim">claim.</param>
        public ClaimSubmissionRelationships(
            Models.Claim1 claim = null)
        {
            this.Claim = claim;
        }

        /// <summary>
        /// Gets or sets Claim.
        /// </summary>
        [JsonProperty("claim", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Claim1 Claim { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClaimSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClaimSubmissionRelationships other &&                ((this.Claim == null && other.Claim == null) || (this.Claim?.Equals(other.Claim) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Claim = {(this.Claim == null ? "null" : this.Claim.ToString())}");
        }
    }
}