// <copyright file="BranchIdentificationEventRelationships.cs" company="APIMatic">
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
    /// BranchIdentificationEventRelationships.
    /// </summary>
    public class BranchIdentificationEventRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationEventRelationships"/> class.
        /// </summary>
        public BranchIdentificationEventRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationEventRelationships"/> class.
        /// </summary>
        /// <param name="branch">branch.</param>
        public BranchIdentificationEventRelationships(
            Models.RelationshipBranch branch = null)
        {
            this.Branch = branch;
        }

        /// <summary>
        /// Gets or sets Branch.
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipBranch Branch { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BranchIdentificationEventRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is BranchIdentificationEventRelationships other &&                ((this.Branch == null && other.Branch == null) || (this.Branch?.Equals(other.Branch) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Branch = {(this.Branch == null ? "null" : this.Branch.ToString())}");
        }
    }
}