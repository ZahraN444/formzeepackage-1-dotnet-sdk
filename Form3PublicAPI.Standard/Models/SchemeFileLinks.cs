// <copyright file="SchemeFileLinks.cs" company="APIMatic">
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
    /// SchemeFileLinks.
    /// </summary>
    public class SchemeFileLinks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileLinks"/> class.
        /// </summary>
        public SchemeFileLinks()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileLinks"/> class.
        /// </summary>
        /// <param name="self">self.</param>
        public SchemeFileLinks(
            Models.SchemeFileLink self)
        {
            this.Self = self;
        }

        /// <summary>
        /// Gets or sets Self.
        /// </summary>
        [JsonProperty("self")]
        public Models.SchemeFileLink Self { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeFileLinks : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeFileLinks other &&                ((this.Self == null && other.Self == null) || (this.Self?.Equals(other.Self) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Self = {(this.Self == null ? "null" : this.Self.ToString())}");
        }
    }
}