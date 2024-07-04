// <copyright file="Attributes1.cs" company="APIMatic">
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
    /// Attributes1.
    /// </summary>
    public class Attributes1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes1"/> class.
        /// </summary>
        public Attributes1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes1"/> class.
        /// </summary>
        /// <param name="bankCode">bank_code.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="bankOfficeTitle">bank_office_title.</param>
        /// <param name="supportedSchemes">supported_schemes.</param>
        public Attributes1(
            string bankCode = null,
            string bankName = null,
            string bankOfficeTitle = null,
            Models.SupportedSchemes supportedSchemes = null)
        {
            this.BankCode = bankCode;
            this.BankName = bankName;
            this.BankOfficeTitle = bankOfficeTitle;
            this.SupportedSchemes = supportedSchemes;
        }

        /// <summary>
        /// Gets or sets BankCode.
        /// </summary>
        [JsonProperty("bank_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or sets BankName.
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets BankOfficeTitle.
        /// </summary>
        [JsonProperty("bank_office_title", NullValueHandling = NullValueHandling.Ignore)]
        public string BankOfficeTitle { get; set; }

        /// <summary>
        /// Gets or sets SupportedSchemes.
        /// </summary>
        [JsonProperty("supported_schemes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SupportedSchemes SupportedSchemes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes1 other &&                ((this.BankCode == null && other.BankCode == null) || (this.BankCode?.Equals(other.BankCode) == true)) &&
                ((this.BankName == null && other.BankName == null) || (this.BankName?.Equals(other.BankName) == true)) &&
                ((this.BankOfficeTitle == null && other.BankOfficeTitle == null) || (this.BankOfficeTitle?.Equals(other.BankOfficeTitle) == true)) &&
                ((this.SupportedSchemes == null && other.SupportedSchemes == null) || (this.SupportedSchemes?.Equals(other.SupportedSchemes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BankCode = {(this.BankCode == null ? "null" : this.BankCode)}");
            toStringOutput.Add($"this.BankName = {(this.BankName == null ? "null" : this.BankName)}");
            toStringOutput.Add($"this.BankOfficeTitle = {(this.BankOfficeTitle == null ? "null" : this.BankOfficeTitle)}");
            toStringOutput.Add($"this.SupportedSchemes = {(this.SupportedSchemes == null ? "null" : this.SupportedSchemes.ToString())}");
        }
    }
}