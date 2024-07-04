// <copyright file="QueryResponseRelationships.cs" company="APIMatic">
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
    /// QueryResponseRelationships.
    /// </summary>
    public class QueryResponseRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseRelationships"/> class.
        /// </summary>
        public QueryResponseRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseRelationships"/> class.
        /// </summary>
        /// <param name="query">query.</param>
        /// <param name="queryResponseAdmission">query_response_admission.</param>
        /// <param name="queryResponseSubmission">query_response_submission.</param>
        public QueryResponseRelationships(
            Models.RelationshipsFullQuery query = null,
            Models.RelationshipQueryResponseAdmission queryResponseAdmission = null,
            Models.RelationshipQueryResponseSubmission queryResponseSubmission = null)
        {
            this.Query = query;
            this.QueryResponseAdmission = queryResponseAdmission;
            this.QueryResponseSubmission = queryResponseSubmission;
        }

        /// <summary>
        /// Gets or sets Query.
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsFullQuery Query { get; set; }

        /// <summary>
        /// Gets or sets QueryResponseAdmission.
        /// </summary>
        [JsonProperty("query_response_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipQueryResponseAdmission QueryResponseAdmission { get; set; }

        /// <summary>
        /// Gets or sets QueryResponseSubmission.
        /// </summary>
        [JsonProperty("query_response_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipQueryResponseSubmission QueryResponseSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseRelationships other &&                ((this.Query == null && other.Query == null) || (this.Query?.Equals(other.Query) == true)) &&
                ((this.QueryResponseAdmission == null && other.QueryResponseAdmission == null) || (this.QueryResponseAdmission?.Equals(other.QueryResponseAdmission) == true)) &&
                ((this.QueryResponseSubmission == null && other.QueryResponseSubmission == null) || (this.QueryResponseSubmission?.Equals(other.QueryResponseSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Query = {(this.Query == null ? "null" : this.Query.ToString())}");
            toStringOutput.Add($"this.QueryResponseAdmission = {(this.QueryResponseAdmission == null ? "null" : this.QueryResponseAdmission.ToString())}");
            toStringOutput.Add($"this.QueryResponseSubmission = {(this.QueryResponseSubmission == null ? "null" : this.QueryResponseSubmission.ToString())}");
        }
    }
}