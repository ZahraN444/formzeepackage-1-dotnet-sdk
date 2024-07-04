// <copyright file="BranchIdentificationRelationships.cs" company="APIMatic">
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
    /// BranchIdentificationRelationships.
    /// </summary>
    public class BranchIdentificationRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationRelationships"/> class.
        /// </summary>
        public BranchIdentificationRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationRelationships"/> class.
        /// </summary>
        /// <param name="branch">branch.</param>
        public BranchIdentificationRelationships(
            Models.RelationshipLinks branch = null)
        {
            this.Branch = branch;
        }

        /// <summary>
        /// Gets or sets Branch.
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Branch { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BranchIdentificationRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is BranchIdentificationRelationships other &&                ((this.Branch == null && other.Branch == null) || (this.Branch?.Equals(other.Branch) == true));
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