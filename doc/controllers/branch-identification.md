# Branch Identification

```csharp
BranchIdentificationController branchIdentificationController = client.BranchIdentificationController;
```

## Class Name

`BranchIdentificationController`

## Methods

* [List Branch Identifications by Branch](../../doc/controllers/branch-identification.md#list-branch-identifications-by-branch)
* [Create an Identification for an Existing Branch](../../doc/controllers/branch-identification.md#create-an-identification-for-an-existing-branch)
* [Delete Branch Identification](../../doc/controllers/branch-identification.md#delete-branch-identification)
* [Get a Branch Identification by Id](../../doc/controllers/branch-identification.md#get-a-branch-identification-by-id)
* [Amend Branch Identification](../../doc/controllers/branch-identification.md#amend-branch-identification)


# List Branch Identifications by Branch

List Branch Identifications by Branch

```csharp
ListBranchIdentificationsByBranchAsync(
    Guid branchId,
    string pageNumber = null,
    int? pageSize = null,
    List<Guid> filterOrganisationId = null,
    List<string> filterSecondaryIdentification = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `branchId` | `Guid` | Template, Required | Branch Id to which this identification relates to |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterSecondaryIdentification` | `List<string>` | Query, Optional | Filter to only include branch identifications with specified secondary_identification |

## Response Type

[`Task<Models.BranchIdentificationListResponse>`](../../doc/models/branch-identification-list-response.md)

## Example Usage

```csharp
Guid branchId = new Guid("000005ee-0000-0000-0000-000000000000");
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    BranchIdentificationListResponse result = await branchIdentificationController.ListBranchIdentificationsByBranchAsync(branchId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create an Identification for an Existing Branch

Create an identification for an existing Branch

```csharp
CreateAnIdentificationForAnExistingBranchAsync(
    Guid branchId,
    Models.BranchIdentificationRequest branchIdentificationCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `branchId` | `Guid` | Template, Required | Branch Id to which this identification relates to |
| `branchIdentificationCreationRequest` | [`BranchIdentificationRequest`](../../doc/models/branch-identification-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.BranchIdentificationResponse>`](../../doc/models/branch-identification-response.md)

## Example Usage

```csharp
Guid branchId = new Guid("000005ee-0000-0000-0000-000000000000");
BranchIdentificationRequest branchIdentificationCreationRequest = new BranchIdentificationRequest
{
    Data = new BranchIdentification
    {
        Attributes = new BranchIdentificationAttributes
        {
            SecondaryIdentification = "secondary_identification2",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "branch_identifications",
        Version = 0,
    },
};

try
{
    BranchIdentificationResponse result = await branchIdentificationController.CreateAnIdentificationForAnExistingBranchAsync(
        branchId,
        branchIdentificationCreationRequest
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
| 409 | Branch Identification creation error, constraint violation of secondary identification | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Delete Branch Identification

Delete branch identification

```csharp
DeleteBranchIdentificationAsync(
    Guid branchId,
    Guid identificationId,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `branchId` | `Guid` | Template, Required | Branch Id |
| `identificationId` | `Guid` | Template, Required | Branch Identification Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid branchId = new Guid("000005ee-0000-0000-0000-000000000000");
Guid identificationId = new Guid("000011c0-0000-0000-0000-000000000000");
int version = 172;
try
{
    await branchIdentificationController.DeleteBranchIdentificationAsync(
        branchId,
        identificationId,
        version
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
| 404 | Branch Identification not found | `ApiException` |


# Get a Branch Identification by Id

Get a branch identification by id

```csharp
GetABranchIdentificationByIdAsync(
    Guid branchId,
    Guid identificationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `branchId` | `Guid` | Template, Required | Branch Id |
| `identificationId` | `Guid` | Template, Required | Branch Identification Id |

## Response Type

[`Task<Models.BranchIdentificationResponse>`](../../doc/models/branch-identification-response.md)

## Example Usage

```csharp
Guid branchId = new Guid("000005ee-0000-0000-0000-000000000000");
Guid identificationId = new Guid("000011c0-0000-0000-0000-000000000000");
try
{
    BranchIdentificationResponse result = await branchIdentificationController.GetABranchIdentificationByIdAsync(
        branchId,
        identificationId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Amend Branch Identification

Amend Branch Identification

```csharp
AmendBranchIdentificationAsync(
    Guid branchId,
    Guid identificationId,
    Models.BranchIdentificationRequest branchIdentificationAmendRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `branchId` | `Guid` | Template, Required | Branch Id |
| `identificationId` | `Guid` | Template, Required | Branch Identification Id; Must match id in the payload |
| `branchIdentificationAmendRequest` | [`BranchIdentificationRequest`](../../doc/models/branch-identification-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.BranchIdentificationResponse>`](../../doc/models/branch-identification-response.md)

## Example Usage

```csharp
Guid branchId = new Guid("000005ee-0000-0000-0000-000000000000");
Guid identificationId = new Guid("000011c0-0000-0000-0000-000000000000");
BranchIdentificationRequest branchIdentificationAmendRequest = new BranchIdentificationRequest
{
    Data = new BranchIdentification
    {
        Attributes = new BranchIdentificationAttributes
        {
            SecondaryIdentification = "secondary_identification2",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "branch_identifications",
        Version = 0,
    },
};

try
{
    BranchIdentificationResponse result = await branchIdentificationController.AmendBranchIdentificationAsync(
        branchId,
        identificationId,
        branchIdentificationAmendRequest
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
| 409 | Branch Identification update error, constraint violation of secondary identification | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

