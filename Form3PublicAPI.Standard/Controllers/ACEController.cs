// <copyright file="ACEController.cs" company="APIMatic">
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
    /// ACEController.
    /// </summary>
    public class ACEController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACEController"/> class.
        /// </summary>
        internal ACEController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List all Access Controls for role.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <returns>Returns the Models.AceDetailsListResponse response from the API call.</returns>
        public Models.AceDetailsListResponse ListAllAccessControlsForRole(
                Guid roleId)
            => CoreHelper.RunTask(ListAllAccessControlsForRoleAsync(roleId));

        /// <summary>
        /// List all Access Controls for role.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AceDetailsListResponse response from the API call.</returns>
        public async Task<Models.AceDetailsListResponse> ListAllAccessControlsForRoleAsync(
                Guid roleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AceDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/roles/{role_id}/aces")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("role_id", roleId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create Access Control Entry.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="aCECreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AceCreationResponse response from the API call.</returns>
        public Models.AceCreationResponse CreateAccessControlEntry(
                Guid roleId,
                Models.AceCreation aCECreationRequest = null)
            => CoreHelper.RunTask(CreateAccessControlEntryAsync(roleId, aCECreationRequest));

        /// <summary>
        /// Create Access Control Entry.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="aCECreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AceCreationResponse response from the API call.</returns>
        public async Task<Models.AceCreationResponse> CreateAccessControlEntryAsync(
                Guid roleId,
                Models.AceCreation aCECreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AceCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/security/roles/{role_id}/aces")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(aCECreationRequest))
                      .Template(_template => _template.Setup("role_id", roleId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete Access Control Entry.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="aceId">Required parameter: Ace Id.</param>
        public void DeleteAccessControlEntry(
                Guid roleId,
                Guid aceId)
            => CoreHelper.RunVoidTask(DeleteAccessControlEntryAsync(roleId, aceId));

        /// <summary>
        /// Delete Access Control Entry.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="aceId">Required parameter: Ace Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteAccessControlEntryAsync(
                Guid roleId,
                Guid aceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/security/roles/{role_id}/aces/{ace_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("role_id", roleId))
                      .Template(_template => _template.Setup("ace_id", aceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch Access Control Entry.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="aceId">Required parameter: Ace Id.</param>
        /// <returns>Returns the Models.AceDetailsResponse response from the API call.</returns>
        public Models.AceDetailsResponse FetchAccessControlEntry(
                Guid roleId,
                Guid aceId)
            => CoreHelper.RunTask(FetchAccessControlEntryAsync(roleId, aceId));

        /// <summary>
        /// Fetch Access Control Entry.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="aceId">Required parameter: Ace Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AceDetailsResponse response from the API call.</returns>
        public async Task<Models.AceDetailsResponse> FetchAccessControlEntryAsync(
                Guid roleId,
                Guid aceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AceDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/roles/{role_id}/aces/{ace_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("role_id", roleId))
                      .Template(_template => _template.Setup("ace_id", aceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}