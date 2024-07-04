// <copyright file="TransactionFileLink.cs" company="APIMatic">
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
    /// TransactionFileLink.
    /// </summary>
    public class TransactionFileLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileLink"/> class.
        /// </summary>
        public TransactionFileLink()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileLink"/> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="meta">meta.</param>
        public TransactionFileLink(
            string href,
            Models.Meta meta = null)
        {
            this.Href = href;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets Href.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Meta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionFileLink : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionFileLink other &&                ((this.Href == null && other.Href == null) || (this.Href?.Equals(other.Href) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Href = {(this.Href == null ? "null" : this.Href)}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}