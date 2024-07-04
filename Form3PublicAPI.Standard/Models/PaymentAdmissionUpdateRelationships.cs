// <copyright file="PaymentAdmissionUpdateRelationships.cs" company="APIMatic">
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
    /// PaymentAdmissionUpdateRelationships.
    /// </summary>
    public class PaymentAdmissionUpdateRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdmissionUpdateRelationships"/> class.
        /// </summary>
        public PaymentAdmissionUpdateRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdmissionUpdateRelationships"/> class.
        /// </summary>
        /// <param name="paymentAdmissionTasks">payment_admission_tasks.</param>
        public PaymentAdmissionUpdateRelationships(
            List<Models.PaymentAdmissionTask> paymentAdmissionTasks = null)
        {
            this.PaymentAdmissionTasks = paymentAdmissionTasks;
        }

        /// <summary>
        /// Gets or sets PaymentAdmissionTasks.
        /// </summary>
        [JsonProperty("payment_admission_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PaymentAdmissionTask> PaymentAdmissionTasks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentAdmissionUpdateRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentAdmissionUpdateRelationships other &&                ((this.PaymentAdmissionTasks == null && other.PaymentAdmissionTasks == null) || (this.PaymentAdmissionTasks?.Equals(other.PaymentAdmissionTasks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentAdmissionTasks = {(this.PaymentAdmissionTasks == null ? "null" : $"[{string.Join(", ", this.PaymentAdmissionTasks)} ]")}");
        }
    }
}