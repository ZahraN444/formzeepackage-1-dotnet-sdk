// <copyright file="BeneficiaryDebtorAccountProxy.cs" company="APIMatic">
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
    /// BeneficiaryDebtorAccountProxy.
    /// </summary>
    public class BeneficiaryDebtorAccountProxy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryDebtorAccountProxy"/> class.
        /// </summary>
        public BeneficiaryDebtorAccountProxy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryDebtorAccountProxy"/> class.
        /// </summary>
        /// <param name="proxy">proxy.</param>
        /// <param name="proxyId">proxy_id.</param>
        /// <param name="proxyIdCode">proxy_id_code.</param>
        public BeneficiaryDebtorAccountProxy(
            string proxy = null,
            string proxyId = null,
            string proxyIdCode = null)
        {
            this.Proxy = proxy;
            this.ProxyId = proxyId;
            this.ProxyIdCode = proxyIdCode;
        }

        /// <summary>
        /// Name of the identification scheme, in a free text form. When used proxy_id_code must not be present
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        public string Proxy { get; set; }

        /// <summary>
        /// Identification used to indicate the account identification under another specified name
        /// </summary>
        [JsonProperty("proxy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyId { get; set; }

        /// <summary>
        /// Name of the identification scheme, in a coded form as published in an external list. When used proxy field must not be present
        /// </summary>
        [JsonProperty("proxy_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyIdCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BeneficiaryDebtorAccountProxy : ({string.Join(", ", toStringOutput)})";
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
            return obj is BeneficiaryDebtorAccountProxy other &&                ((this.Proxy == null && other.Proxy == null) || (this.Proxy?.Equals(other.Proxy) == true)) &&
                ((this.ProxyId == null && other.ProxyId == null) || (this.ProxyId?.Equals(other.ProxyId) == true)) &&
                ((this.ProxyIdCode == null && other.ProxyIdCode == null) || (this.ProxyIdCode?.Equals(other.ProxyIdCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Proxy = {(this.Proxy == null ? "null" : this.Proxy)}");
            toStringOutput.Add($"this.ProxyId = {(this.ProxyId == null ? "null" : this.ProxyId)}");
            toStringOutput.Add($"this.ProxyIdCode = {(this.ProxyIdCode == null ? "null" : this.ProxyIdCode)}");
        }
    }
}