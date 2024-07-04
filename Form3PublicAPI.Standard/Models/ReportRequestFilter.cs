// <copyright file="ReportRequestFilter.cs" company="APIMatic">
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
    /// ReportRequestFilter.
    /// </summary>
    public class ReportRequestFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestFilter"/> class.
        /// </summary>
        public ReportRequestFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequestFilter"/> class.
        /// </summary>
        /// <param name="reportUsers">report_users.</param>
        /// <param name="dateFrom">date_from.</param>
        /// <param name="dateTo">date_to.</param>
        public ReportRequestFilter(
            List<Models.ReportUser> reportUsers,
            DateTime? dateFrom = null,
            DateTime? dateTo = null)
        {
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.ReportUsers = reportUsers;
        }

        /// <summary>
        /// Gets or sets DateFrom.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date_from", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Gets or sets DateTo.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date_to", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Gets or sets ReportUsers.
        /// </summary>
        [JsonProperty("report_users")]
        public List<Models.ReportUser> ReportUsers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportRequestFilter : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportRequestFilter other &&                ((this.DateFrom == null && other.DateFrom == null) || (this.DateFrom?.Equals(other.DateFrom) == true)) &&
                ((this.DateTo == null && other.DateTo == null) || (this.DateTo?.Equals(other.DateTo) == true)) &&
                ((this.ReportUsers == null && other.ReportUsers == null) || (this.ReportUsers?.Equals(other.ReportUsers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateFrom = {(this.DateFrom == null ? "null" : this.DateFrom.ToString())}");
            toStringOutput.Add($"this.DateTo = {(this.DateTo == null ? "null" : this.DateTo.ToString())}");
            toStringOutput.Add($"this.ReportUsers = {(this.ReportUsers == null ? "null" : $"[{string.Join(", ", this.ReportUsers)} ]")}");
        }
    }
}