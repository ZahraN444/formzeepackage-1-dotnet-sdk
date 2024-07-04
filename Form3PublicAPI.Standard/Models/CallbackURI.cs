// <copyright file="CallbackURI.cs" company="APIMatic">
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
    /// CallbackURI.
    /// </summary>
    public class CallbackURI
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackURI"/> class.
        /// </summary>
        public CallbackURI()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackURI"/> class.
        /// </summary>
        /// <param name="callbackTransport">callback_transport.</param>
        /// <param name="callbackUri">callback_uri.</param>
        public CallbackURI(
            Models.CallbackTransportEnum callbackTransport,
            string callbackUri)
        {
            this.CallbackTransport = callbackTransport;
            this.CallbackUri = callbackUri;
        }

        /// <summary>
        /// Gets or sets CallbackTransport.
        /// </summary>
        [JsonProperty("callback_transport")]
        public Models.CallbackTransportEnum CallbackTransport { get; set; }

        /// <summary>
        /// URI that will be called with the notification
        /// </summary>
        [JsonProperty("callback_uri")]
        public string CallbackUri { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CallbackURI : ({string.Join(", ", toStringOutput)})";
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
            return obj is CallbackURI other &&                this.CallbackTransport.Equals(other.CallbackTransport) &&
                ((this.CallbackUri == null && other.CallbackUri == null) || (this.CallbackUri?.Equals(other.CallbackUri) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CallbackTransport = {this.CallbackTransport}");
            toStringOutput.Add($"this.CallbackUri = {(this.CallbackUri == null ? "null" : this.CallbackUri)}");
        }
    }
}