// <copyright file="Identification.cs" company="APIMatic">
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
    /// Identification.
    /// </summary>
    public class Identification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identification"/> class.
        /// </summary>
        public Identification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identification"/> class.
        /// </summary>
        /// <param name="bankId">bank_id.</param>
        /// <param name="bankIdCode">bank_id_code.</param>
        /// <param name="bankIds">bank_ids.</param>
        public Identification(
            string bankId = null,
            string bankIdCode = null,
            List<Models.AccountWithBankId> bankIds = null)
        {
            this.BankId = bankId;
            this.BankIdCode = bankIdCode;
            this.BankIds = bankIds;
        }

        /// <summary>
        /// Identification code of the financial institution.
        /// </summary>
        [JsonProperty("bank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BankId { get; set; }

        /// <summary>
        /// Type of identification provided in bank_id field. Required when bank_id is provided, not used otherwise.
        /// </summary>
        [JsonProperty("bank_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIdCode { get; set; }

        /// <summary>
        /// Array for additional ID(s) of instructed (or other type of) agent
        /// </summary>
        [JsonProperty("bank_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountWithBankId> BankIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Identification : ({string.Join(", ", toStringOutput)})";
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
            return obj is Identification other &&                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true)) &&
                ((this.BankIdCode == null && other.BankIdCode == null) || (this.BankIdCode?.Equals(other.BankIdCode) == true)) &&
                ((this.BankIds == null && other.BankIds == null) || (this.BankIds?.Equals(other.BankIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
            toStringOutput.Add($"this.BankIdCode = {(this.BankIdCode == null ? "null" : this.BankIdCode)}");
            toStringOutput.Add($"this.BankIds = {(this.BankIds == null ? "null" : $"[{string.Join(", ", this.BankIds)} ]")}");
        }
    }
}