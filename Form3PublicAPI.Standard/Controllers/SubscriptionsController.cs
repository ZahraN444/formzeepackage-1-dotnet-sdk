// <copyright file="SubscriptionsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Exceptions;
    using Form3PublicAPI.Standard.Http.Client;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// SubscriptionsController.
    /// </summary>
    public class SubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsController"/> class.
        /// </summary>
        internal SubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List all subscriptions.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterEventType">Optional parameter: Filter by event type.</param>
        /// <param name="filterRecordType">Optional parameter: Filter by record type.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterDeactivated">Optional parameter: Filter by deactivated.</param>
        /// <param name="filterCallbackTransport">Optional parameter: Filter by callback_transport.</param>
        /// <param name="filterCallbackUriSearchTerm">Optional parameter: Filter on callback_uri containing a search term.</param>
        /// <param name="filterNotificationFilter">Optional parameter: Filter by existence of notification filters.</param>
        /// <returns>Returns the Models.SubscriptionDetailsListResponse response from the API call.</returns>
        public Models.SubscriptionDetailsListResponse ListSubscriptions(
                string pageNumber = null,
                int? pageSize = null,
                List<string> filterEventType = null,
                List<string> filterRecordType = null,
                List<Guid> filterOrganisationId = null,
                bool? filterDeactivated = null,
                string filterCallbackTransport = null,
                string filterCallbackUriSearchTerm = null,
                bool? filterNotificationFilter = null)
            => CoreHelper.RunTask(ListSubscriptionsAsync(pageNumber, pageSize, filterEventType, filterRecordType, filterOrganisationId, filterDeactivated, filterCallbackTransport, filterCallbackUriSearchTerm, filterNotificationFilter));

        /// <summary>
        /// List all subscriptions.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterEventType">Optional parameter: Filter by event type.</param>
        /// <param name="filterRecordType">Optional parameter: Filter by record type.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterDeactivated">Optional parameter: Filter by deactivated.</param>
        /// <param name="filterCallbackTransport">Optional parameter: Filter by callback_transport.</param>
        /// <param name="filterCallbackUriSearchTerm">Optional parameter: Filter on callback_uri containing a search term.</param>
        /// <param name="filterNotificationFilter">Optional parameter: Filter by existence of notification filters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionDetailsListResponse response from the API call.</returns>
        public async Task<Models.SubscriptionDetailsListResponse> ListSubscriptionsAsync(
                string pageNumber = null,
                int? pageSize = null,
                List<string> filterEventType = null,
                List<string> filterRecordType = null,
                List<Guid> filterOrganisationId = null,
                bool? filterDeactivated = null,
                string filterCallbackTransport = null,
                string filterCallbackUriSearchTerm = null,
                bool? filterNotificationFilter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/subscriptions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[event_type]", filterEventType))
                      .Query(_query => _query.Setup("filter[record_type]", filterRecordType))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[deactivated]", filterDeactivated))
                      .Query(_query => _query.Setup("filter[callback_transport]", filterCallbackTransport))
                      .Query(_query => _query.Setup("filter[callback_uri_search_term]", filterCallbackUriSearchTerm))
                      .Query(_query => _query.Setup("filter[notification_filter]", filterNotificationFilter))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create subscription.
        /// </summary>
        /// <param name="subscriptionCreationRequest">Required parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionCreationResponse response from the API call.</returns>
        public Models.SubscriptionCreationResponse CreateSubscription(
                Models.SubscriptionCreation subscriptionCreationRequest)
            => CoreHelper.RunTask(CreateSubscriptionAsync(subscriptionCreationRequest));

        /// <summary>
        /// Create subscription.
        /// </summary>
        /// <param name="subscriptionCreationRequest">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionCreationResponse response from the API call.</returns>
        public async Task<Models.SubscriptionCreationResponse> CreateSubscriptionAsync(
                Models.SubscriptionCreation subscriptionCreationRequest,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/notification/subscriptions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(subscriptionCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="id">Required parameter: Subscription Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteSubscription(
                Guid id,
                int version)
            => CoreHelper.RunVoidTask(DeleteSubscriptionAsync(id, version));

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <param name="id">Required parameter: Subscription Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSubscriptionAsync(
                Guid id,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/notification/subscriptions/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Query(_query => _query.Setup("version", version))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch subscription.
        /// </summary>
        /// <param name="id">Required parameter: Subscription Id.</param>
        /// <returns>Returns the Models.SubscriptionDetailsResponse response from the API call.</returns>
        public Models.SubscriptionDetailsResponse FetchSubscription(
                Guid id)
            => CoreHelper.RunTask(FetchSubscriptionAsync(id));

        /// <summary>
        /// Fetch subscription.
        /// </summary>
        /// <param name="id">Required parameter: Subscription Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionDetailsResponse response from the API call.</returns>
        public async Task<Models.SubscriptionDetailsResponse> FetchSubscriptionAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/subscriptions/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update subscription details.
        /// </summary>
        /// <param name="id">Required parameter: Subscription Id.</param>
        /// <param name="subscriptionUpdateRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionDetailsResponse response from the API call.</returns>
        public Models.SubscriptionDetailsResponse PatchSubscription(
                Guid id,
                Models.SubscriptionAmendment subscriptionUpdateRequest = null)
            => CoreHelper.RunTask(PatchSubscriptionAsync(id, subscriptionUpdateRequest));

        /// <summary>
        /// Update subscription details.
        /// </summary>
        /// <param name="id">Required parameter: Subscription Id.</param>
        /// <param name="subscriptionUpdateRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionDetailsResponse response from the API call.</returns>
        public async Task<Models.SubscriptionDetailsResponse> PatchSubscriptionAsync(
                Guid id,
                Models.SubscriptionAmendment subscriptionUpdateRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/notification/subscriptions/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(subscriptionUpdateRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}