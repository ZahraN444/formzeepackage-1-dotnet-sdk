# Branches

```csharp
BranchesController branchesController = client.BranchesController;
```

## Class Name

`BranchesController`

## Methods

* [List Branches](../../doc/controllers/branches.md#list-branches)
* [Create a Branch](../../doc/controllers/branches.md#create-a-branch)
* [Delete Branch](../../doc/controllers/branches.md#delete-branch)
* [Fetch Branch](../../doc/controllers/branches.md#fetch-branch)
* [Amend Branch](../../doc/controllers/branches.md#amend-branch)


# List Branches

List branches

```csharp
ListBranchesAsync(
    string pageNumber = null,
    int? pageSize = null,
    List<Guid> filterOrganisationId = null,
    List<string> filterBankId = null,
    List<string> filterBankIdCode = null,
    List<string> filterAcceptanceQualifier = null,
    List<string> filterValidationType = null,
    List<string> filterReferenceMask = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterBankId` | `List<string>` | Query, Optional | Filter by bank id e.g. sort code or bic |
| `filterBankIdCode` | `List<string>` | Query, Optional | Filter by type of bank id e.g. "GBDSC" |
| `filterAcceptanceQualifier` | `List<string>` | Query, Optional | Filter by acceptance qualifier |
| `filterValidationType` | `List<string>` | Query, Optional | Filter by validation type e.g. card |
| `filterReferenceMask` | `List<string>` | Query, Optional | Filter by reference mask |

## Response Type

[`Task<Models.BranchDetailsListResponse>`](../../doc/models/branch-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    BranchDetailsListResponse result = await branchesController.ListBranchesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create a Branch

Create a Branch

```csharp
CreateABranchAsync(
    Models.BranchCreation branchCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `branchCreationRequest` | [`BranchCreation`](../../doc/models/branch-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.BranchCreationResponse>`](../../doc/models/branch-creation-response.md)

## Example Usage

```csharp
BranchCreation branchCreationRequest = new BranchCreation
{
    Data = new Branch
    {
        Attributes = new BranchAttributes
        {
            BankId = "400300",
            BankIdCode = "GBDSC",
            ReferenceMask = "4929############",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "branches",
        Version = 0,
    },
};

try
{
    BranchCreationResponse result = await branchesController.CreateABranchAsync(branchCreationRequest);
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
| 409 | Branch creation error, constraint violation of organisation id and bank id | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Delete Branch

Delete branch

```csharp
DeleteBranchAsync(
    Guid id,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Branch Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
int version = 172;
try
{
    await branchesController.DeleteBranchAsync(
        id,
        version
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Branch

Fetch branch

```csharp
FetchBranchAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Branch Id |

## Response Type

[`Task<Models.BranchDetailsResponse>`](../../doc/models/branch-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    BranchDetailsResponse result = await branchesController.FetchBranchAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Amend Branch

Amend branch

```csharp
AmendBranchAsync(
    Guid id,
    Models.BranchAmendment branchAmendRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Branches Id |
| `branchAmendRequest` | [`BranchAmendment`](../../doc/models/branch-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.BranchDetailsResponse>`](../../doc/models/branch-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    BranchDetailsResponse result = await branchesController.AmendBranchAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

