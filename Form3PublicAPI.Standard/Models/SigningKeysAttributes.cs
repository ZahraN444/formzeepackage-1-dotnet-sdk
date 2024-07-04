// <copyright file="SigningKeysAttributes.cs" company="APIMatic">
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
    /// SigningKeysAttributes.
    /// </summary>
    public class SigningKeysAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningKeysAttributes"/> class.
        /// </summary>
        public SigningKeysAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigningKeysAttributes"/> class.
        /// </summary>
        /// <param name="publicKey">public_key.</param>
        /// <param name="certificate">certificate.</param>
        /// <param name="expirationDatetime">expiration_datetime.</param>
        /// <param name="revocationDatetime">revocation_datetime.</param>
        /// <param name="status">status.</param>
        public SigningKeysAttributes(
            string publicKey,
            string certificate = null,
            DateTime? expirationDatetime = null,
            DateTime? revocationDatetime = null,
            Models.Status5Enum? status = null)
        {
            this.Certificate = certificate;
            this.ExpirationDatetime = expirationDatetime;
            this.PublicKey = publicKey;
            this.RevocationDatetime = revocationDatetime;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Certificate.
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or sets ExpirationDatetime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expiration_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDatetime { get; set; }

        /// <summary>
        /// Gets or sets PublicKey.
        /// </summary>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or sets RevocationDatetime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("revocation_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RevocationDatetime { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status5Enum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SigningKeysAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is SigningKeysAttributes other &&                ((this.Certificate == null && other.Certificate == null) || (this.Certificate?.Equals(other.Certificate) == true)) &&
                ((this.ExpirationDatetime == null && other.ExpirationDatetime == null) || (this.ExpirationDatetime?.Equals(other.ExpirationDatetime) == true)) &&
                ((this.PublicKey == null && other.PublicKey == null) || (this.PublicKey?.Equals(other.PublicKey) == true)) &&
                ((this.RevocationDatetime == null && other.RevocationDatetime == null) || (this.RevocationDatetime?.Equals(other.RevocationDatetime) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Certificate = {(this.Certificate == null ? "null" : this.Certificate)}");
            toStringOutput.Add($"this.ExpirationDatetime = {(this.ExpirationDatetime == null ? "null" : this.ExpirationDatetime.ToString())}");
            toStringOutput.Add($"this.PublicKey = {(this.PublicKey == null ? "null" : this.PublicKey)}");
            toStringOutput.Add($"this.RevocationDatetime = {(this.RevocationDatetime == null ? "null" : this.RevocationDatetime.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}