// <copyright file="ReportRequestLinks.cs" company="APIMatic">
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
    /// ReportRequestLinks.
    /// </summary>
    public class ReportRequestLinks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestLinks"/> class.
        /// </summary>
        public ReportRequestLinks()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestLinks"/> class.
        /// </summary>
        /// <param name="self">self.</param>
        public ReportRequestLinks(
            Models.ReportRequestLink self)
        {
            this.Self = self;
        }

        /// <summary>
        /// Gets or sets Self.
        /// </summary>
        [JsonProperty("self")]
        public Models.ReportRequestLink Self { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRequestLinks : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRequestLinks other &&                ((this.Self == null && other.Self == null) || (this.Self?.Equals(other.Self) == true));
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