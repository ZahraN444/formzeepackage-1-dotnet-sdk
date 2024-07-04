// <copyright file="Relationships.cs" company="APIMatic">
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
    /// Relationships.
    /// </summary>
    public class Relationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships"/> class.
        /// </summary>
        public Relationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships"/> class.
        /// </summary>
        /// <param name="sortCode">sort_code.</param>
        public Relationships(
            Models.SortCode sortCode = null)
        {
            this.SortCode = sortCode;
        }

        /// <summary>
        /// Gets or sets SortCode.
        /// </summary>
        [JsonProperty("sort_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SortCode SortCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships other &&                ((this.SortCode == null && other.SortCode == null) || (this.SortCode?.Equals(other.SortCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SortCode = {(this.SortCode == null ? "null" : this.SortCode.ToString())}");
        }
    }
}