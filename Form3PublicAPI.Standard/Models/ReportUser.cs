// <copyright file="ReportUser.cs" company="APIMatic">
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
    /// ReportUser.
    /// </summary>
    public class ReportUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportUser"/> class.
        /// </summary>
        public ReportUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportUser"/> class.
        /// </summary>
        /// <param name="userId">user_id.</param>
        /// <param name="userIdCode">user_id_code.</param>
        public ReportUser(
            string userId = null,
            string userIdCode = null)
        {
            this.UserId = userId;
            this.UserIdCode = userIdCode;
        }

        /// <summary>
        /// Identifies a user or organization
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// Type of identifier for the user or organization
        /// </summary>
        [JsonProperty("user_id_code", NullValueHandling = NullValueHandling.Ignore)]
        public string UserIdCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReportUser : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReportUser other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.UserIdCode == null && other.UserIdCode == null) || (this.UserIdCode?.Equals(other.UserIdCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.UserIdCode = {(this.UserIdCode == null ? "null" : this.UserIdCode)}");
        }
    }
}