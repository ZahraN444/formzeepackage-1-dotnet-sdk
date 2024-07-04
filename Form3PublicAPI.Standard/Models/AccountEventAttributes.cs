// <copyright file="AccountEventAttributes.cs" company="APIMatic">
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
    /// AccountEventAttributes.
    /// </summary>
    public class AccountEventAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEventAttributes"/> class.
        /// </summary>
        public AccountEventAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEventAttributes"/> class.
        /// </summary>
        /// <param name="accountId">account_id.</param>
        /// <param name="dateTime">date_time.</param>
        /// <param name="routingStatus">routing_status.</param>
        /// <param name="status">status.</param>
        /// <param name="description">description.</param>
        /// <param name="reason">reason.</param>
        public AccountEventAttributes(
            Guid accountId,
            DateTime dateTime,
            Models.RoutingStatusEnum routingStatus,
            Models.Status2Enum status,
            Models.DescriptionEnum? description = null,
            string reason = null)
        {
            this.AccountId = accountId;
            this.DateTime = dateTime;
            this.Description = description;
            this.Reason = reason;
            this.RoutingStatus = routingStatus;
            this.Status = status;
        }

        /// <summary>
        /// ID of the account this event relates to
        /// </summary>
        [JsonProperty("account_id")]
        public Guid AccountId { get; set; }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_time")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Contains the event description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DescriptionEnum? Description { get; set; }

        /// <summary>
        /// Failure reason. Should only be present when description is failed
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Contains the routing status
        /// </summary>
        [JsonProperty("routing_status")]
        public Models.RoutingStatusEnum RoutingStatus { get; set; }

        /// <summary>
        /// Contains the event status
        /// </summary>
        [JsonProperty("status")]
        public Models.Status2Enum Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountEventAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountEventAttributes other &&                this.AccountId.Equals(other.AccountId) &&
                this.DateTime.Equals(other.DateTime) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                this.RoutingStatus.Equals(other.RoutingStatus) &&
                this.Status.Equals(other.Status);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {this.AccountId}");
            toStringOutput.Add($"this.DateTime = {this.DateTime}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.RoutingStatus = {this.RoutingStatus}");
            toStringOutput.Add($"this.Status = {this.Status}");
        }
    }
}