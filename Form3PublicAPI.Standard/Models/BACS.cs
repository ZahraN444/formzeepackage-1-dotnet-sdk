// <copyright file="BACS.cs" company="APIMatic">
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
    /// BACS.
    /// </summary>
    public class BACS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BACS"/> class.
        /// </summary>
        public BACS()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BACS"/> class.
        /// </summary>
        /// <param name="acceptsPayments">accepts_payments.</param>
        /// <param name="accountSwitching">account_switching.</param>
        /// <param name="allowedTransactions">allowed_transactions.</param>
        /// <param name="serviceStatus">service_status.</param>
        public BACS(
            bool? acceptsPayments = false,
            Models.AccountSwitchingEnum? accountSwitching = null,
            List<Models.TransactionGroupCodeEnum> allowedTransactions = null,
            string serviceStatus = null)
        {
            this.AcceptsPayments = acceptsPayments;
            this.AccountSwitching = accountSwitching;
            this.AllowedTransactions = allowedTransactions;
            this.ServiceStatus = serviceStatus;
        }

        /// <summary>
        /// Gets or sets AcceptsPayments.
        /// </summary>
        [JsonProperty("accepts_payments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AcceptsPayments { get; set; }

        /// <summary>
        /// Gets or sets AccountSwitching.
        /// </summary>
        [JsonProperty("account_switching", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountSwitchingEnum? AccountSwitching { get; set; }

        /// <summary>
        /// Gets or sets AllowedTransactions.
        /// </summary>
        [JsonProperty("allowed_transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TransactionGroupCodeEnum> AllowedTransactions { get; set; }

        /// <summary>
        /// Gets or sets ServiceStatus.
        /// </summary>
        [JsonProperty("service_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BACS : ({string.Join(", ", toStringOutput)})";
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
            return obj is BACS other &&                ((this.AcceptsPayments == null && other.AcceptsPayments == null) || (this.AcceptsPayments?.Equals(other.AcceptsPayments) == true)) &&
                ((this.AccountSwitching == null && other.AccountSwitching == null) || (this.AccountSwitching?.Equals(other.AccountSwitching) == true)) &&
                ((this.AllowedTransactions == null && other.AllowedTransactions == null) || (this.AllowedTransactions?.Equals(other.AllowedTransactions) == true)) &&
                ((this.ServiceStatus == null && other.ServiceStatus == null) || (this.ServiceStatus?.Equals(other.ServiceStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcceptsPayments = {(this.AcceptsPayments == null ? "null" : this.AcceptsPayments.ToString())}");
            toStringOutput.Add($"this.AccountSwitching = {(this.AccountSwitching == null ? "null" : this.AccountSwitching.ToString())}");
            toStringOutput.Add($"this.AllowedTransactions = {(this.AllowedTransactions == null ? "null" : $"[{string.Join(", ", this.AllowedTransactions)} ]")}");
            toStringOutput.Add($"this.ServiceStatus = {(this.ServiceStatus == null ? "null" : this.ServiceStatus)}");
        }
    }
}