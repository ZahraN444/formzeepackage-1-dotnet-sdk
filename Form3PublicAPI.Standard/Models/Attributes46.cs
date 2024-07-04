// <copyright file="Attributes46.cs" company="APIMatic">
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
    /// Attributes46.
    /// </summary>
    public class Attributes46
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes46"/> class.
        /// </summary>
        public Attributes46()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes46"/> class.
        /// </summary>
        /// <param name="debtorParty">debtor_party.</param>
        /// <param name="returnCode">return_code.</param>
        public Attributes46(
            Models.DebtorParty3 debtorParty = null,
            string returnCode = null)
        {
            this.DebtorParty = debtorParty;
            this.ReturnCode = returnCode;
        }

        /// <summary>
        /// Gets or sets DebtorParty.
        /// </summary>
        [JsonProperty("debtor_party", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DebtorParty3 DebtorParty { get; set; }

        /// <summary>
        /// Gets or sets ReturnCode.
        /// </summary>
        [JsonProperty("return_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes46 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes46 other &&                ((this.DebtorParty == null && other.DebtorParty == null) || (this.DebtorParty?.Equals(other.DebtorParty) == true)) &&
                ((this.ReturnCode == null && other.ReturnCode == null) || (this.ReturnCode?.Equals(other.ReturnCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DebtorParty = {(this.DebtorParty == null ? "null" : this.DebtorParty.ToString())}");
            toStringOutput.Add($"this.ReturnCode = {(this.ReturnCode == null ? "null" : this.ReturnCode)}");
        }
    }
}