// <copyright file="QueryRelationships.cs" company="APIMatic">
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
    /// QueryRelationships.
    /// </summary>
    public class QueryRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRelationships"/> class.
        /// </summary>
        public QueryRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentAdmission">payment_admission.</param>
        /// <param name="paymentSubmission">payment_submission.</param>
        /// <param name="query">query.</param>
        /// <param name="queryAdmission">query_admission.</param>
        /// <param name="queryResponse">query_response.</param>
        /// <param name="querySubmission">query_submission.</param>
        /// <param name="recall">recall.</param>
        /// <param name="recallSubmission">recall_submission.</param>
        public QueryRelationships(
            Models.RelationshipsPayment payment = null,
            Models.RelationshipsPaymentAdmission paymentAdmission = null,
            Models.RelationshipsPaymentSubmission paymentSubmission = null,
            Models.RelationshipsQuery query = null,
            Models.RelationshipsQueryAdmission queryAdmission = null,
            Models.RelationshipsFullQueryResponse queryResponse = null,
            Models.RelationshipsQuerySubmission querySubmission = null,
            Models.RelationshipsPaymentRecall recall = null,
            Models.RelationshipsPaymentRecallSubmission recallSubmission = null)
        {
            this.Payment = payment;
            this.PaymentAdmission = paymentAdmission;
            this.PaymentSubmission = paymentSubmission;
            this.Query = query;
            this.QueryAdmission = queryAdmission;
            this.QueryResponse = queryResponse;
            this.QuerySubmission = querySubmission;
            this.Recall = recall;
            this.RecallSubmission = recallSubmission;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPayment Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentAdmission.
        /// </summary>
        [JsonProperty("payment_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPaymentAdmission PaymentAdmission { get; set; }

        /// <summary>
        /// Gets or sets PaymentSubmission.
        /// </summary>
        [JsonProperty("payment_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPaymentSubmission PaymentSubmission { get; set; }

        /// <summary>
        /// Gets or sets Query.
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsQuery Query { get; set; }

        /// <summary>
        /// Gets or sets QueryAdmission.
        /// </summary>
        [JsonProperty("query_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsQueryAdmission QueryAdmission { get; set; }

        /// <summary>
        /// Gets or sets QueryResponse.
        /// </summary>
        [JsonProperty("query_response", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsFullQueryResponse QueryResponse { get; set; }

        /// <summary>
        /// Gets or sets QuerySubmission.
        /// </summary>
        [JsonProperty("query_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsQuerySubmission QuerySubmission { get; set; }

        /// <summary>
        /// Gets or sets Recall.
        /// </summary>
        [JsonProperty("recall", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPaymentRecall Recall { get; set; }

        /// <summary>
        /// Gets or sets RecallSubmission.
        /// </summary>
        [JsonProperty("recall_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipsPaymentRecallSubmission RecallSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentAdmission == null && other.PaymentAdmission == null) || (this.PaymentAdmission?.Equals(other.PaymentAdmission) == true)) &&
                ((this.PaymentSubmission == null && other.PaymentSubmission == null) || (this.PaymentSubmission?.Equals(other.PaymentSubmission) == true)) &&
                ((this.Query == null && other.Query == null) || (this.Query?.Equals(other.Query) == true)) &&
                ((this.QueryAdmission == null && other.QueryAdmission == null) || (this.QueryAdmission?.Equals(other.QueryAdmission) == true)) &&
                ((this.QueryResponse == null && other.QueryResponse == null) || (this.QueryResponse?.Equals(other.QueryResponse) == true)) &&
                ((this.QuerySubmission == null && other.QuerySubmission == null) || (this.QuerySubmission?.Equals(other.QuerySubmission) == true)) &&
                ((this.Recall == null && other.Recall == null) || (this.Recall?.Equals(other.Recall) == true)) &&
                ((this.RecallSubmission == null && other.RecallSubmission == null) || (this.RecallSubmission?.Equals(other.RecallSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentAdmission = {(this.PaymentAdmission == null ? "null" : this.PaymentAdmission.ToString())}");
            toStringOutput.Add($"this.PaymentSubmission = {(this.PaymentSubmission == null ? "null" : this.PaymentSubmission.ToString())}");
            toStringOutput.Add($"this.Query = {(this.Query == null ? "null" : this.Query.ToString())}");
            toStringOutput.Add($"this.QueryAdmission = {(this.QueryAdmission == null ? "null" : this.QueryAdmission.ToString())}");
            toStringOutput.Add($"this.QueryResponse = {(this.QueryResponse == null ? "null" : this.QueryResponse.ToString())}");
            toStringOutput.Add($"this.QuerySubmission = {(this.QuerySubmission == null ? "null" : this.QuerySubmission.ToString())}");
            toStringOutput.Add($"this.Recall = {(this.Recall == null ? "null" : this.Recall.ToString())}");
            toStringOutput.Add($"this.RecallSubmission = {(this.RecallSubmission == null ? "null" : this.RecallSubmission.ToString())}");
        }
    }
}