// <copyright file="Attributes55.cs" company="APIMatic">
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
    /// Attributes55.
    /// </summary>
    public class Attributes55
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes55"/> class.
        /// </summary>
        public Attributes55()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes55"/> class.
        /// </summary>
        /// <param name="limit">limit.</param>
        /// <param name="position">position.</param>
        /// <param name="scheme">scheme.</param>
        public Attributes55(
            string limit = null,
            string position = null,
            string scheme = null)
        {
            this.Limit = limit;
            this.Position = position;
            this.Scheme = scheme;
        }

        /// <summary>
        /// Current limit
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// Current position
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// Scheme associated with the limit
        /// </summary>
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes55 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes55 other &&                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Position == null && other.Position == null) || (this.Position?.Equals(other.Position) == true)) &&
                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Position = {(this.Position == null ? "null" : this.Position)}");
            toStringOutput.Add($"this.Scheme = {(this.Scheme == null ? "null" : this.Scheme)}");
        }
    }
}