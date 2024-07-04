// <copyright file="QueryResponseSubmissionRelationships.cs" company="APIMatic">
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
    /// QueryResponseSubmissionRelationships.
    /// </summary>
    public class QueryResponseSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseSubmissionRelationships"/> class.
        /// </summary>
        public QueryResponseSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="query">query.</param>
        /// <param name="queryResponse">query_response.</param>
        public QueryResponseSubmissionRelationships(
            Models.RelationshipsFullQuery query = null,
            Models.RelationshipsFullQueryResponse queryResponse = null)
        {
            this.Query = query;
            this.QueryResponse = queryResponse;
        }

        /// <summary>
        /// Gets or sets Query.
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsFullQuery Query { get; set; }

        /// <summary>
        /// Gets or sets QueryResponse.
        /// </summary>
        [JsonProperty("query_response", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsFullQueryResponse QueryResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseSubmissionRelationships other &&                ((this.Query == null && other.Query == null) || (this.Query?.Equals(other.Query) == true)) &&
                ((this.QueryResponse == null && other.QueryResponse == null) || (this.QueryResponse?.Equals(other.QueryResponse) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Query = {(this.Query == null ? "null" : this.Query.ToString())}");
            toStringOutput.Add($"this.QueryResponse = {(this.QueryResponse == null ? "null" : this.QueryResponse.ToString())}");
        }
    }
}