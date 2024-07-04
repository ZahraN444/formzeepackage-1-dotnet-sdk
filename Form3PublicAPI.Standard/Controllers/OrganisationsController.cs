// <copyright file="OrganisationsController.cs" company="APIMatic">
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
    /// OrganisationsController.
    /// </summary>
    public class OrganisationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationsController"/> class.
        /// </summary>
        internal OrganisationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List all organisations.
        /// </summary>
        /// <param name="filterChildOrganisationId">Optional parameter: Child org id.</param>
        /// <param name="filterOrganisationIds">Optional parameter: Organisation ids.</param>
        /// <returns>Returns the Models.OrganisationDetailsListResponse response from the API call.</returns>
        public Models.OrganisationDetailsListResponse ListAllOrganisations(
                Guid? filterChildOrganisationId = null,
                List<Guid> filterOrganisationIds = null)
            => CoreHelper.RunTask(ListAllOrganisationsAsync(filterChildOrganisationId, filterOrganisationIds));

        /// <summary>
        /// List all organisations.
        /// </summary>
        /// <param name="filterChildOrganisationId">Optional parameter: Child org id.</param>
        /// <param name="filterOrganisationIds">Optional parameter: Organisation ids.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrganisationDetailsListResponse response from the API call.</returns>
        public async Task<Models.OrganisationDetailsListResponse> ListAllOrganisationsAsync(
                Guid? filterChildOrganisationId = null,
                List<Guid> filterOrganisationIds = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrganisationDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/units")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter[child_organisation_id]", filterChildOrganisationId))
                      .Query(_query => _query.Setup("filter[organisation_ids]", filterOrganisationIds))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create organisation.
        /// </summary>
        /// <param name="organisationCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.OrganisationCreationResponse response from the API call.</returns>
        public Models.OrganisationCreationResponse CreateOrganisation(
                Models.OrganisationCreation organisationCreationRequest = null)
            => CoreHelper.RunTask(CreateOrganisationAsync(organisationCreationRequest));

        /// <summary>
        /// Create organisation.
        /// </summary>
        /// <param name="organisationCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrganisationCreationResponse response from the API call.</returns>
        public async Task<Models.OrganisationCreationResponse> CreateOrganisationAsync(
                Models.OrganisationCreation organisationCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrganisationCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/organisation/units")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(organisationCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch organisation.
        /// </summary>
        /// <param name="id">Required parameter: Organisation Id.</param>
        /// <returns>Returns the Models.OrganisationDetailsResponse response from the API call.</returns>
        public Models.OrganisationDetailsResponse FetchOrganisation(
                Guid id)
            => CoreHelper.RunTask(FetchOrganisationAsync(id));

        /// <summary>
        /// Fetch organisation.
        /// </summary>
        /// <param name="id">Required parameter: Organisation Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrganisationDetailsResponse response from the API call.</returns>
        public async Task<Models.OrganisationDetailsResponse> FetchOrganisationAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrganisationDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/units/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update organisation.
        /// </summary>
        /// <param name="id">Required parameter: Organisation Id.</param>
        /// <param name="organisationUpdateRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.OrganisationDetailsResponse response from the API call.</returns>
        public Models.OrganisationDetailsResponse UpdateOrganisation(
                Guid id,
                Models.OrganisationUpdate organisationUpdateRequest = null)
            => CoreHelper.RunTask(UpdateOrganisationAsync(id, organisationUpdateRequest));

        /// <summary>
        /// Update organisation.
        /// </summary>
        /// <param name="id">Required parameter: Organisation Id.</param>
        /// <param name="organisationUpdateRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrganisationDetailsResponse response from the API call.</returns>
        public async Task<Models.OrganisationDetailsResponse> UpdateOrganisationAsync(
                Guid id,
                Models.OrganisationUpdate organisationUpdateRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrganisationDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/organisation/units/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(organisationUpdateRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}