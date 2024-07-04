// <copyright file="PrivateIdentification1.cs" company="APIMatic">
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
    /// PrivateIdentification1.
    /// </summary>
    public class PrivateIdentification1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateIdentification1"/> class.
        /// </summary>
        public PrivateIdentification1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateIdentification1"/> class.
        /// </summary>
        /// <param name="privateIdentificationCode">private_identification.code.</param>
        /// <param name="privateIdentificationIdentification">private_identification.identification.</param>
        /// <param name="privateIdentificationIssuer">private_identification.issuer.</param>
        public PrivateIdentification1(
            string privateIdentificationCode = null,
            string privateIdentificationIdentification = null,
            string privateIdentificationIssuer = null)
        {
            this.PrivateIdentificationCode = privateIdentificationCode;
            this.PrivateIdentificationIdentification = privateIdentificationIdentification;
            this.PrivateIdentificationIssuer = privateIdentificationIssuer;
        }

        /// <summary>
        /// Gets or sets PrivateIdentificationCode.
        /// </summary>
        [JsonProperty("private_identification.code", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets PrivateIdentificationIdentification.
        /// </summary>
        [JsonProperty("private_identification.identification", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIdentificationIdentification { get; set; }

        /// <summary>
        /// Gets or sets PrivateIdentificationIssuer.
        /// </summary>
        [JsonProperty("private_identification.issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIdentificationIssuer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrivateIdentification1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrivateIdentification1 other &&                ((this.PrivateIdentificationCode == null && other.PrivateIdentificationCode == null) || (this.PrivateIdentificationCode?.Equals(other.PrivateIdentificationCode) == true)) &&
                ((this.PrivateIdentificationIdentification == null && other.PrivateIdentificationIdentification == null) || (this.PrivateIdentificationIdentification?.Equals(other.PrivateIdentificationIdentification) == true)) &&
                ((this.PrivateIdentificationIssuer == null && other.PrivateIdentificationIssuer == null) || (this.PrivateIdentificationIssuer?.Equals(other.PrivateIdentificationIssuer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrivateIdentificationCode = {(this.PrivateIdentificationCode == null ? "null" : this.PrivateIdentificationCode)}");
            toStringOutput.Add($"this.PrivateIdentificationIdentification = {(this.PrivateIdentificationIdentification == null ? "null" : this.PrivateIdentificationIdentification)}");
            toStringOutput.Add($"this.PrivateIdentificationIssuer = {(this.PrivateIdentificationIssuer == null ? "null" : this.PrivateIdentificationIssuer)}");
        }
    }
}