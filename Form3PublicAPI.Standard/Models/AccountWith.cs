// <copyright file="AccountWith.cs" company="APIMatic">
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
    /// AccountWith.
    /// </summary>
    public class AccountWith
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountWith"/> class.
        /// </summary>
        public AccountWith()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountWith"/> class.
        /// </summary>
        /// <param name="bankId">bank_id.</param>
        /// <param name="bankIdCode">bank_id_code.</param>
        /// <param name="bankName">bank_name.</param>
        public AccountWith(
            string bankId = null,
            string bankIdCode = null,
            string bankName = null)
        {
            this.BankId = bankId;
            this.BankIdCode = bankIdCode;
            this.BankName = bankName;
        }

        /// <summary>
        /// Identification of a member of a clearing system.
        /// </summary>
        [JsonProperty("bank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BankId { get; set; }

        /// <summary>
        /// Identification of a clearing system, in a coded form as published in an external list.
        /// </summary>
        [JsonProperty("bank_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIdCode { get; set; }

        /// <summary>
        /// Name by which an agent is known and which is usually used to identify that agent.
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountWith : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountWith other &&                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true)) &&
                ((this.BankIdCode == null && other.BankIdCode == null) || (this.BankIdCode?.Equals(other.BankIdCode) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
            toStringOutput.Add($"this.BankIdCode = {(this.BankIdCode == null ? "null" : this.BankIdCode)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
        }
    }
}