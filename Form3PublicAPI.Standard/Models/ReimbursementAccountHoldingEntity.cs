// <copyright file="ReimbursementAccountHoldingEntity.cs" company="APIMatic">
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
    /// ReimbursementAccountHoldingEntity.
    /// </summary>
    public class ReimbursementAccountHoldingEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReimbursementAccountHoldingEntity"/> class.
        /// </summary>
        public ReimbursementAccountHoldingEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReimbursementAccountHoldingEntity"/> class.
        /// </summary>
        /// <param name="bankAddress">bank_address.</param>
        /// <param name="bankId">bank_id.</param>
        /// <param name="bankIdCode">bank_id_code.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="bankPartyId">bank_party_id.</param>
        public ReimbursementAccountHoldingEntity(
            List<string> bankAddress = null,
            string bankId = null,
            string bankIdCode = null,
            string bankName = null,
            string bankPartyId = null)
        {
            this.BankAddress = bankAddress;
            this.BankId = bankId;
            this.BankIdCode = bankIdCode;
            this.BankName = bankName;
            this.BankPartyId = bankPartyId;
        }

        /// <summary>
        /// Third party reimbursement institution address
        /// </summary>
        [JsonProperty("bank_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BankAddress { get; set; }

        /// <summary>
        /// Identification of third party reimbursement institution
        /// </summary>
        [JsonProperty("bank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BankId { get; set; }

        /// <summary>
        /// The type of identification provided at `bank_id` attribute. Must be ISO code as listed in the [External Code Sets spreadsheet](https://www.iso20022.org/external_code_list.page)
        /// </summary>
        [JsonProperty("bank_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankIdCode { get; set; }

        /// <summary>
        /// Third party reimbursement institution name
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// Third party reimbursement institution identifier
        /// </summary>
        [JsonProperty("bank_party_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BankPartyId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReimbursementAccountHoldingEntity : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReimbursementAccountHoldingEntity other &&                ((this.BankAddress == null && other.BankAddress == null) || (this.BankAddress?.Equals(other.BankAddress) == true)) &&
                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true)) &&
                ((this.BankIdCode == null && other.BankIdCode == null) || (this.BankIdCode?.Equals(other.BankIdCode) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.BankPartyId == null && other.BankPartyId == null) || (this.BankPartyId?.Equals(other.BankPartyId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankAddress = {(this.BankAddress == null ? "null" : $"[{string.Join(", ", this.BankAddress)} ]")}");
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
            toStringOutput.Add($"this.BankIdCode = {(this.BankIdCode == null ? "null" : this.BankIdCode)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.BankPartyId = {(this.BankPartyId == null ? "null" : this.BankPartyId)}");
        }
    }
}