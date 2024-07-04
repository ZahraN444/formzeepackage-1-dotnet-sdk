// <copyright file="UsersController.cs" company="APIMatic">
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
    /// UsersController.
    /// </summary>
    public class UsersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        internal UsersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List all users.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <returns>Returns the Models.UserDetailsListResponse response from the API call.</returns>
        public Models.UserDetailsListResponse ListAllUsers(
                int? pageNumber = null,
                int? pageSize = null)
            => CoreHelper.RunTask(ListAllUsersAsync(pageNumber, pageSize));

        /// <summary>
        /// List all users.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserDetailsListResponse response from the API call.</returns>
        public async Task<Models.UserDetailsListResponse> ListAllUsersAsync(
                int? pageNumber = null,
                int? pageSize = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/users")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="userCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.UserCreationResponse response from the API call.</returns>
        public Models.UserCreationResponse CreateUser(
                Models.UserCreation userCreationRequest = null)
            => CoreHelper.RunTask(CreateUserAsync(userCreationRequest));

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="userCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserCreationResponse response from the API call.</returns>
        public async Task<Models.UserCreationResponse> CreateUserAsync(
                Models.UserCreation userCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/security/users")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(userCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteUser(
                Guid userId,
                int version)
            => CoreHelper.RunVoidTask(DeleteUserAsync(userId, version));

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteUserAsync(
                Guid userId,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/security/users/{user_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))
                      .Query(_query => _query.Setup("version", version))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <returns>Returns the Models.UserDetailsResponse response from the API call.</returns>
        public Models.UserDetailsResponse FetchUser(
                Guid userId)
            => CoreHelper.RunTask(FetchUserAsync(userId));

        /// <summary>
        /// Fetch user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserDetailsResponse response from the API call.</returns>
        public async Task<Models.UserDetailsResponse> FetchUserAsync(
                Guid userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/users/{user_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update user details.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="userUpdateRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.UserDetailsResponse response from the API call.</returns>
        public Models.UserDetailsResponse UpdateUserDetails(
                Guid userId,
                Models.UserCreation userUpdateRequest = null)
            => CoreHelper.RunTask(UpdateUserDetailsAsync(userId, userUpdateRequest));

        /// <summary>
        /// Update user details.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="userUpdateRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserDetailsResponse response from the API call.</returns>
        public async Task<Models.UserDetailsResponse> UpdateUserDetailsAsync(
                Guid userId,
                Models.UserCreation userUpdateRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/security/users/{user_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(userUpdateRequest))
                      .Template(_template => _template.Setup("user_id", userId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch access control list for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="filterRecordType">Optional parameter: Record type.</param>
        /// <param name="filterAction">Optional parameter: Access action.</param>
        /// <returns>Returns the Models.AceDetailsListResponse response from the API call.</returns>
        public Models.AceDetailsListResponse FetchAccessControlListForUser(
                Guid userId,
                string filterRecordType = null,
                string filterAction = null)
            => CoreHelper.RunTask(FetchAccessControlListForUserAsync(userId, filterRecordType, filterAction));

        /// <summary>
        /// Fetch access control list for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="filterRecordType">Optional parameter: Record type.</param>
        /// <param name="filterAction">Optional parameter: Access action.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AceDetailsListResponse response from the API call.</returns>
        public async Task<Models.AceDetailsListResponse> FetchAccessControlListForUserAsync(
                Guid userId,
                string filterRecordType = null,
                string filterAction = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AceDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/users/{user_id}/aces")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))
                      .Query(_query => _query.Setup("filter[record_type]", filterRecordType))
                      .Query(_query => _query.Setup("filter[action]", filterAction))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch credentials for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <returns>Returns the Models.UserCredentialListResponse response from the API call.</returns>
        public Models.UserCredentialListResponse FetchCredentialsForUser(
                Guid userId)
            => CoreHelper.RunTask(FetchCredentialsForUserAsync(userId));

        /// <summary>
        /// Fetch credentials for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserCredentialListResponse response from the API call.</returns>
        public async Task<Models.UserCredentialListResponse> FetchCredentialsForUserAsync(
                Guid userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserCredentialListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/users/{user_id}/credentials")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create new credentials for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <returns>Returns the Models.CredentialCreationResponse response from the API call.</returns>
        public Models.CredentialCreationResponse CreateNewCredentialsForUser(
                Guid userId)
            => CoreHelper.RunTask(CreateNewCredentialsForUserAsync(userId));

        /// <summary>
        /// Create new credentials for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CredentialCreationResponse response from the API call.</returns>
        public async Task<Models.CredentialCreationResponse> CreateNewCredentialsForUserAsync(
                Guid userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CredentialCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/security/users/{user_id}/credentials")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete credentials for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="clientId">Required parameter: client id.</param>
        public void DeleteCredentialsForUser(
                Guid userId,
                string clientId)
            => CoreHelper.RunVoidTask(DeleteCredentialsForUserAsync(userId, clientId));

        /// <summary>
        /// Delete credentials for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="clientId">Required parameter: client id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCredentialsForUserAsync(
                Guid userId,
                string clientId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/security/users/{user_id}/credentials/{client_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))
                      .Template(_template => _template.Setup("client_id", clientId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch all roles for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <returns>Returns the Models.UserRoleListResponse response from the API call.</returns>
        public Models.UserRoleListResponse FetchAllRolesForUser(
                Guid userId)
            => CoreHelper.RunTask(FetchAllRolesForUserAsync(userId));

        /// <summary>
        /// Fetch all roles for user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserRoleListResponse response from the API call.</returns>
        public async Task<Models.UserRoleListResponse> FetchAllRolesForUserAsync(
                Guid userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserRoleListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/security/users/{user_id}/roles")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Remove role from user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="roleId">Required parameter: Role Id.</param>
        public void RemoveRoleFromUser(
                Guid userId,
                Guid roleId)
            => CoreHelper.RunVoidTask(RemoveRoleFromUserAsync(userId, roleId));

        /// <summary>
        /// Remove role from user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task RemoveRoleFromUserAsync(
                Guid userId,
                Guid roleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/security/users/{user_id}/roles/{role_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))
                      .Template(_template => _template.Setup("role_id", roleId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Add role to user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="roleId">Required parameter: Role Id.</param>
        public void AddRoleToUser(
                Guid userId,
                Guid roleId)
            => CoreHelper.RunVoidTask(AddRoleToUserAsync(userId, roleId));

        /// <summary>
        /// Add role to user.
        /// </summary>
        /// <param name="userId">Required parameter: User Id.</param>
        /// <param name="roleId">Required parameter: Role Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task AddRoleToUserAsync(
                Guid userId,
                Guid roleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/security/users/{user_id}/roles/{role_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("user_id", userId))
                      .Template(_template => _template.Setup("role_id", roleId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}