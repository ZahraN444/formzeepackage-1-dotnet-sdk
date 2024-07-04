// <copyright file="BranchIdentificationController.cs" company="APIMatic">
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
    /// BranchIdentificationController.
    /// </summary>
    public class BranchIdentificationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchIdentificationController"/> class.
        /// </summary>
        internal BranchIdentificationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List Branch Identifications by Branch.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id to which this identification relates to.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterSecondaryIdentification">Optional parameter: Filter to only include branch identifications with specified secondary_identification.</param>
        /// <returns>Returns the Models.BranchIdentificationListResponse response from the API call.</returns>
        public Models.BranchIdentificationListResponse ListBranchIdentificationsByBranch(
                Guid branchId,
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterSecondaryIdentification = null)
            => CoreHelper.RunTask(ListBranchIdentificationsByBranchAsync(branchId, pageNumber, pageSize, filterOrganisationId, filterSecondaryIdentification));

        /// <summary>
        /// List Branch Identifications by Branch.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id to which this identification relates to.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterSecondaryIdentification">Optional parameter: Filter to only include branch identifications with specified secondary_identification.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchIdentificationListResponse response from the API call.</returns>
        public async Task<Models.BranchIdentificationListResponse> ListBranchIdentificationsByBranchAsync(
                Guid branchId,
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterSecondaryIdentification = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchIdentificationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/branches/{branch_id}/identifications")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("branch_id", branchId))
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[secondary_identification]", filterSecondaryIdentification))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create an identification for an existing Branch.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id to which this identification relates to.</param>
        /// <param name="branchIdentificationCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.BranchIdentificationResponse response from the API call.</returns>
        public Models.BranchIdentificationResponse CreateAnIdentificationForAnExistingBranch(
                Guid branchId,
                Models.BranchIdentificationRequest branchIdentificationCreationRequest = null)
            => CoreHelper.RunTask(CreateAnIdentificationForAnExistingBranchAsync(branchId, branchIdentificationCreationRequest));

        /// <summary>
        /// Create an identification for an existing Branch.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id to which this identification relates to.</param>
        /// <param name="branchIdentificationCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchIdentificationResponse response from the API call.</returns>
        public async Task<Models.BranchIdentificationResponse> CreateAnIdentificationForAnExistingBranchAsync(
                Guid branchId,
                Models.BranchIdentificationRequest branchIdentificationCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchIdentificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/organisation/branches/{branch_id}/identifications")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(branchIdentificationCreationRequest))
                      .Template(_template => _template.Setup("branch_id", branchId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Branch Identification creation error, constraint violation of secondary identification", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete branch identification.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id.</param>
        /// <param name="identificationId">Required parameter: Branch Identification Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteBranchIdentification(
                Guid branchId,
                Guid identificationId,
                int version)
            => CoreHelper.RunVoidTask(DeleteBranchIdentificationAsync(branchId, identificationId, version));

        /// <summary>
        /// Delete branch identification.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id.</param>
        /// <param name="identificationId">Required parameter: Branch Identification Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteBranchIdentificationAsync(
                Guid branchId,
                Guid identificationId,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/organisation/branches/{branch_id}/identifications/{identification_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("branch_id", branchId))
                      .Template(_template => _template.Setup("identification_id", identificationId))
                      .Query(_query => _query.Setup("version", version))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Branch Identification not found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a branch identification by id.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id.</param>
        /// <param name="identificationId">Required parameter: Branch Identification Id.</param>
        /// <returns>Returns the Models.BranchIdentificationResponse response from the API call.</returns>
        public Models.BranchIdentificationResponse GetABranchIdentificationById(
                Guid branchId,
                Guid identificationId)
            => CoreHelper.RunTask(GetABranchIdentificationByIdAsync(branchId, identificationId));

        /// <summary>
        /// Get a branch identification by id.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id.</param>
        /// <param name="identificationId">Required parameter: Branch Identification Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchIdentificationResponse response from the API call.</returns>
        public async Task<Models.BranchIdentificationResponse> GetABranchIdentificationByIdAsync(
                Guid branchId,
                Guid identificationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchIdentificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/branches/{branch_id}/identifications/{identification_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("branch_id", branchId))
                      .Template(_template => _template.Setup("identification_id", identificationId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Amend Branch Identification.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id.</param>
        /// <param name="identificationId">Required parameter: Branch Identification Id; Must match id in the payload.</param>
        /// <param name="branchIdentificationAmendRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.BranchIdentificationResponse response from the API call.</returns>
        public Models.BranchIdentificationResponse AmendBranchIdentification(
                Guid branchId,
                Guid identificationId,
                Models.BranchIdentificationRequest branchIdentificationAmendRequest = null)
            => CoreHelper.RunTask(AmendBranchIdentificationAsync(branchId, identificationId, branchIdentificationAmendRequest));

        /// <summary>
        /// Amend Branch Identification.
        /// </summary>
        /// <param name="branchId">Required parameter: Branch Id.</param>
        /// <param name="identificationId">Required parameter: Branch Identification Id; Must match id in the payload.</param>
        /// <param name="branchIdentificationAmendRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchIdentificationResponse response from the API call.</returns>
        public async Task<Models.BranchIdentificationResponse> AmendBranchIdentificationAsync(
                Guid branchId,
                Guid identificationId,
                Models.BranchIdentificationRequest branchIdentificationAmendRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchIdentificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/organisation/branches/{branch_id}/identifications/{identification_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(branchIdentificationAmendRequest))
                      .Template(_template => _template.Setup("branch_id", branchId))
                      .Template(_template => _template.Setup("identification_id", identificationId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Branch Identification update error, constraint violation of secondary identification", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}