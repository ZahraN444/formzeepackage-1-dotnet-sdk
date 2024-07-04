# Organisations

```csharp
OrganisationsController organisationsController = client.OrganisationsController;
```

## Class Name

`OrganisationsController`

## Methods

* [List All Organisations](../../doc/controllers/organisations.md#list-all-organisations)
* [Create Organisation](../../doc/controllers/organisations.md#create-organisation)
* [Fetch Organisation](../../doc/controllers/organisations.md#fetch-organisation)
* [Update Organisation](../../doc/controllers/organisations.md#update-organisation)


# List All Organisations

List all organisations

```csharp
ListAllOrganisationsAsync(
    Guid? filterChildOrganisationId = null,
    List<Guid> filterOrganisationIds = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filterChildOrganisationId` | `Guid?` | Query, Optional | Child org id |
| `filterOrganisationIds` | `List<Guid>` | Query, Optional | Organisation ids |

## Response Type

[`Task<Models.OrganisationDetailsListResponse>`](../../doc/models/organisation-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    OrganisationDetailsListResponse result = await organisationsController.ListAllOrganisationsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Organisation

Create organisation

```csharp
CreateOrganisationAsync(
    Models.OrganisationCreation organisationCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organisationCreationRequest` | [`OrganisationCreation`](../../doc/models/organisation-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.OrganisationCreationResponse>`](../../doc/models/organisation-creation-response.md)

## Example Usage

```csharp
OrganisationCreation organisationCreationRequest = new OrganisationCreation
{
    Data = new Organisation
    {
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "organisations",
        Version = 0,
    },
};

try
{
    OrganisationCreationResponse result = await organisationsController.CreateOrganisationAsync(organisationCreationRequest);
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
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Organisation

Fetch organisation

```csharp
FetchOrganisationAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Organisation Id |

## Response Type

[`Task<Models.OrganisationDetailsResponse>`](../../doc/models/organisation-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    OrganisationDetailsResponse result = await organisationsController.FetchOrganisationAsync(id);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Update Organisation

Update organisation

```csharp
UpdateOrganisationAsync(
    Guid id,
    Models.OrganisationUpdate organisationUpdateRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Organisation Id |
| `organisationUpdateRequest` | [`OrganisationUpdate`](../../doc/models/organisation-update.md) | Body, Optional | - |

## Response Type

[`Task<Models.OrganisationDetailsResponse>`](../../doc/models/organisation-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
OrganisationUpdate organisationUpdateRequest = new OrganisationUpdate
{
    Data = new Organisation
    {
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "organisations",
        Version = 0,
    },
};

try
{
    OrganisationDetailsResponse result = await organisationsController.UpdateOrganisationAsync(
        id,
        organisationUpdateRequest
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
| 400 | Bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

