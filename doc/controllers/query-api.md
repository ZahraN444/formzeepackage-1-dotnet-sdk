# Query Api

```csharp
QueryApiController queryApiController = client.QueryApiController;
```

## Class Name

`QueryApiController`

## Methods

* [List Queries](../../doc/controllers/query-api.md#list-queries)
* [Create Query](../../doc/controllers/query-api.md#create-query)
* [Get Query](../../doc/controllers/query-api.md#get-query)
* [Get Query Admission](../../doc/controllers/query-api.md#get-query-admission)
* [Create Query Response](../../doc/controllers/query-api.md#create-query-response)
* [Get Query Response](../../doc/controllers/query-api.md#get-query-response)
* [Get Query Response Admission](../../doc/controllers/query-api.md#get-query-response-admission)
* [Create Query Response Submission](../../doc/controllers/query-api.md#create-query-response-submission)
* [Get Query Response Submission](../../doc/controllers/query-api.md#get-query-response-submission)
* [Create Query Submission](../../doc/controllers/query-api.md#create-query-submission)
* [Get Query Submission](../../doc/controllers/query-api.md#get-query-submission)


# List Queries

Get Query

```csharp
ListQueriesAsync(
    List<Guid> filterOrganisationId = null,
    Models.ReportRequestStatusEnum? filterStatus = null,
    string filterQueryType = null,
    bool? filterAutoHandled = null,
    DateTime? filterProcessingDateFrom = null,
    DateTime? filterProcessingDateTo = null,
    DateTime? filterCreatedOnFrom = null,
    DateTime? filterCreatedOnTo = null,
    Guid? filterPaymentId = null,
    Guid? filterPaymentAdmissionId = null,
    Guid? filterPaymentSubmissionId = null,
    Guid? filterRecallId = null,
    Guid? filterRecallSubmissionId = null,
    Guid? filterQueryId = null,
    string pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | The organisations to filter on |
| `filterStatus` | [`ReportRequestStatusEnum?`](../../doc/models/report-request-status-enum.md) | Query, Optional | Find all queries for a given status |
| `filterQueryType` | `string` | Query, Optional | Find all queries for a given query type |
| `filterAutoHandled` | `bool?` | Query, Optional | Find all queries for given auto handled flag |
| `filterProcessingDateFrom` | `DateTime?` | Query, Optional | Find all queries from a certain value date. |
| `filterProcessingDateTo` | `DateTime?` | Query, Optional | Find all queries up to a certain value date. |
| `filterCreatedOnFrom` | `DateTime?` | Query, Optional | Find all queries from a certain created date. |
| `filterCreatedOnTo` | `DateTime?` | Query, Optional | Find all queries up to a certain created date. |
| `filterPaymentId` | `Guid?` | Query, Optional | Find all queries with a certain payment id. |
| `filterPaymentAdmissionId` | `Guid?` | Query, Optional | Find all queries with a certain payment admission id. |
| `filterPaymentSubmissionId` | `Guid?` | Query, Optional | Find all queries with a certain payment submission id. |
| `filterRecallId` | `Guid?` | Query, Optional | Find all queries with a certain recall id. |
| `filterRecallSubmissionId` | `Guid?` | Query, Optional | Find all queries with a certain recall submission id. |
| `filterQueryId` | `Guid?` | Query, Optional | Find all queries with a certain query id. |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |

## Response Type

[`Task<Models.QueryListResponse>`](../../doc/models/query-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    QueryListResponse result = await queryApiController.ListQueriesAsync();
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
| 400 | Query bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | Query gateway issue | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Query

Create a Query

```csharp
CreateQueryAsync(
    Models.QueryCreation creationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `creationRequest` | [`QueryCreation`](../../doc/models/query-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.QueryFetchResponse>`](../../doc/models/query-fetch-response.md)

## Example Usage

```csharp
QueryCreation creationRequest = new QueryCreation
{
    Data = new NewQuery
    {
        Attributes = new QueryAttributes
        {
            QueryType = QueryTypeEnum.ClaimNonReceipt,
        },
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("00000b24-0000-0000-0000-000000000000"),
        Type = "queries",
    },
};

try
{
    QueryFetchResponse result = await queryApiController.CreateQueryAsync(creationRequest);
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | gateway issue | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Query

Fetch a Query

```csharp
GetQueryAsync(
    Guid queryId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |

## Response Type

[`Task<Models.QueryFetchResponse>`](../../doc/models/query-fetch-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
try
{
    QueryFetchResponse result = await queryApiController.GetQueryAsync(queryId);
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Query Admission

Fetch a Query Admission

```csharp
GetQueryAdmissionAsync(
    Guid queryId,
    Guid queryAdmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `queryAdmissionId` | `Guid` | Template, Required | Query Admission ID |

## Response Type

[`Task<Models.QueryAdmissionResponse>`](../../doc/models/query-admission-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
Guid queryAdmissionId = new Guid("00001fc0-0000-0000-0000-000000000000");
try
{
    QueryAdmissionResponse result = await queryApiController.GetQueryAdmissionAsync(
        queryId,
        queryAdmissionId
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Query Response

Create a Query Response

```csharp
CreateQueryResponseAsync(
    Guid queryId,
    Models.QueryResponseCreation creationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `creationRequest` | [`QueryResponseCreation`](../../doc/models/query-response-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.QueryResponseResponse>`](../../doc/models/query-response-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
QueryResponseCreation creationRequest = new QueryResponseCreation
{
    Data = new NewQueryResponse
    {
        Attributes = new QueryResponseAttributes
        {
            Answer = QueryResponseAnswerEnum.TransactionNotProcessed,
        },
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("00000b24-0000-0000-0000-000000000000"),
        Type = "query_responses",
    },
};

try
{
    QueryResponseResponse result = await queryApiController.CreateQueryResponseAsync(
        queryId,
        creationRequest
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | gateway issue | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Query Response

Fetch a Query Response

```csharp
GetQueryResponseAsync(
    Guid queryId,
    Guid queryResponseId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `queryResponseId` | `Guid` | Template, Required | Query Response ID |

## Response Type

[`Task<Models.QueryResponseResponse>`](../../doc/models/query-response-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
Guid queryResponseId = new Guid("00000e02-0000-0000-0000-000000000000");
try
{
    QueryResponseResponse result = await queryApiController.GetQueryResponseAsync(
        queryId,
        queryResponseId
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
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Query Response Admission

Fetch a Query Response Admission

```csharp
GetQueryResponseAdmissionAsync(
    Guid queryId,
    Guid queryResponseId,
    Guid queryResponseAdmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `queryResponseId` | `Guid` | Template, Required | Query Response ID |
| `queryResponseAdmissionId` | `Guid` | Template, Required | Query Response Admission ID |

## Response Type

[`Task<Models.QueryResponseAdmissionResponse>`](../../doc/models/query-response-admission-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
Guid queryResponseId = new Guid("00000e02-0000-0000-0000-000000000000");
Guid queryResponseAdmissionId = new Guid("00000f22-0000-0000-0000-000000000000");
try
{
    QueryResponseAdmissionResponse result = await queryApiController.GetQueryResponseAdmissionAsync(
        queryId,
        queryResponseId,
        queryResponseAdmissionId
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Query Response Submission

Create a Query Response Submission

```csharp
CreateQueryResponseSubmissionAsync(
    Guid queryId,
    Guid queryResponseId,
    Models.QueryResponseSubmissionCreation creationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `queryResponseId` | `Guid` | Template, Required | Query Response ID |
| `creationRequest` | [`QueryResponseSubmissionCreation`](../../doc/models/query-response-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.QueryResponseSubmissionResponse>`](../../doc/models/query-response-submission-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
Guid queryResponseId = new Guid("00000e02-0000-0000-0000-000000000000");
QueryResponseSubmissionCreation creationRequest = new QueryResponseSubmissionCreation
{
    Data = new NewQueryResponseSubmission
    {
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("00000b24-0000-0000-0000-000000000000"),
        Type = "query_response_submissions",
    },
};

try
{
    QueryResponseSubmissionResponse result = await queryApiController.CreateQueryResponseSubmissionAsync(
        queryId,
        queryResponseId,
        creationRequest
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | gateway issue | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Query Response Submission

Fetch a Query Response Submission

```csharp
GetQueryResponseSubmissionAsync(
    Guid queryId,
    Guid queryResponseId,
    Guid queryResponseSubmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `queryResponseId` | `Guid` | Template, Required | Query Response ID |
| `queryResponseSubmissionId` | `Guid` | Template, Required | Query Response Submission ID |

## Response Type

[`Task<Models.QueryResponseSubmissionResponse>`](../../doc/models/query-response-submission-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
Guid queryResponseId = new Guid("00000e02-0000-0000-0000-000000000000");
Guid queryResponseSubmissionId = new Guid("00000a82-0000-0000-0000-000000000000");
try
{
    QueryResponseSubmissionResponse result = await queryApiController.GetQueryResponseSubmissionAsync(
        queryId,
        queryResponseId,
        queryResponseSubmissionId
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Query Submission

Create a Query submission

```csharp
CreateQuerySubmissionAsync(
    Guid queryId,
    Models.QuerySubmissionCreation creationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `creationRequest` | [`QuerySubmissionCreation`](../../doc/models/query-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.QuerySubmissionResponse>`](../../doc/models/query-submission-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
QuerySubmissionCreation creationRequest = new QuerySubmissionCreation
{
    Data = new NewQuerySubmission
    {
        Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
        OrganisationId = new Guid("00000b24-0000-0000-0000-000000000000"),
        Type = "query_submissions",
    },
};

try
{
    QuerySubmissionResponse result = await queryApiController.CreateQuerySubmissionAsync(
        queryId,
        creationRequest
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | gateway issue | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Query Submission

Fetch a Query submission

```csharp
GetQuerySubmissionAsync(
    Guid queryId,
    Guid querySubmissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `queryId` | `Guid` | Template, Required | Query ID |
| `querySubmissionId` | `Guid` | Template, Required | Query Submission ID |

## Response Type

[`Task<Models.QuerySubmissionResponse>`](../../doc/models/query-submission-response.md)

## Example Usage

```csharp
Guid queryId = new Guid("00000eba-0000-0000-0000-000000000000");
Guid querySubmissionId = new Guid("00001434-0000-0000-0000-000000000000");
try
{
    QuerySubmissionResponse result = await queryApiController.GetQuerySubmissionAsync(
        queryId,
        querySubmissionId
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
| 400 | bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

