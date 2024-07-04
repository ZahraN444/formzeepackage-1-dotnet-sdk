// <copyright file="NewReportRequestReportUser.cs" company="APIMatic">
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
    /// NewReportRequestReportUser.
    /// </summary>
    public class NewReportRequestReportUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewReportRequestReportUser"/> class.
        /// </summary>
        public NewReportRequestReportUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewReportRequestReportUser"/> class.
        /// </summary>
        /// <param name="userId">user_id.</param>
        /// <param name="userIdCode">user_id_code.</param>
        public NewReportRequestReportUser(
            string userId,
            Models.ReportRequestUserIdCodeEnum userIdCode)
        {
            this.UserId = userId;
            this.UserIdCode = userIdCode;
        }

        /// <summary>
        /// Identifies a user or organization
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets UserIdCode.
        /// </summary>
        [JsonProperty("user_id_code")]
        public Models.ReportRequestUserIdCodeEnum UserIdCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NewReportRequestReportUser : ({string.Join(", ", toStringOutput)})";
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
            return obj is NewReportRequestReportUser other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                this.UserIdCode.Equals(other.UserIdCode);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.UserIdCode = {this.UserIdCode}");
        }
    }
}