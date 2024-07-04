// <copyright file="SchemeFileAPIController.cs" company="APIMatic">
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
    /// SchemeFileAPIController.
    /// </summary>
    public class SchemeFileAPIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileAPIController"/> class.
        /// </summary>
        internal SchemeFileAPIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List Scheme files.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Find all Scheme File resources with a given organisation ID.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Find Scheme File resources by a certain scheme.</param>
        /// <param name="filterFileFormat">Optional parameter: Find Scheme File resources by the format of the file.</param>
        /// <param name="filterFileType">Optional parameter: Find Scheme File resources by the type of the file.</param>
        /// <param name="filterCreatedOnFrom">Optional parameter: Find all Scheme File resources created from this date, in format YYYY-MM-DD.</param>
        /// <param name="filterCreatedOnTo">Optional parameter: Find all Scheme File resources created up to this date, in format YYYY-MM-DD.</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Find all Scheme File resources with a certain submission status.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Find all Scheme File resources submitted from and including this date/time.</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Find all Scheme File resources submitted up to and included this date/time.</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Find all File resources with a certain admission status.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Find all File resources admitted from and including this date/time.</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Find all File resources admitted up to and included this date/time.</param>
        /// <returns>Returns the Models.ListSchemeFilesResponse response from the API call.</returns>
        public Models.ListSchemeFilesResponse ListSchemeFiles(
                string pageNumber = null,
                int? pageSize = 100,
                List<Guid> filterOrganisationId = null,
                string filterPaymentScheme = null,
                string filterFileFormat = null,
                string filterFileType = null,
                DateTime? filterCreatedOnFrom = null,
                DateTime? filterCreatedOnTo = null,
                string filterSubmissionStatus = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterAdmissionStatus = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null)
            => CoreHelper.RunTask(ListSchemeFilesAsync(pageNumber, pageSize, filterOrganisationId, filterPaymentScheme, filterFileFormat, filterFileType, filterCreatedOnFrom, filterCreatedOnTo, filterSubmissionStatus, filterSubmissionSubmissionDateFrom, filterSubmissionSubmissionDateTo, filterAdmissionStatus, filterAdmissionAdmissionDateFrom, filterAdmissionAdmissionDateTo));

        /// <summary>
        /// List Scheme files.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Find all Scheme File resources with a given organisation ID.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Find Scheme File resources by a certain scheme.</param>
        /// <param name="filterFileFormat">Optional parameter: Find Scheme File resources by the format of the file.</param>
        /// <param name="filterFileType">Optional parameter: Find Scheme File resources by the type of the file.</param>
        /// <param name="filterCreatedOnFrom">Optional parameter: Find all Scheme File resources created from this date, in format YYYY-MM-DD.</param>
        /// <param name="filterCreatedOnTo">Optional parameter: Find all Scheme File resources created up to this date, in format YYYY-MM-DD.</param>
        /// <param name="filterSubmissionStatus">Optional parameter: Find all Scheme File resources with a certain submission status.</param>
        /// <param name="filterSubmissionSubmissionDateFrom">Optional parameter: Find all Scheme File resources submitted from and including this date/time.</param>
        /// <param name="filterSubmissionSubmissionDateTo">Optional parameter: Find all Scheme File resources submitted up to and included this date/time.</param>
        /// <param name="filterAdmissionStatus">Optional parameter: Find all File resources with a certain admission status.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Find all File resources admitted from and including this date/time.</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Find all File resources admitted up to and included this date/time.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSchemeFilesResponse response from the API call.</returns>
        public async Task<Models.ListSchemeFilesResponse> ListSchemeFilesAsync(
                string pageNumber = null,
                int? pageSize = 100,
                List<Guid> filterOrganisationId = null,
                string filterPaymentScheme = null,
                string filterFileFormat = null,
                string filterFileType = null,
                DateTime? filterCreatedOnFrom = null,
                DateTime? filterCreatedOnTo = null,
                string filterSubmissionStatus = null,
                DateTime? filterSubmissionSubmissionDateFrom = null,
                DateTime? filterSubmissionSubmissionDateTo = null,
                string filterAdmissionStatus = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSchemeFilesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/schemefiles")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", (pageSize != null) ? pageSize : 100))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[file_format]", filterFileFormat))
                      .Query(_query => _query.Setup("filter[file_type]", filterFileType))
                      .Query(_query => _query.Setup("filter[created_on_from]", filterCreatedOnFrom.HasValue ? filterCreatedOnFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[created_on_to]", filterCreatedOnTo.HasValue ? filterCreatedOnTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[submission.status]", filterSubmissionStatus))
                      .Query(_query => _query.Setup("filter[submission.submission_date_from]", filterSubmissionSubmissionDateFrom.HasValue ? filterSubmissionSubmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[submission.submission_date_to]", filterSubmissionSubmissionDateTo.HasValue ? filterSubmissionSubmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.status]", filterAdmissionStatus))
                      .Query(_query => _query.Setup("filter[admission.admission_date_from]", filterAdmissionAdmissionDateFrom.HasValue ? filterAdmissionAdmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.admission_date_to]", filterAdmissionAdmissionDateTo.HasValue ? filterAdmissionAdmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reports bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Scheme File.
        /// </summary>
        /// <param name="schemeFileCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SchemeFileResponse response from the API call.</returns>
        public Models.SchemeFileResponse CreateSchemeFile(
                Models.SchemeFileCreation schemeFileCreationRequest = null)
            => CoreHelper.RunTask(CreateSchemeFileAsync(schemeFileCreationRequest));

        /// <summary>
        /// Creates a Scheme File.
        /// </summary>
        /// <param name="schemeFileCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileResponse response from the API call.</returns>
        public async Task<Models.SchemeFileResponse> CreateSchemeFileAsync(
                Models.SchemeFileCreation schemeFileCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/schemefiles")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(schemeFileCreationRequest))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Scheme file.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="accept">Optional parameter: Acceptable Formats, possible values are "application/vnd.api+json" and "application/xml".</param>
        /// <returns>Returns the Models.SchemeFileResponse response from the API call.</returns>
        public Models.SchemeFileResponse GetSchemeFile(
                Guid schemeFileId,
                string accept = null)
            => CoreHelper.RunTask(GetSchemeFileAsync(schemeFileId, accept));

        /// <summary>
        /// Get Scheme file.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="accept">Optional parameter: Acceptable Formats, possible values are "application/vnd.api+json" and "application/xml".</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileResponse response from the API call.</returns>
        public async Task<Models.SchemeFileResponse> GetSchemeFileAsync(
                Guid schemeFileId,
                string accept = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/schemefiles/{scheme_file_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("scheme_file_id", schemeFileId))
                      .Header(_header => _header.Setup("Accept", accept))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Put Scheme file chunk.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="xForm3UploadPart">Required parameter: Which part of the file we are uploading.</param>
        /// <param name="payload">Required parameter: Example: .</param>
        /// <returns>Returns the Models.SchemeFileResponse response from the API call.</returns>
        public Models.SchemeFileResponse UploadSchemeFile(
                Guid schemeFileId,
                string xForm3UploadPart,
                FileStreamInfo payload)
            => CoreHelper.RunTask(UploadSchemeFileAsync(schemeFileId, xForm3UploadPart, payload));

        /// <summary>
        /// Put Scheme file chunk.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="xForm3UploadPart">Required parameter: Which part of the file we are uploading.</param>
        /// <param name="payload">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileResponse response from the API call.</returns>
        public async Task<Models.SchemeFileResponse> UploadSchemeFileAsync(
                Guid schemeFileId,
                string xForm3UploadPart,
                FileStreamInfo payload,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/files/schemefiles/{scheme_file_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("scheme_file_id", schemeFileId))
                      .Header(_header => _header.Setup("X-Form3-Upload-Part", xForm3UploadPart))
                      .Form(_form => _form.Setup("payload", payload))
                      .Header(_header => _header.Setup("Content-Type", "application/octet-stream"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Scheme File Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Scheme File Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Scheme File Admission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileAdmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SchemeFileAdmissionResponse response from the API call.</returns>
        public Models.SchemeFileAdmissionResponse CreateSchemeFileAdmission(
                Guid schemeFileId,
                Models.SchemeFileAdmissionCreation schemeFileAdmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateSchemeFileAdmissionAsync(schemeFileId, schemeFileAdmissionCreationRequest));

        /// <summary>
        /// Creates a Scheme File Admission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileAdmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileAdmissionResponse response from the API call.</returns>
        public async Task<Models.SchemeFileAdmissionResponse> CreateSchemeFileAdmissionAsync(
                Guid schemeFileId,
                Models.SchemeFileAdmissionCreation schemeFileAdmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileAdmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/schemefiles/{scheme_file_id}/admissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(schemeFileAdmissionCreationRequest))
                      .Template(_template => _template.Setup("scheme_file_id", schemeFileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Scheme File Admission Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch scheme file admission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileAdmissionId">Required parameter: Scheme File Admission Id.</param>
        /// <returns>Returns the Models.SchemeFileAdmissionResponse response from the API call.</returns>
        public Models.SchemeFileAdmissionResponse GetSchemeFileAdmission(
                Guid schemeFileId,
                Guid schemeFileAdmissionId)
            => CoreHelper.RunTask(GetSchemeFileAdmissionAsync(schemeFileId, schemeFileAdmissionId));

        /// <summary>
        /// Fetch scheme file admission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileAdmissionId">Required parameter: Scheme File Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileAdmissionResponse response from the API call.</returns>
        public async Task<Models.SchemeFileAdmissionResponse> GetSchemeFileAdmissionAsync(
                Guid schemeFileId,
                Guid schemeFileAdmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileAdmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/schemefiles/{scheme_file_id}/admissions/{scheme_file_admission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("scheme_file_id", schemeFileId))
                      .Template(_template => _template.Setup("scheme_file_admission_id", schemeFileAdmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Scheme File Submission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SchemeFileSubmissionResponse response from the API call.</returns>
        public Models.SchemeFileSubmissionResponse CreateSchemeFileSubmission(
                Guid schemeFileId,
                Models.SchemeFileSubmissionCreation schemeFileSubmissionCreationRequest = null)
            => CoreHelper.RunTask(CreateSchemeFileSubmissionAsync(schemeFileId, schemeFileSubmissionCreationRequest));

        /// <summary>
        /// Creates a Scheme File Submission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileSubmissionCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileSubmissionResponse response from the API call.</returns>
        public async Task<Models.SchemeFileSubmissionResponse> CreateSchemeFileSubmissionAsync(
                Guid schemeFileId,
                Models.SchemeFileSubmissionCreation schemeFileSubmissionCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileSubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/files/schemefiles/{scheme_file_id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(schemeFileSubmissionCreationRequest))
                      .Template(_template => _template.Setup("scheme_file_id", schemeFileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Scheme File Submission Conflict", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Scheme file submission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileSubmissionId">Required parameter: Scheme File Submission Id.</param>
        /// <returns>Returns the Models.SchemeFileSubmissionResponse response from the API call.</returns>
        public Models.SchemeFileSubmissionResponse GetSchemeFileSubmission(
                Guid schemeFileId,
                Guid schemeFileSubmissionId)
            => CoreHelper.RunTask(GetSchemeFileSubmissionAsync(schemeFileId, schemeFileSubmissionId));

        /// <summary>
        /// Get Scheme file submission.
        /// </summary>
        /// <param name="schemeFileId">Required parameter: Scheme File Id.</param>
        /// <param name="schemeFileSubmissionId">Required parameter: Scheme File Submission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeFileSubmissionResponse response from the API call.</returns>
        public async Task<Models.SchemeFileSubmissionResponse> GetSchemeFileSubmissionAsync(
                Guid schemeFileId,
                Guid schemeFileSubmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeFileSubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/files/schemefiles/{scheme_file_id}/submissions/{scheme_file_submission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("scheme_file_id", schemeFileId))
                      .Template(_template => _template.Setup("scheme_file_submission_id", schemeFileSubmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}