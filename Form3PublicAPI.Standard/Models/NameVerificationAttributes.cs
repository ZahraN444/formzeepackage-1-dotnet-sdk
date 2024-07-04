// <copyright file="NameVerificationAttributes.cs" company="APIMatic">
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
    /// NameVerificationAttributes.
    /// </summary>
    public class NameVerificationAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAttributes"/> class.
        /// </summary>
        public NameVerificationAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAttributes"/> class.
        /// </summary>
        /// <param name="accountClassification">account_classification.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountNumberCode">account_number_code.</param>
        /// <param name="bankId">bank_id.</param>
        /// <param name="bankIdCode">bank_id_code.</param>
        /// <param name="name">name.</param>
        /// <param name="secondaryIdentification">secondary_identification.</param>
        public NameVerificationAttributes(
            Models.AccountClassificationEnum accountClassification,
            string accountNumber,
            Models.AccountNumberCodeEnum accountNumberCode,
            string bankId,
            string bankIdCode,
            List<string> name,
            string secondaryIdentification = null)
        {
            this.AccountClassification = accountClassification;
            this.AccountNumber = accountNumber;
            this.AccountNumberCode = accountNumberCode;
            this.BankId = bankId;
            this.BankIdCode = bankIdCode;
            this.Name = name;
            this.SecondaryIdentification = secondaryIdentification;
        }

        /// <summary>
        /// Gets or sets AccountClassification.
        /// </summary>
        [JsonProperty("account_classification")]
        public Models.AccountClassificationEnum AccountClassification { get; set; }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The type of identification given at `account_number` attribute
        /// </summary>
        [JsonProperty("account_number_code")]
        public Models.AccountNumberCodeEnum AccountNumberCode { get; set; }

        /// <summary>
        /// Gets or sets BankId.
        /// </summary>
        [JsonProperty("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// Gets or sets BankIdCode.
        /// </summary>
        [JsonProperty("bank_id_code")]
        public string BankIdCode { get; set; }

        /// <summary>
        /// Account holder names (for example title, first name, last name). Used for Confirmation of Payee matching.
        /// </summary>
        [JsonProperty("name")]
        public List<string> Name { get; set; }

        /// <summary>
        /// Gets or sets SecondaryIdentification.
        /// </summary>
        [JsonProperty("secondary_identification", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryIdentification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NameVerificationAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is NameVerificationAttributes other &&                this.AccountClassification.Equals(other.AccountClassification) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                this.AccountNumberCode.Equals(other.AccountNumberCode) &&
                ((this.BankId == null && other.BankId == null) || (this.BankId?.Equals(other.BankId) == true)) &&
                ((this.BankIdCode == null && other.BankIdCode == null) || (this.BankIdCode?.Equals(other.BankIdCode) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SecondaryIdentification == null && other.SecondaryIdentification == null) || (this.SecondaryIdentification?.Equals(other.SecondaryIdentification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountClassification = {this.AccountClassification}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountNumberCode = {this.AccountNumberCode}");
            toStringOutput.Add($"this.BankId = {(this.BankId == null ? "null" : this.BankId)}");
            toStringOutput.Add($"this.BankIdCode = {(this.BankIdCode == null ? "null" : this.BankIdCode)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : $"[{string.Join(", ", this.Name)} ]")}");
            toStringOutput.Add($"this.SecondaryIdentification = {(this.SecondaryIdentification == null ? "null" : this.SecondaryIdentification)}");
        }
    }
}