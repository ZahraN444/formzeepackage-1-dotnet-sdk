// <copyright file="QuerySubmissionRelationships.cs" company="APIMatic">
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
    /// QuerySubmissionRelationships.
    /// </summary>
    public class QuerySubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySubmissionRelationships"/> class.
        /// </summary>
        public QuerySubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySubmissionRelationships"/> class.
        /// </summary>
        /// <param name="query">query.</param>
        public QuerySubmissionRelationships(
            Models.RelationshipsQuery query)
        {
            this.Query = query;
        }

        /// <summary>
        /// Gets or sets Query.
        /// </summary>
        [JsonProperty("query")]
        public Models.RelationshipsQuery Query { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QuerySubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is QuerySubmissionRelationships other &&                ((this.Query == null && other.Query == null) || (this.Query?.Equals(other.Query) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Query = {(this.Query == null ? "null" : this.Query.ToString())}");
        }
    }
}