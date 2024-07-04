// <copyright file="ReturnSubmissionRelationships.cs" company="APIMatic">
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
    /// ReturnSubmissionRelationships.
    /// </summary>
    public class ReturnSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionRelationships"/> class.
        /// </summary>
        public ReturnSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="paymentReturn">payment_return.</param>
        /// <param name="returnSubmissionTask">return_submission_task.</param>
        /// <param name="validations">validations.</param>
        public ReturnSubmissionRelationships(
            Models.RelationshipPayments payment = null,
            Models.RelationshipReturns paymentReturn = null,
            Models.RelationshipReturnSubmissionTasks returnSubmissionTask = null,
            Models.RelationshipLinks validations = null)
        {
            this.Payment = payment;
            this.PaymentReturn = paymentReturn;
            this.ReturnSubmissionTask = returnSubmissionTask;
            this.Validations = validations;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets PaymentReturn.
        /// </summary>
        [JsonProperty("payment_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReturns PaymentReturn { get; set; }

        /// <summary>
        /// Gets or sets ReturnSubmissionTask.
        /// </summary>
        [JsonProperty("return_submission_task", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReturnSubmissionTasks ReturnSubmissionTask { get; set; }

        /// <summary>
        /// Gets or sets Validations.
        /// </summary>
        [JsonProperty("validations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Validations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnSubmissionRelationships other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.PaymentReturn == null && other.PaymentReturn == null) || (this.PaymentReturn?.Equals(other.PaymentReturn) == true)) &&
                ((this.ReturnSubmissionTask == null && other.ReturnSubmissionTask == null) || (this.ReturnSubmissionTask?.Equals(other.ReturnSubmissionTask) == true)) &&
                ((this.Validations == null && other.Validations == null) || (this.Validations?.Equals(other.Validations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.PaymentReturn = {(this.PaymentReturn == null ? "null" : this.PaymentReturn.ToString())}");
            toStringOutput.Add($"this.ReturnSubmissionTask = {(this.ReturnSubmissionTask == null ? "null" : this.ReturnSubmissionTask.ToString())}");
            toStringOutput.Add($"this.Validations = {(this.Validations == null ? "null" : this.Validations.ToString())}");
        }
    }
}