// <copyright file="BranchesController.cs" company="APIMatic">
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
    /// BranchesController.
    /// </summary>
    public class BranchesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchesController"/> class.
        /// </summary>
        internal BranchesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List branches.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterBankId">Optional parameter: Filter by bank id e.g. sort code or bic.</param>
        /// <param name="filterBankIdCode">Optional parameter: Filter by type of bank id e.g. "GBDSC".</param>
        /// <param name="filterAcceptanceQualifier">Optional parameter: Filter by acceptance qualifier.</param>
        /// <param name="filterValidationType">Optional parameter: Filter by validation type e.g. card.</param>
        /// <param name="filterReferenceMask">Optional parameter: Filter by reference mask.</param>
        /// <returns>Returns the Models.BranchDetailsListResponse response from the API call.</returns>
        public Models.BranchDetailsListResponse ListBranches(
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterBankId = null,
                List<string> filterBankIdCode = null,
                List<string> filterAcceptanceQualifier = null,
                List<string> filterValidationType = null,
                List<string> filterReferenceMask = null)
            => CoreHelper.RunTask(ListBranchesAsync(pageNumber, pageSize, filterOrganisationId, filterBankId, filterBankIdCode, filterAcceptanceQualifier, filterValidationType, filterReferenceMask));

        /// <summary>
        /// List branches.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterBankId">Optional parameter: Filter by bank id e.g. sort code or bic.</param>
        /// <param name="filterBankIdCode">Optional parameter: Filter by type of bank id e.g. "GBDSC".</param>
        /// <param name="filterAcceptanceQualifier">Optional parameter: Filter by acceptance qualifier.</param>
        /// <param name="filterValidationType">Optional parameter: Filter by validation type e.g. card.</param>
        /// <param name="filterReferenceMask">Optional parameter: Filter by reference mask.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchDetailsListResponse response from the API call.</returns>
        public async Task<Models.BranchDetailsListResponse> ListBranchesAsync(
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterBankId = null,
                List<string> filterBankIdCode = null,
                List<string> filterAcceptanceQualifier = null,
                List<string> filterValidationType = null,
                List<string> filterReferenceMask = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/branches")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[bank_id]", filterBankId))
                      .Query(_query => _query.Setup("filter[bank_id_code]", filterBankIdCode))
                      .Query(_query => _query.Setup("filter[acceptance_qualifier]", filterAcceptanceQualifier))
                      .Query(_query => _query.Setup("filter[validation_type]", filterValidationType))
                      .Query(_query => _query.Setup("filter[reference_mask]", filterReferenceMask))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a Branch.
        /// </summary>
        /// <param name="branchCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.BranchCreationResponse response from the API call.</returns>
        public Models.BranchCreationResponse CreateABranch(
                Models.BranchCreation branchCreationRequest = null)
            => CoreHelper.RunTask(CreateABranchAsync(branchCreationRequest));

        /// <summary>
        /// Create a Branch.
        /// </summary>
        /// <param name="branchCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchCreationResponse response from the API call.</returns>
        public async Task<Models.BranchCreationResponse> CreateABranchAsync(
                Models.BranchCreation branchCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/organisation/branches")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(branchCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Branch creation error, constraint violation of organisation id and bank id", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete branch.
        /// </summary>
        /// <param name="id">Required parameter: Branch Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteBranch(
                Guid id,
                int version)
            => CoreHelper.RunVoidTask(DeleteBranchAsync(id, version));

        /// <summary>
        /// Delete branch.
        /// </summary>
        /// <param name="id">Required parameter: Branch Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteBranchAsync(
                Guid id,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/organisation/branches/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Query(_query => _query.Setup("version", version))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch branch.
        /// </summary>
        /// <param name="id">Required parameter: Branch Id.</param>
        /// <returns>Returns the Models.BranchDetailsResponse response from the API call.</returns>
        public Models.BranchDetailsResponse FetchBranch(
                Guid id)
            => CoreHelper.RunTask(FetchBranchAsync(id));

        /// <summary>
        /// Fetch branch.
        /// </summary>
        /// <param name="id">Required parameter: Branch Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchDetailsResponse response from the API call.</returns>
        public async Task<Models.BranchDetailsResponse> FetchBranchAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/branches/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Amend branch.
        /// </summary>
        /// <param name="id">Required parameter: Branches Id.</param>
        /// <param name="branchAmendRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.BranchDetailsResponse response from the API call.</returns>
        public Models.BranchDetailsResponse AmendBranch(
                Guid id,
                Models.BranchAmendment branchAmendRequest = null)
            => CoreHelper.RunTask(AmendBranchAsync(id, branchAmendRequest));

        /// <summary>
        /// Amend branch.
        /// </summary>
        /// <param name="id">Required parameter: Branches Id.</param>
        /// <param name="branchAmendRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BranchDetailsResponse response from the API call.</returns>
        public async Task<Models.BranchDetailsResponse> AmendBranchAsync(
                Guid id,
                Models.BranchAmendment branchAmendRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BranchDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/organisation/branches/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(branchAmendRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}