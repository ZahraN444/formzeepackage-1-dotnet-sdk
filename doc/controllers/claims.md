# Claims

```csharp
ClaimsController claimsController = client.ClaimsController;
```

## Class Name

`ClaimsController`

## Methods

* [List Claims](../../doc/controllers/claims.md#list-claims)
* [Create Claim](../../doc/controllers/claims.md#create-claim)
* [Fetch Claim](../../doc/controllers/claims.md#fetch-claim)
* [Create Claim Reversal](../../doc/controllers/claims.md#create-claim-reversal)
* [Fetch Claim Reversal](../../doc/controllers/claims.md#fetch-claim-reversal)
* [Create Claim Reversal Submission](../../doc/controllers/claims.md#create-claim-reversal-submission)
* [Fetch Claim Reversal Submission](../../doc/controllers/claims.md#fetch-claim-reversal-submission)
* [Create Claim Submission](../../doc/controllers/claims.md#create-claim-submission)
* [Fetch Claim Submission](../../doc/controllers/claims.md#fetch-claim-submission)


# List Claims

List claims

```csharp
ListClaimsAsync(
    int? pageNumber = null,
    int? pageSize = null,
    List<Guid> filterOrganisationId = null,
    string filterPaymentScheme = null,
    string filterClearingId = null,
    string filterReference = null,
    string filterReasonCode = null,
    string filterContactName = null,
    string filterDebtorPartyAccountNumber = null,
    string filterDebtorPartyBankId = null,
    string filterBeneficiaryPartyAccountNumber = null,
    string filterBeneficiaryPartyBankId = null,
    string filterOriginalInstructionReference = null,
    string filterSubmissionStatus = null,
    DateTime? filterSubmissionSubmissionDateFrom = null,
    DateTime? filterSubmissionSubmissionDateTo = null,
    string filterReversalStatus = null,
    DateTime? filterReversalSubmissionDateFrom = null,
    DateTime? filterReversalSubmissionDateTo = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `int?` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterPaymentScheme` | `string` | Query, Optional | - |
| `filterClearingId` | `string` | Query, Optional | - |
| `filterReference` | `string` | Query, Optional | - |
| `filterReasonCode` | `string` | Query, Optional | - |
| `filterContactName` | `string` | Query, Optional | - |
| `filterDebtorPartyAccountNumber` | `string` | Query, Optional | - |
| `filterDebtorPartyBankId` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyAccountNumber` | `string` | Query, Optional | - |
| `filterBeneficiaryPartyBankId` | `string` | Query, Optional | - |
| `filterOriginalInstructionReference` | `string` | Query, Optional | - |
| `filterSubmissionStatus` | `string` | Query, Optional | - |
| `filterSubmissionSubmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterSubmissionSubmissionDateTo` | `DateTime?` | Query, Optional | - |
| `filterReversalStatus` | `string` | Query, Optional | - |
| `filterReversalSubmissionDateFrom` | `DateTime?` | Query, Optional | - |
| `filterReversalSubmissionDateTo` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ClaimDetailsListResponse>`](../../doc/models/claim-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    ClaimDetailsListResponse result = await claimsController.ListClaimsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Claim

Create Claim

```csharp
CreateClaimAsync(
    Models.ClaimCreation claimCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `claimCreationRequest` | [`ClaimCreation`](../../doc/models/claim-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ClaimDetailsResponse>`](../../doc/models/claim-details-response.md)

## Example Usage

```csharp
try
{
    ClaimDetailsResponse result = await claimsController.CreateClaimAsync();
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
| 400 | Claim creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Claim

Fetch claim

```csharp
FetchClaimAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |

## Response Type

[`Task<Models.ClaimDetailsResponse>`](../../doc/models/claim-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    ClaimDetailsResponse result = await claimsController.FetchClaimAsync(id);
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
| 400 | Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Claim Reversal

Create Claim Reversal

```csharp
CreateClaimReversalAsync(
    Guid id,
    Models.ClaimReversalCreation claimReversalCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |
| `claimReversalCreationRequest` | [`ClaimReversalCreation`](../../doc/models/claim-reversal-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ClaimReversalDetailsResponse>`](../../doc/models/claim-reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    ClaimReversalDetailsResponse result = await claimsController.CreateClaimReversalAsync(id);
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
| 400 | Claim Reversal creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Claim Reversal

Fetch Claim Reversal

```csharp
FetchClaimReversalAsync(
    Guid id,
    Guid reversalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |
| `reversalId` | `Guid` | Template, Required | Claim Reversal Id |

## Response Type

[`Task<Models.ClaimReversalDetailsResponse>`](../../doc/models/claim-reversal-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    ClaimReversalDetailsResponse result = await claimsController.FetchClaimReversalAsync(
        id,
        reversalId
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
| 400 | Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Claim Reversal Submission

Create Claim Reversal Submission

```csharp
CreateClaimReversalSubmissionAsync(
    Guid id,
    Guid reversalId,
    Models.ClaimReversalSubmissionCreation claimReversalSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |
| `reversalId` | `Guid` | Template, Required | Claim Reversal Id |
| `claimReversalSubmissionCreationRequest` | [`ClaimReversalSubmissionCreation`](../../doc/models/claim-reversal-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ClaimReversalSubmissionDetailsResponse>`](../../doc/models/claim-reversal-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
try
{
    ClaimReversalSubmissionDetailsResponse result = await claimsController.CreateClaimReversalSubmissionAsync(
        id,
        reversalId
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
| 400 | Claim Reversal creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Claim Reversal Submission

Fetch Claim Reversal Submission

```csharp
FetchClaimReversalSubmissionAsync(
    Guid id,
    Guid reversalId,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |
| `reversalId` | `Guid` | Template, Required | Claim Reversal Id |
| `submissionId` | `Guid` | Template, Required | Claim Reversal Submission Id |

## Response Type

[`Task<Models.ClaimReversalSubmissionDetailsResponse>`](../../doc/models/claim-reversal-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid reversalId = new Guid("0000181a-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    ClaimReversalSubmissionDetailsResponse result = await claimsController.FetchClaimReversalSubmissionAsync(
        id,
        reversalId,
        submissionId
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
| 400 | Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Claim Submission

Create Claim Submission

```csharp
CreateClaimSubmissionAsync(
    Guid id,
    Models.ClaimSubmissionCreation claimSubmissionCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |
| `claimSubmissionCreationRequest` | [`ClaimSubmissionCreation`](../../doc/models/claim-submission-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.ClaimSubmissionDetailsResponse>`](../../doc/models/claim-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    ClaimSubmissionDetailsResponse result = await claimsController.CreateClaimSubmissionAsync(id);
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
| 400 | Claim Submission creation error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Claim Submission

Fetch Claim Submission

```csharp
FetchClaimSubmissionAsync(
    Guid id,
    Guid submissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Claim Id |
| `submissionId` | `Guid` | Template, Required | Claim Submission Id |

## Response Type

[`Task<Models.ClaimSubmissionDetailsResponse>`](../../doc/models/claim-submission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid submissionId = new Guid("0000202c-0000-0000-0000-000000000000");
try
{
    ClaimSubmissionDetailsResponse result = await claimsController.FetchClaimSubmissionAsync(
        id,
        submissionId
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
| 400 | Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

