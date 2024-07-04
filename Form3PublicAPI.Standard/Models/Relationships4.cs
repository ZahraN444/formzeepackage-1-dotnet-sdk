// <copyright file="Relationships4.cs" company="APIMatic">
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
    /// Relationships4.
    /// </summary>
    public class Relationships4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships4"/> class.
        /// </summary>
        public Relationships4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships4"/> class.
        /// </summary>
        /// <param name="payment">payment.</param>
        /// <param name="reversal">reversal.</param>
        /// <param name="reversalAdmissionTask">reversal_admission_task.</param>
        public Relationships4(
            Models.RelationshipPayments payment = null,
            Models.RelationshipReversals reversal = null,
            Models.RelationshipReversalAdmissionTasks reversalAdmissionTask = null)
        {
            this.Payment = payment;
            this.Reversal = reversal;
            this.ReversalAdmissionTask = reversalAdmissionTask;
        }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipPayments Payment { get; set; }

        /// <summary>
        /// Gets or sets Reversal.
        /// </summary>
        [JsonProperty("reversal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReversals Reversal { get; set; }

        /// <summary>
        /// Gets or sets ReversalAdmissionTask.
        /// </summary>
        [JsonProperty("reversal_admission_task", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipReversalAdmissionTasks ReversalAdmissionTask { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships4 other &&                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Reversal == null && other.Reversal == null) || (this.Reversal?.Equals(other.Reversal) == true)) &&
                ((this.ReversalAdmissionTask == null && other.ReversalAdmissionTask == null) || (this.ReversalAdmissionTask?.Equals(other.ReversalAdmissionTask) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Reversal = {(this.Reversal == null ? "null" : this.Reversal.ToString())}");
            toStringOutput.Add($"this.ReversalAdmissionTask = {(this.ReversalAdmissionTask == null ? "null" : this.ReversalAdmissionTask.ToString())}");
        }
    }
}