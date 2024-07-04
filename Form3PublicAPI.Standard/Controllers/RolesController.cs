// <copyright file="RolesController.cs" company="APIMatic">
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
    /// RolesController.
    /// </summary>
    public class RolesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesController"/> class.
        /// </summary>
        internal RolesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List all roles.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <returns>Returns the Models.RoleDetailsListResponse response from the API call.</returns>
        public Models.RoleDetailsListResponse ListAllRoles(
                int? pageNumber = null,
                int? pageSize = null)
            => CoreHelper.RunTask(ListAllRolesAsync(pageNumber, pageSize));

        /// <summary>
        /// List all roles.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RoleDetailsListResponse response from the API call.</returns>
        public async Task<Models.RoleDetailsListResponse> ListAllRolesAsync(
                int? pageNumber = null,
                int? pageSize = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RoleDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/roles")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create role.
        /// </summary>
        /// <param name="roleCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.RoleCreationResponse response from the API call.</returns>
        public Models.RoleCreationResponse CreateRole(
                Models.RoleCreation roleCreationRequest = null)
            => CoreHelper.RunTask(CreateRoleAsync(roleCreationRequest));

        /// <summary>
        /// Create role.
        /// </summary>
        /// <param name="roleCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RoleCreationResponse response from the API call.</returns>
        public async Task<Models.RoleCreationResponse> CreateRoleAsync(
                Models.RoleCreation roleCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RoleCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/security/roles")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(roleCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete role.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteRole(
                Guid roleId,
                int version)
            => CoreHelper.RunVoidTask(DeleteRoleAsync(roleId, version));

        /// <summary>
        /// Delete role.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteRoleAsync(
                Guid roleId,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/security/roles/{role_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("role_id", roleId))
                      .Query(_query => _query.Setup("version", version))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch role.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <returns>Returns the Models.RoleDetailsResponse response from the API call.</returns>
        public Models.RoleDetailsResponse FetchRole(
                Guid roleId)
            => CoreHelper.RunTask(FetchRoleAsync(roleId));

        /// <summary>
        /// Fetch role.
        /// </summary>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RoleDetailsResponse response from the API call.</returns>
        public async Task<Models.RoleDetailsResponse> FetchRoleAsync(
                Guid roleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RoleDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/roles/{role_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("role_id", roleId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}