// <copyright file="QueryResponseAdmissionRelationships.cs" company="APIMatic">
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
    /// QueryResponseAdmissionRelationships.
    /// </summary>
    public class QueryResponseAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseAdmissionRelationships"/> class.
        /// </summary>
        public QueryResponseAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="query">query.</param>
        /// <param name="queryResponse">query_response.</param>
        /// <param name="recall">recall.</param>
        public QueryResponseAdmissionRelationships(
            Models.RelationshipsPayment payment = null,
            Models.RelationshipsQuery query = null,
            Models.RelationshipsQueryResponse queryResponse = null,
            Models.RelationshipsPaymentRecall recall = null)
        {
            this.Payment = payment;
            this.Query = query;
            this.QueryResponse = queryResponse;
            this.Recall = recall;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPayment Payment { get; set; }

        /// <summary>
        /// Gets or sets Query.
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsQuery Query { get; set; }

        /// <summary>
        /// Gets or sets QueryResponse.
        /// </summary>
        [JsonProperty("query_response", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsQueryResponse QueryResponse { get; set; }

        /// <summary>
        /// Gets or sets Recall.
        /// </summary>
        [JsonProperty("recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPaymentRecall Recall { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseAdmissionRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Query == null && other.Query == null) || (this.Query?.Equals(other.Query) == true)) &&
                ((this.QueryResponse == null && other.QueryResponse == null) || (this.QueryResponse?.Equals(other.QueryResponse) == true)) &&
                ((this.Recall == null && other.Recall == null) || (this.Recall?.Equals(other.Recall) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Query = {(this.Query == null ? "null" : this.Query.ToString())}");
            toStringOutput.Add($"this.QueryResponse = {(this.QueryResponse == null ? "null" : this.QueryResponse.ToString())}");
            toStringOutput.Add($"this.Recall = {(this.Recall == null ? "null" : this.Recall.ToString())}");
        }
    }
}