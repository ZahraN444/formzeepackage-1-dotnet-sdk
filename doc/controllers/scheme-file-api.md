# Scheme File API

```csharp
SchemeFileAPIController schemeFileAPIController = client.SchemeFileAPIController;
```

## Class Name

`SchemeFileAPIController`

## Methods

* [List Scheme Files](../../doc/controllers/scheme-file-api.md#list-scheme-files)
* [Create Scheme File](../../doc/controllers/scheme-file-api.md#create-scheme-file)
* [Get Scheme File](../../doc/controllers/scheme-file-api.md#get-scheme-file)
* [Upload Scheme File](../../doc/controllers/scheme-file-api.md#upload-scheme-file)
* [Create Scheme File Admission](../../doc/controllers/scheme-file-api.md#create-scheme-file-admission)
* [Get Scheme File Admission](../../doc/controllers/scheme-file-api.md#get-scheme-file-admission)
* [Create Scheme File Submission](../../doc/controllers/scheme-file-api.md#create-scheme-file-submission)
* [Get Scheme File Submission](../../doc/controllers/scheme-file-api.md#get-scheme-file-submission)


# List Scheme Files

List Scheme files

```csharp
ListSchemeFilesAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Find all Scheme File resources with a given organisation ID |
| `filterPaymentScheme` | `string` | Query, Optional | Find Scheme File resources by a certain scheme |
| `filterFileFormat` | `string` | Query, Optional | Find Scheme File resources by the format of the file |
| `filterFileType` | `string` | Query, Optional | Find Scheme File resources by the type of the file |
| `filterCreatedOnFrom` | `DateTime?` | Query, Optional | Find all Scheme File resources created from this date, in format YYYY-MM-DD |
| `filterCreatedOnTo` | `DateTime?` | Query, Optional | Find all Scheme File resources created up to this date, in format YYYY-MM-DD |
| `filterSubmissionStatus` | `string` | Query, Optional | Find all Scheme File resources with a certain submission status |
| `filterSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | Find all Scheme File resources submitted from and including this date/time |
| `filterSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | Find all Scheme File resources submitted up to and included this date/time |
| `filterAdmissionStatus` | `string` | Query, Optional | Find all File resources with a certain admission status |
| `filterAdmissionAdmissionDateFrom` | `DateTime?` | Query, Optional | Find all File resources admitted from and including this date/time |
| `filterAdmissionAdmissionDateTo` | `DateTime?` | Query, Optional | Find all File resources admitted up to and included this date/time |

## Response Type

[`Task<Models.ListSchemeFilesResponse>`](../../doc/models/list-scheme-files-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    ListSchemeFilesResponse result = await schemeFileAPIController.ListSchemeFilesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Reports bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Scheme File

Creates a Scheme File

```csharp
CreateSchemeFileAsync(
    Models.SchemeFileCreation schemeFileCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileCreationRequest` | [`SchemeFileCreation`](../../doc/models/scheme-file-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.SchemeFileResponse>`](../../doc/models/scheme-file-response.md)

## Example Usage

```csharp
SchemeFileCreation schemeFileCreationRequest = new SchemeFileCreation
{
    Data = new SchemeFile
    {
        Attributes = new Attributes39
        {
            FileFormat = "xml",
            FileHash = "f60071837de834af950f070aa08fc1e0e3e4b1f7014a6251eabf207eba10c817",
            FileSize = 1024,
            FileType = FileTypeEnum.Switch,
            HashingAlgorithm = "SHA256",
            NumberOfParts = 1,
            PaymentScheme = PaymentScheme2Enum.CASS,
        },
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        CreatedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ModifiedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Version = 0,
    },
};

try
{
    SchemeFileResponse result = await schemeFileAPIController.CreateSchemeFileAsync(schemeFileCreationRequest);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Scheme File

Get Scheme file

```csharp
GetSchemeFileAsync(
    Guid schemeFileId,
    string accept = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileId` | `Guid` | Template, Required | Scheme File Id |
| `accept` | `string` | Header, Optional | Acceptable Formats, possible values are "application/vnd.api+json" and "application/xml" |

## Response Type

[`Task<Models.SchemeFileResponse>`](../../doc/models/scheme-file-response.md)

## Example Usage

```csharp
Guid schemeFileId = new Guid("000008fc-0000-0000-0000-000000000000");
try
{
    SchemeFileResponse result = await schemeFileAPIController.GetSchemeFileAsync(schemeFileId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Upload Scheme File

Put Scheme file chunk

```csharp
UploadSchemeFileAsync(
    Guid schemeFileId,
    string xForm3UploadPart,
    FileStreamInfo payload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileId` | `Guid` | Template, Required | Scheme File Id |
| `xForm3UploadPart` | `string` | Header, Required | Which part of the file we are uploading |
| `payload` | `FileStreamInfo` | Form, Required | - |

## Response Type

[`Task<Models.SchemeFileResponse>`](../../doc/models/scheme-file-response.md)

## Example Usage

```csharp
Guid schemeFileId = new Guid("000008fc-0000-0000-0000-000000000000");
string xForm3UploadPart = "X-Form3-Upload-Part2";
FileStreamInfo payload = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    SchemeFileResponse result = await schemeFileAPIController.UploadSchemeFileAsync(
        schemeFileId,
        xForm3UploadPart,
        payload
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Scheme File Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Scheme File Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Scheme File Admission

Creates a Scheme File Admission

```csharp
CreateSchemeFileAdmissionAsync(
    Guid schemeFileId,
    Models.SchemeFileAdmissionCreation schemeFileAdmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileId` | `Guid` | Template, Required | Scheme File Id |
| `schemeFileAdmissionCreationRequest` | [`SchemeFileAdmissionCreation`](../../doc/models/scheme-file-admission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.SchemeFileAdmissionResponse>`](../../doc/models/scheme-file-admission-response.md)

## Example Usage

```csharp
Guid schemeFileId = new Guid("000008fc-0000-0000-0000-000000000000");
SchemeFileAdmissionCreation schemeFileAdmissionCreationRequest = new SchemeFileAdmissionCreation
{
    Data = new SchemeFileAdmission
    {
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        CreatedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ModifiedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Version = 0,
    },
};

try
{
    SchemeFileAdmissionResponse result = await schemeFileAPIController.CreateSchemeFileAdmissionAsync(
        schemeFileId,
        schemeFileAdmissionCreationRequest
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Scheme File Admission Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Scheme File Admission

Fetch scheme file admission

```csharp
GetSchemeFileAdmissionAsync(
    Guid schemeFileId,
    Guid schemeFileAdmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileId` | `Guid` | Template, Required | Scheme File Id |
| `schemeFileAdmissionId` | `Guid` | Template, Required | Scheme File Admission Id |

## Response Type

[`Task<Models.SchemeFileAdmissionResponse>`](../../doc/models/scheme-file-admission-response.md)

## Example Usage

```csharp
Guid schemeFileId = new Guid("000008fc-0000-0000-0000-000000000000");
Guid schemeFileAdmissionId = new Guid("00000766-0000-0000-0000-000000000000");
try
{
    SchemeFileAdmissionResponse result = await schemeFileAPIController.GetSchemeFileAdmissionAsync(
        schemeFileId,
        schemeFileAdmissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Scheme File Submission

Creates a Scheme File Submission

```csharp
CreateSchemeFileSubmissionAsync(
    Guid schemeFileId,
    Models.SchemeFileSubmissionCreation schemeFileSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileId` | `Guid` | Template, Required | Scheme File Id |
| `schemeFileSubmissionCreationRequest` | [`SchemeFileSubmissionCreation`](../../doc/models/scheme-file-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.SchemeFileSubmissionResponse>`](../../doc/models/scheme-file-submission-response.md)

## Example Usage

```csharp
Guid schemeFileId = new Guid("000008fc-0000-0000-0000-000000000000");
SchemeFileSubmissionCreation schemeFileSubmissionCreationRequest = new SchemeFileSubmissionCreation
{
    Data = new SchemeFileSubmission
    {
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        CreatedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ModifiedOn = DateTime.ParseExact("09/26/2017 15:26:57", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Version = 0,
    },
};

try
{
    SchemeFileSubmissionResponse result = await schemeFileAPIController.CreateSchemeFileSubmissionAsync(
        schemeFileId,
        schemeFileSubmissionCreationRequest
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Scheme File Submission Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Scheme File Submission

Get Scheme file submission

```csharp
GetSchemeFileSubmissionAsync(
    Guid schemeFileId,
    Guid schemeFileSubmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `schemeFileId` | `Guid` | Template, Required | Scheme File Id |
| `schemeFileSubmissionId` | `Guid` | Template, Required | Scheme File Submission Id |

## Response Type

[`Task<Models.SchemeFileSubmissionResponse>`](../../doc/models/scheme-file-submission-response.md)

## Example Usage

```csharp
Guid schemeFileId = new Guid("000008fc-0000-0000-0000-000000000000");
Guid schemeFileSubmissionId = new Guid("00000c68-0000-0000-0000-000000000000");
try
{
    SchemeFileSubmissionResponse result = await schemeFileAPIController.GetSchemeFileSubmissionAsync(
        schemeFileId,
        schemeFileSubmissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Server Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

